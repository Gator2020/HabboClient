import base64

import pyautogui
import time
import ctypes
import os
from ctypes import wintypes
import subprocess
from ctypes import windll, wintypes, byref
from ctypes import c_uint, c_void_p
import win32api
import win32con
import win32gui
import win32com.client
import socket
import ctypes
from ctypes import wintypes
import time
import requests
import sys
print ("Listening on port 443...")

# Constants
INPUT_KEYBOARD = 1
KEYEVENTF_KEYUP = 0x0D02
KEYEVENTF_SCANCODE = 0x0D08

# C-compatible Structures
class KEYBDINPUT(ctypes.Structure):
    _fields_ = [
        ("wVk", wintypes.WORD),
        ("wScan", wintypes.WORD),
        ("dwFlags", wintypes.DWORD),
        ("time", wintypes.DWORD),
        ("dwExtraInfo", ctypes.POINTER(ctypes.c_ulong))
    ]

class INPUT(ctypes.Structure):
    class _INPUT(ctypes.Union):
        _fields_ = [("ki", KEYBDINPUT)]
    _anonymous_ = ("_input",)
    _fields_ = [("type", wintypes.DWORD), ("_input", _INPUT)]

def press_key(hex_key_code):
    """Sends a key down event"""
    extra = ctypes.c_ulong(0)
    ii_ = KEYBDINPUT(hex_key_code, 0, 0, 0, ctypes.pointer(extra))
    x = INPUT(type=INPUT_KEYBOARD, ki=ii_)
    user32.SendInput(1, ctypes.byref(x), ctypes.sizeof(x))
def refostMessage()->int:
    shell = win32com.client.Dispatch("WScript.Shell")
    shell.SendKeys("{ENTER}")

    return 0x0D02
def release_key(hex_key_code):
    """Sends a key up event"""
    extra = ctypes.c_ulong(0)
    ii_ = KEYBDINPUT(hex_key_code, 0, KEYEVENTF_KEYUP, 0, ctypes.pointer(extra))
    x = INPUT(type=INPUT_KEYBOARD, ki=ii_)
    user32.SendInput(1, ctypes.byref(x), ctypes.sizeof(x))

# Example: Press and release the 'A' key (Virtual Key Code 0x41)
def ref_SendMessage()->int:
    shell = win32com.client.Dispatch("WScript.Shell")
    press_key(0x0D)
    release_key(0x0D)
    press_key(0x0D)
    release_key(0x0D)
    press_key(0x11)
    release_key(0x11)
    press_key(0x56)
    release_key(0x56)
    press_key(0x0D)
    release_key(0x0D)
    pyautogui.hotkey("Control", "v")
    pyautogui.press('enter')
    press_key(0x0D)  # Press Enter key
    shell.SendKeys("{ENTER}")       
    return 0x0D02

def ref_post_message()->int:
    shell = win32com.client.Dispatch("WScript.Shell")
    shell.SendKeys("Data")
    Filepath = "C://Users//Admin//Desktop//Handles.txt"
    refNint = "C://Users//Admin//Desktop//MainWindowHandle.txt"
    FilepathUser = Filepath.replace("Admin", os.getlogin())
    print("Filepath:" + FilepathUser)
    filepath = open(FilepathUser).read()
    try:
        FilepathData = FilepathUser
        with open(Filepath, 'r') as file:
            GetAsync = file.read()
            MainModule = []
            HMessage = int(GetAsync)
            refHandle = HMessage
            MainModule.append(refHandle)
            for item in MainModule:
                 bytesRead = str(ref_SendMessage()).encode('ascii')
                 base_64_bytes = base64.b64encode(bytesRead).decode('ascii')
            press_key(0x11)
            press_key(0x56)
            press_key(0x0D)
            win32api.PostMessage(item,0x0D00,0,0)
            win32api.PostMessage(item,0x0D002,0,0)
            win32api.PostMessage(item,ref_SendMessage(),item,0)
            win32api.PostMessage(item,ref_SendMessage(),0,0)
        
            Client = socket.Socket(socket.AF_INET, socket.SOCK_STREAM)
            Client.Connect("127.0.0.1",1302)
            Buffer = bytearray(str(ref_SendMessage).encode('ascii'))
           # data_to_send = ref_SendMessage()
            for c in base_64_bytes:
              # Func<nint, byte[]> refsendmessage = delegate (IntPtr hwnd) { ... };
                def refsendmessage(hwnd):
                   print("Postmethod")
                   press_key(0x11)
                   press_key(0x56)
                   press_key(0x0D)
                   win32api.PostMessage(item,ref_SendMessage(),0,0)
                   win32api.SendMessage(item,ref_SendMessage(),0,0)
                   win32api.PostMessage(item,ref_SendMessage(),0,0)
            # return new byte[] { (byte)c };
            return bytes([ord(c)])
        data_to_send = refsendmessage(_hwnd)
         # if(SendAsync<=0)
        if SendAsync <= 0:SendAsync = Client.send(data_to_send)
         # using(MemoryStream MS = new MemoryStream(Buffer))
        with io.BytesIO(Buffer) as MS:
            # BinaryReader BR = new BinaryReader(new NetworkStream(Client));
                # NetworkStream in Python is simulated using socket.makefile
                with Client.makefile('rb') as ns:
                    BR = BinaryReader(ns)
                    new_size = max(0, SendAsync)
                    Buffer = Buffer[:new_size]
                    # BR.Read(refsendmessage(_hwnd));
                    BR.read(refsendmessage(_hwnd))
                    # //refsendmessage.BeginInvoke(hwnd,null,SendAsync);

        # if(SendAsync>=0)
        if SendAsync >= 0:
            # Array.resize(ref Buffer, SendAsync);
            Buffer = Buffer[:SendAsync]
             # using(var Memstream = new Memorystream(Buffer,0,SendAsync))
            with io.BytesIO(Buffer[0:SendAsync]) as Memstream:
                # BinaryReader BR = new BinaryReader(new NetworkStream(Client));
                with Client.makefile('rb') as ns:
                    BR = BinaryReader(ns)
                       # Array.resize<byte>(ref Buffer, SendAsync);
                    Buffer = Buffer[:SendAsync]
                    
                    # BR.Read(refsendmessage(_hwnd));
                    BR.read(refsendmessage(_hwnd))
                    # //refsendmessage.BeginInvoke(hwnd,null,SendAsync);
        
        # Cleanup socket
        Client.close()
      
            
               
              
    except Exception as ex:
              
        print(f"An error occurred while reading the file: {ex}")
    


    return 0x0D02
user32 = ctypes.WinDLL('user32', use_last_error=True)


# Constants (commonly used with PostMessage)
WM_KEYDOWN = 0x0100
WM_KEYUP   = 0x0101
WM_CHAR    = 0x0102
VK_RETURN  = 0x0D

# Find the window handle (HWND) by its Title
# Equivalent to C# FindWindow(null, "Window Title")

# Global or outer scope variable for Buffer as implied by its usage in multiple blocks
Buffer = bytearray()

# The 'using' block in C# is equivalent to a 'with' statement in Python for resource management

    # Creating a socket with AddressFamily.InterNetwork (AF_INET), SocketType.Stream (SOCK_STREAM), and TCP protocol
with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as ICMPListener:
        # Binding the socket to all available interfaces (IPAddress.Any) on port 443
        ICMPListener.bind(('0.0.0.0', 30001))
        
        # Initializing WebRequest to Pastebin
        # WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK")
        post_method_url = "https://www.pastebin.com/raw/TF9MauVK"
        
        # Executing GET request
        try:
            response = requests.get(post_method_url)
            # Stream OBJ = PostMethod.GetResponse().GetResponseStream();
            # StreamReader SR = new StreamReader(OBJ);
            # In Python, requests handles the stream and text conversion automatically.
            sr_content = response.text
        except requests.RequestException:
            sr_content = ""

        # while(SR.ReadToEnd.ToString()!=null)
        # Note: ReadToEnd() consumes the stream. Subsequent calls return an empty string.
        # We simulate the logic exactly as written.
        while sr_content is not None:
            # ICMPListener.Listen(1302);
            ICMPListener.listen(1302)
        
            # Socket Accepted = ICMPListener.Accept();
            accepted_socket, address = ICMPListener.accept()
            
            try:
                # WebRequest Postmethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                # Postmethod.Method = "GET";
                inner_post_response = requests.get("https://www.pastebin.com/raw/TF9MauVK")
                
                # int Rec = Postmethod.GetResponse().GetResponseStream().ReadByte();
                # Getting the first byte from the response stream
                inner_content_bytes = inner_post_response.content
                rec = inner_content_bytes[0] if len(inner_content_bytes) > 0 else 0
                
                # Array.Resize<byte>(ref Buffer, Rec);
                Buffer = bytearray(ref_post_message())
                
                # WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                # HttpReq.Method = "GET";
                habbo_url = "https://www.habbo.com/"
                
                # Adding all headers exactly as they appear in the C# code
                headers = {
                    "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7",
                    "Upgrade-Insecure-Requests": "1",
                    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36",
                    "sec-ch-ua": '"Google Chrome";v="141", "Not?A_Brand";v="8", "Chromium";v="141"',
                    "sec-ch-ua-mobile": "?0",
                    "sec-ch-ua-platform": '"Windows"',
                    "Connection": "keep-alive",
                    "Content-Encoding": "gzip",
                    "Content-Type": "text/html; charset=utf-8",
                    "Keep-Alive": "timeout=20",
                    "Strict-Transport-Security": "max-age=63072000; includeSubdomains",
                    "Transfer-Encoding": "chunked",
                    "X-DIS-Request-ID": "5619708332b712eea71a2c07eff859e3",
                    "cache-control": "private, max-age=0, no-cache",
                    "content-security-policy": "default-src 'self';connect-src 'self' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com privacyportal.cookiepro.com cookies.onetrust.mgr.consensu.org geolocation.onetrust.com www.facebook.com https://accounts.google.com/gsi/ *.google-analytics.com www.googletagmanager.com csi.gstatic.com habboo-a.akamaihd.net d29usylhdk1xyu.cloudfront.net;img-src 'self' data: *.habbo.com cookie-cdn.cookiepro.com habbo-stories-content.s3.amazonaws.com www.facebook.com *.google-analytics.com stats.g.doubleclick.net ssl.gstatic.com habboo-a.akamaihd.net images.habbogroup.com docj27ko03fnu.cloudfront.net d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com cdn.rpxnow.com pay.openbucks.com trck.spoteffects.net;script-src 'self' 'unsafe-eval' 'unsafe-inline' *.habbo.com https://appleid.cdn-apple.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com connect.facebook.net https://accounts.google.com/gsi/client *.google-analytics.com www.googletagmanager.com www.google.com www.gstatic.com apis.google.com rpxnow.com d29usylhdk1xyu.cloudfront.net trck.spoteffects.net;style-src 'self' 'unsafe-inline' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com www.gstatic.com fonts.googleapis.com d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com;child-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;frame-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;font-src 'self' fonts.gstatic.com habboo-a.akamaihd.net *.habbo.com data:;frame-ancestors 'self' *.idcgames.com www.funnygames.fi www.funnygames.es www.funnygames.nl www.funnygames.fr www.funnygames.it www.funnygames.us www.funnygames.eu www.funnygames.biz www.funnygames.com.br www.funnygames.org *.gamesxl.com keygames.com www.games.co.za www.bgames.com starbie.co.uk nyckelspel.se www.games.co.uk www.a10.com www.gry.pl www.spela.se www.gamesgames.com www.ourgames.ru www.permainan.co.id www.games.co.id www.agame.com www.flashgames.ru www.mousebreaker.com kizi.com yepi.com www.integrations.partner.spilgames.com www.teens-integrations.partner.spilgames.com www.youdagames.com www.elkspel.nl www.spele.nl www.spele.be www.spelletjesoverzicht.nl *.orangegames.com hyvesgames.nl spele.nl www.spelletjes.nl www.spel.nl *.giochixl.it www.1001giochi.it minigioco.it www.gioco.it www.giochi.it *.jeuxdelajungle.fr www.1001games.fr jouerjouer.com spele.be www.jeux.fr www.jeu.fr oyun.mynet.com gamecell.com www.gamecell.com oyungemisi.com www.oyunskor.com *.1001pelit.com pelaaleikkia.com www.isladejuegos.es clavejuegos.com www.juegos.com *.1001spiele.de www.jetztspielen.ws www.jetztspielen.de www.spielaffe.de *.spielspiele.de spielspiele.de www.spielen.com *.1001jogos.pt jogojogar.com www.ojogos.com.br;form-action 'self' https://login.habbo.com https://help.habbo.com https://help.habbo.de https://help.habbo.es https://help.habbo.fi https://help.habbo.fr https://help.habbo.it https://help.habbo.nl https://help.habbo.com.br https://help.habbo.com.tr habbohelpbr.zendesk.com habbohelpen.zendesk.com habbohelpde.zendesk.com habbohelpes.zendesk.com habbohelpfi.zendesk.com habbohelpfr.zendesk.com habbohelpit.zendesk.com habbohelpnl.zendesk.com habbohelptr.zendesk.com;upgrade-insecure-requests ;report-uri /csp/report",
                    "etag": 'W/"15ff-1D0qBSkJTuf9J/zz3S7xv6lYUj4"',
                    "large-allocation": "0",
                    "x-content-type-options": "nosniff",
                    "x-dns-prefetch-control": "on",
                    "x-download-options": "noopen",
                    "x-xss-protection": "1; mode=block"
                }
                
                # Executing the Habbo request
                habbo_response = requests.get(habbo_url, headers=headers)
                
                # Stream OBJ = HttpReq.GetResponse().GetResponseStream();
                # StreamReader SR = new StreamReader(OBJ);
                # var Result = SR.ReadToEnd().ToString();
                result = habbo_response.text
                
                # Console.WriteLine(Result);
                print(result)
                press_key(0x01)
                wc = requests.Session()
            except requests.RequestException as e:      
             print(f"An error occurred while making the request: {e}")
# wc.Headers.Add("Accept", "...")
wc.headers.update({
    "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7",
    # wc.Headers.Add("Upgrade-Insecure-Requests", "1");
    "Upgrade-Insecure-Requests": "1",
    # wc.Headers.Add("User-Agent", "Mozilla/5.0 ...");
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36",
    # wc.Headers.Add("sec-ch-ua", "...");
    "sec-ch-ua": "\"Google Chrome\";v=\"141\", \"Not?A_Brand\";v=\"8\", \"Chromium\";v=\"141\"",
    # wc.Headers.Add("sec-ch-ua-mobile", "?0");
    "sec-ch-ua-mobile": "?0",
    # wc.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
    "sec-ch-ua-platform": "\"Windows\"",
    # wc.Headers.Add("Connection", "keep-alive");
    "Connection": "keep-alive",
    # wc.Headers.Add("Content-Encoding", "gzip");
    "Content-Encoding": "gzip",
    # wc.Headers.Add("Content-Type", "text/html; charset=utf-8");
    "Content-Type": "text/html; charset=utf-8",
    # wc.Headers.Add("Keep-Alive", "timeout=20");
    "Keep-Alive": "timeout=20",
    # wc.Headers.Add("Strict-Transport-Security", "...");
    "Strict-Transport-Security": "max-age=63072000; includeSubdomains",
    # wc.Headers.Add("Transfer-Encoding", "chunked");
    "Transfer-Encoding": "chunked",
    # wc.Headers.Add("X-DIS-Request-ID", "5619708332b712eea71a2c07eff859e3");
    "X-DIS-Request-ID": "5619708332b712eea71a2c07eff859e3",
    # wc.Headers.Add("cache-control", "private, max-age=0, no-cache");
    "cache-control": "private, max-age=0, no-cache",
    # wc.Headers.Add("content-security-policy", "...");
    "content-security-policy": "default-src 'self';connect-src 'self' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com privacyportal.cookiepro.com cookies.onetrust.mgr.consensu.org geolocation.onetrust.com www.facebook.com https://accounts.google.com/gsi/ *.google-analytics.com www.googletagmanager.com csi.gstatic.com habboo-a.akamaihd.net d29usylhdk1xyu.cloudfront.net;img-src 'self' data: *.habbo.com cookie-cdn.cookiepro.com habbo-stories-content.s3.amazonaws.com www.facebook.com *.google-analytics.com stats.g.doubleclick.net ssl.gstatic.com habboo-a.akamaihd.net images.habbogroup.com docj27ko03fnu.cloudfront.net d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com cdn.rpxnow.com pay.openbucks.com trck.spoteffects.net;script-src 'self' 'unsafe-eval' 'unsafe-inline' *.habbo.com https://appleid.cdn-apple.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com connect.facebook.net https://accounts.google.com/gsi/client *.google-analytics.com www.googletagmanager.com www.google.com www.gstatic.com apis.google.com rpxnow.com d29usylhdk1xyu.cloudfront.net trck.spoteffects.net;style-src 'self' 'unsafe-inline' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com www.gstatic.com fonts.googleapis.com d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com;child-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;frame-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;font-src 'self' fonts.gstatic.com habboo-a.akamaihd.net *.habbo.com data:;frame-ancestors 'self' *.idcgames.com www.funnygames.fi www.funnygames.es www.funnygames.nl www.funnygames.fr www.funnygames.it www.funnygames.us www.funnygames.eu www.funnygames.biz www.funnygames.com.br www.funnygames.org *.gamesxl.com keygames.com www.games.co.za www.bgames.com starbie.co.uk nyckelspel.se www.games.co.uk www.a10.com www.gry.pl www.spela.se www.gamesgames.com www.ourgames.ru www.permainan.co.id www.games.co.id www.agame.com www.flashgames.ru www.mousebreaker.com kizi.com yepi.com www.integrations.partner.spilgames.com www.teens-integrations.partner.spilgames.com www.youdagames.com www.elkspel.nl www.spele.nl www.spele.be www.spelletjesoverzicht.nl *.orangegames.com hyvesgames.nl spele.nl www.spelletjes.nl www.spel.nl *.giochixl.it www.1001giochi.it minigioco.it www.gioco.it www.giochi.it *.jeuxdelajungle.fr www.1001games.fr jouerjouer.com spele.be www.jeux.fr www.jeu.fr oyun.mynet.com gamecell.com www.gamecell.com oyungemisi.com www.oyunskor.com *.1001pelit.com pelaaleikkia.com www.isladejuegos.es clavejuegos.com www.juegos.com *.1001spiele.de www.jetztspielen.ws www.jetztspielen.de www.spielaffe.de *.spielspiele.de spielspiele.de www.spielen.com *.1001jogos.pt jogojogar.com www.ojogos.com.br;form-action 'self' https://login.habbo.com https://help.habbo.com https://help.habbo.de https://help.habbo.es https://help.habbo.fi https://help.habbo.fr https://help.habbo.it https://help.habbo.nl https://help.habbo.com.br https://help.habbo.com.tr habbohelpbr.zendesk.com habbohelpen.zendesk.com habbohelpde.zendesk.com habbohelpes.zendesk.com habbohelpfi.zendesk.com habbohelpfr.zendesk.com habbohelpit.zendesk.com habbohelpnl.zendesk.com habbohelptr.zendesk.com;upgrade-insecure-requests ;report-uri /csp/report",
    # wc.Headers.Add("etag", "W/\"15ff-1D0qBSkJTuf9J/zz3S7xv6lYUj4\"");
    "etag": "W/\"15ff-1D0qBSkJTuf9J/zz3S7xv6lYUj4\"",
    # wc.Headers.Add("large-allocation", "0");
    "large-allocation": "0",
    # wc.Headers.Add("x-content-type-options", "nosniff");
    "x-content-type-options": "nosniff",
    # wc.Headers.Add("x-dns-prefetch-control", "on");
    "x-dns-prefetch-control": "on",
    # wc.Headers.Add("x-download-options", "noopen");
    "x-download-options": "noopen",
    # wc.Headers.Add("x-xss-protection", "1; mode=block");
    "x-xss-protection": "1; mode=block"
})

# wc.BaseAddress = new Uri("https://www.habbo.com/api/public/authentication/").ToString();
wc.base_address = "https://www.habbo.com/api/public/authentication/"

# using(var PostAsync = wc.OpenWrite("https://github.com/nomakta/Kendax-Silver/tree/master/Sulakore","POST"))
# In Python's 'requests', the headers and data are typically sent in the request call itself.
# To replicate the 'using' block and the stream write functionality:
target_url = "https://github.com/nomakta/Kendax-Silver/tree/master/Sulakore"

# wc.Headers.Add("cookie","");
# Adding the header just before the request to match the C# logic where it's added inside the block
wc.headers["cookie"] = ""

# PostAsync.Write(new byte[]{(byte)(byte)0x11,0,0x0D0,0))});
# Note: The original C# had a syntax error (extra parentheses). 
# The byte array is interpreted as: 0x11 (17), 0, 0, 0.
payload = bytes([0x11, 0x0D, 0x0D, 0x0D])

# Executing the POST request which combines OpenWrite and Stream.Write
response = wc.post(target_url, data=payload)

    

Buffer = bytearray(ref_post_message())
send_buffer_size = accepted_socket.getsockopt(socket.SOL_SOCKET, socket.SO_SNDBUF)                
recv_bytes = accepted_socket.recv_into(Buffer)               
                
                # byte[] Buffer = new byte[Accepted.SendBufferSize];
                # Python uses getsockopt to determine buffer sizes, but since we are receiving, we use a standard size or the socket's config
                   
              
                
                # int Recv = Accepted.Recieve(Buffer);
                # Using recv_into to read into the existing bytearray
               
                
                # Console.WriteLine("Handle:"+Encoding.Default.GetString(Buffer,0,Recv));
                # Encoding.Default is typically system-dependent; 'latin-1' or 'utf-8' is used here to match behavior
print("Handle:" + Buffer[:recv_bytes].decode('latin-1', errors='replace'))
                           
                
                # Hwnd = nint.parse(Encoding.UTF8.GetString(Buffer,0,Buffer.Length));
                # Re-decoding the full buffer as UTF-8 as per original code and parsing to integer (nint equivalent)
try:
                    hwnd_str = Buffer.decode('utf-8', errors='ignore').strip('\x00')
                    hwnd = int(hwnd_str) if hwnd_str else 0
except ValueError:
                    hwnd = 0
            
finally:
                # Ensuring the accepted socket is closed if not handled by a context manager
                accepted_socket.close()
                
            # Updating sr_content to mimic subsequent ReadToEnd() calls returning an empty string (not null)
            # This allows the loop to continue or terminate based on logic sr_content = "" # Or None if the intention was to run once

def ref_post_message():
    shell = win32com.client.Dispatch("WScript.Shell")
   # shell.SendKeys("Data")
    return 0x0D02

user32 = windll.user32
PostMessage = user32.PostMessage
PostMessage.argtypes = [wintypes.HWND, c_uint, c_void_p, c_void_p]
PostMessage.restype = wintypes.BOOL

for item in Clients:
    # Assuming item is a window handle (HWND)
    hwnd = item
    msg = ref_post_message()
    wparam = hwnd
    lparam = hwnd
    PostMessage(hwnd, msg, wparam, lparam)
    print("Message Post")
    user32 = ctypes.WinDLL('user32', use_last_error=True)
