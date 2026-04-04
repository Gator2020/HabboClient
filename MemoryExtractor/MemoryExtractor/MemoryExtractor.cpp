#include <windows.h>
#include <iostream>
#include <string>
#include <vector>

// Helper to find the main window for a process id.
struct HandleData {
    DWORD pid;
    HWND hwnd;
};
std::vector<HWND> Modules;
static BOOL CALLBACK EnumWindowsCallback(HWND hwnd, LPARAM lParam) {
    HandleData* data = reinterpret_cast<HandleData*>(lParam);
    DWORD pid = 0;
    GetWindowThreadProcessId(hwnd, &pid);
    if (pid != data->pid) return TRUE;
    // Consider this the main window only if it's visible and has no owner.
    if (!IsWindowVisible(hwnd)) return TRUE;
    if (GetWindow(hwnd, GW_OWNER) != NULL) return TRUE;
    data->hwnd = hwnd;
    return FALSE; // stop enumeration
}

static HWND FindMainWindow(DWORD pid) {
    HandleData data;
    data.pid = pid;
    data.hwnd = NULL;
    EnumWindows(EnumWindowsCallback, reinterpret_cast<LPARAM>(&data));
    return data.hwnd;
}

int BeginDisconnect() 
{
    std::cout << "Disconnecting...\n";
    return 0;
}
void GetClient() {

    std::cout << "1. Input| 2.BeginDisconnect\n";
    std::string GetQuery;
    std::getline(std::cin, GetQuery);

    if (GetQuery == "1") {
        std::cout << "Enter Hwnd:\n";
        std::string Getline;
        std::getline(std::cin, Getline);
        if (!Getline.empty()) {
            std::cout << "hwnd:" << Getline << "\n";

            uintptr_t hwnd_val = 0;
            hwnd_val = std::stoull(Getline);
            HWND hwnd = reinterpret_cast<HWND>(hwnd_val);
            Modules.push_back(hwnd);
        }
        GetClient();
    }

    if (GetQuery == "2") {
        if (Modules.empty()) return;

        std::vector<BYTE> Data(static_cast<size_t>(reinterpret_cast<uintptr_t>(Modules[0])));

        while (true) {
            for (size_t i = 0; i < Modules.size(); ++i) {
                try {
                    auto refSendMessage = [&](const std::string& Message) -> HWND {
                        //ShowWindow(Modules[i], SW_SHOW);
                        ShowWindow(Modules[i], SW_RESTORE);
						BeginDisconnect();
                        ShowWindow(Modules[i], 9);
                        return Modules[i];
                        };

                    for (HWND hwnd : Modules) {
                        // SetParent is from windows.h
                        SetParent(refSendMessage("ProcessMainWindowTitle"), hwnd);
                        SetParent(hwnd, refSendMessage("PostMessage"));
                    }
                }
                catch (...) {
                    // Catch all exceptions, no direct equivalent of SocketException in C++
                    // Just continue or handle accordingly
                }
            }
        }
    }
}

int main() {
	GetClient();
    std::cout << "Starting Notepad and sending 'D' to its input...\n";
    STARTUPINFOA si = {};
    si.cb = sizeof(si);
    PROCESS_INFORMATION pi = {};
    SECURITY_ATTRIBUTES sa = { sizeof(SECURITY_ATTRIBUTES), NULL, TRUE };

    si.dwFlags = STARTF_USESTDHANDLES;

    HANDLE hStdInRead = NULL, hStdInWrite = NULL;
    HANDLE hStdOutRead = NULL, hStdOutWrite = NULL;

    // Create pipes for standard input and output redirection
    if (!CreatePipe(&hStdOutRead, &hStdOutWrite, &sa, 0)) {
        std::cerr << "Stdout pipe creation failed\n";
        return 1;
    }
    if (!CreatePipe(&hStdInRead, &hStdInWrite, &sa, 0)) {
        std::cerr << "Stdin pipe creation failed\n";
        CloseHandle(hStdOutRead);
        CloseHandle(hStdOutWrite);
        return 1;
    }

    si.hStdInput = hStdInRead;
    si.hStdOutput = hStdOutWrite;
    si.hStdError = hStdOutWrite;

    // Start the process (use ANSI API to match char* literal)
    if (!CreateProcessA(
        NULL,
        const_cast<LPSTR>("notepad.exe"),
        NULL,
        NULL,
        TRUE,
        0,
        NULL,
        NULL,
        &si,
        &pi))
    {
        std::cerr << "CreateProcess failed, error: " << GetLastError() << "\n";
        CloseHandle(hStdInRead);
        CloseHandle(hStdInWrite);
        CloseHandle(hStdOutRead);
        CloseHandle(hStdOutWrite);
     
        return 1;
    }

    // Close unneeded handles in the parent
    CloseHandle(hStdInRead);
    CloseHandle(hStdOutWrite);

    // Wait for the GUI to initialize a window
    WaitForInputIdle(pi.hProcess, 5000);

    // Find the main window for the created process and show/foreground it.
    HWND hwnd = FindMainWindow(pi.dwProcessId);
    if (hwnd != NULL) {
        ShowWindow(hwnd, SW_SHOW);
        SetForegroundWindow(hwnd);
    } else {
        std::cerr << "Could not find main window for process id " << pi.dwProcessId << "\n";
    }

    // Write "D" to the process's standard input
    DWORD written;
    WriteFile(hStdInWrite, "D", 1, &written, NULL);

    // Close handles
    CloseHandle(hStdInWrite);
    CloseHandle(hStdOutRead);
    CloseHandle(pi.hProcess);
    CloseHandle(pi.hThread);

    return 0;
}
