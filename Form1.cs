using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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
            timer1.Start();


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
                ShowWindow(hwnd, 9);

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
                        Clients[x].Kill();
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
        public List<ClientForm> FormClientsModules = new List<ClientForm>();
        private void button1_Click(object sender, EventArgs e)
        {
            //webView21.Source = new Uri("https://10minutemail.com/");

            // Byte[] Buffer = {byte)int.Parse(richTextBox2.Text.ToString())}

            var Filepath = "C:\\Users\\Admin\\Desktop\\HomeRoom.js";
            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));

            MessageBox.Show("Test");
            timer1.Stop();
            checkBox1.Enabled = true;
            ClientForm HandleRef = new ClientForm();
            HandleRef.CanSelect.Equals(true);
            HandleRef.CanFocus.Equals(true);
            HandleRef.TopMost = false;
            HandleRef.TopLevel = false;
            panel1.Controls.Add(HandleRef);
            HandleRef.Show();
            FormClientsModules.Add(HandleRef);
            checkedListBox1.Items.Add(HandleRef.Handle);



        }

        public static List<HConnection> ConnectionHandlers = new List<HConnection>();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 4052;
            button4.Enabled = false;
            webView21.Source = new Uri("https://www.croxyproxy.com");
            Program.BeginConnect();

            //timer1.Start();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SelectedIndex = i;

            }

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://69.172.200.161/public/api");
            using (var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/api/public/authentication/loginv2"))
            {
                var GetAsync = httpClient.GetAsync("https://www.habbo.com/logout/");
                const char BeginRead = '"';
                const char EndRead = '"';
                Console.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//Index.php");
                // SW.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                var HControl = new Apphost.Form1();
                SW.WriteLine("echo'0';");
                // MessageBox.Show("Disconnection" + HControl.Handle);
                List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<HConnection, Apphost.Form1> PostMessage = delegate (HConnection Client) { SW.Close(); SW.Dispose(); return HControl; }; HConnection ClientSocket = new HConnection(PostMessage(new HConnection(HControl))); }) } };
                WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                PostMethod.Method = "GET";
                WebClient wc = new WebClient();
                wc.Headers.Add("browser_token", "s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                PostMethod = (HttpWebRequest)WebRequest.CreateHttp("https://www.habbo.com/api/public");
                PostMethod.Method = "POST";
                PostMethod.Headers.Add("Cookie", "browser_token=s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                PostMethod.Headers.Add("Cache-Control", "no-cache");
                PostMethod.Headers.Add("dis-remote-addr", "69.172.200.161");
                PostMethod.Headers.Add("dis-request-id", "f28528bd3777ae9afad20a86c6475bd1");
                wc.Headers.Add("Cache-Control", "no-cache");
                PostMethod.Headers.Add("User-Agent", "PostmanRuntime/7.53.0");
                PostMethod.Headers.Add("Cookie", "dis-remote-addr=107.207.178.195; dis-request-id=f28528bd3777ae9afad20a86c6475bd1; dis-timestamp=2026-04-03T08:59:33-07:00; browser_token=s%3AfX9Flf60GEK9fZzRZKKAQQJH3qo4Juk0-mXTsg6C9L0.%2BEjhGFr657X29Hovpqf82%2BBNZEz0pBTM6kcTlI0EohU; OptanonAlertBoxClosed=2025-04-22T03:29:39.458Z; __utmz=78068493.1745294001.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); fbm_1417574575138432=base_domain=.habbo.com; __utma=78068493.2028069325.1745294001.1761398407.1774626342.6; session.id=s%3AW1ACrPQVWJTpHGiDMylRuQ0JD2h6Lfa2VsqtIWx7AyE.VlXb0qJSY1apZS1K9AbGOUoBUzw57QDj5qhuJybCvPc; OptanonConsent=isGpcEnabled=0&datestamp=Fri+Apr+03+2026+10%3A59%3A18+GMT-0500+(Central+Daylight+Time)&version=202409.1.0&browserGpcFlag=0&isIABGlobal=false&hosts=&consentId=3228473e-b43f-4f9b-8428-7c7a6bf59eab&interactionCount=1&isAnonUser=1&landingPath=NotLandingPage&groups=C0002%3A1%2CC0004%3A1%2CC0001%3A1%2CC0003%3A1&intType=1&geolocation=%3B&AwaitingReconsent=false; fbsr_1417574575138432=ilBFv_AePDvau6iBfu5B-Z1Mf-IUNMFNsfp45a32BLM.eyJ1c2VyX2lkIjoiMTIzNTUwMjE2ODg5NDM0IiwiY29kZSI6IkFRQXVBLW12MF9fYV9hQktDY3dhbFJkUUpRYVVEcmFLYXlKTUZjVmdUWmxkSlk0R3d6U0tKTTQ3TGtJanNSN3gtd1lxUHY2b1hTWG5XU3diY2pQVUhmbzZoS251SnM5YXFJbW5IT29uV0x0M051Vl9RUnV2WVlZQldDdnBIZmJmaTcxRXpTR2hwdTI0Y0tMS1lEOVNVUGhHYUJ6YmJNZmRqX3BBa2NQMkJaRDg0eHFMX1lxNktwTVJTenpEcHprbGpRYmtYYXVKcE5zUGFwaVB6V2pwLWU1SGxaQlpCUzZKZEplaTZ6NlBYM1NkZFoxUldQa2ZxYjIwOVUwaGFhTnpxSElmTnhHWTlXVlpTQU9LUzVQNlptLUloR0FZTDdMek1NRlczMzBFeUQzemk0cktVOEZqU0RCRm9UTkY1bGxRY0xlbURVTW5pejc3VU9iNWJ6UGxlaHFBbGhKNjdhZmxtTFdyZnpRUERPUFM1ZyIsIm9hdXRoX3Rva2VuIjoiRUFBVUpSc3paQlpBb0FCUVpDaXV6RklaQkZNdEYycGozZWZyTG9RUWJiV3BFRnJlNm5taUdaQzhNTXgyb3JScFpCUmlhUmpTUFlRUHd3RDh2OGhRWVpCSll0QUUyMFVXODdxb0JtTjdPa2l6T1pBQ2tKR2pGSHVrZXBWWkNSWkM5UXpZZURwTVRidjl6R29aQlZWSHJZQVl6TGRuWThwV3VySVBBVnlrV2RYVXF6cFhmYjlWVGNFZVZYTmtpcTNNYnQxVXRYMldscHhHOERFWkQiLCJhbGdvcml0aG0iOiJITUFDLVNIQTI1NiIsImlzc3VlZF9hdCI6MTc3NTIzMTk1OH0");
                PostMethod.Headers.Add("browser_token", "s%3AfX9Flf60GEK9fZzRZKKAQQJH3qo4Juk0-mXTsg6C9L0.%2BEjhGFr657X29Hovpqf82%2BBNZEz0pBTM6kcTlI0EohU");
                wc.Headers.Add("fbm_1417574575138432", "base_domain=.habbo.com");
                PostMethod.Headers.Add("fbm_1417574575138432", "base_domain =.habbo.com");
                wc.Headers.Add("Accept", "*/*");
                wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/145.0.0.0 Safari/537.36 Edg/145.0.0.0");
                wc.BaseAddress = new Uri("https://www.habbo.com/api/public/").ToString();
                PostMethod.Method = "GET";
                var PostAsync = wc.OpenWrite(PostMethod.RequestUri, "POST");
                var FilepathData = "C://Users//" + Environment.UserName + "//Desktop//Index.php";
                StreamWriter SWFile = new StreamWriter(FilepathData);
                SWFile.WriteLine("echo'www.localhost:443'");
                SWFile.Close(); SWFile.Dispose();




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
                foreach (ClientForm c in FormClientsModules)
                {
                    if (c.Handle != IntPtr.Zero)
                    {
                        Process MainProc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
                        Process[] Clients = Process.GetProcessesByName(MainProc.ProcessName);
                        foreach (var items in Clients)
                        {

                            return items.HasExited;
                        }
                        SetParent(c.Handle, panel1.Handle);
                        c.CanSelect.Equals(true);
                        PostMessage = delegate (IntPtr hwnd) { MessageBox.Show("https://www.habbo.com"); return new byte[] { }; };
                        const int Publickey = 19;
                        c.Show();
                        c.Select();
                        c.Dock = DockStyle.Fill;
                        SetParent(c.Handle, panel1.Handle);
                        //ShowWindow(c.Handle, 9);
                        [DllImport("user32.dll")]
                        static extern bool SetForegroundWindow(IntPtr hwnd);
                        //SetForegroundWindow(c.Handle);


                    }
                }
                MessageBox.Show("Test");

                {
                    MessageBox.Show("Disconnection");
                    // return true;
                }
            }
            if (er != SslPolicyErrors.None)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
                foreach (ClientForm c in FormClientsModules)
                {
                    if (c.Handle != IntPtr.Zero)
                    {
                        Process MainProc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
                        Process[] Clients = Process.GetProcessesByName(MainProc.ProcessName);
                        foreach (var items in Clients)
                        {

                            return items.HasExited;
                        }
                        SetParent(c.Handle, panel1.Handle);
                        c.CanSelect.Equals(true);
                        PostMessage = delegate (IntPtr hwnd) { MessageBox.Show("https://www.habbo.com"); return new byte[] { }; };
                        const int Publickey = 19;
                        c.Show();
                        c.Select();
                        c.Dock = DockStyle.Fill;
                        SetParent(c.Handle, panel1.Handle);
                        //ShowWindow(c.Handle, 9);
                        [DllImport("user32.dll")]
                        static extern bool SetForegroundWindow(IntPtr hwnd);
                        //SetForegroundWindow(c.Handle);


                    }
                }


                {
                    // return true;
                }
            }

            return false;
        }
        public static List<Process> ClientModules = new List<Process>();

        public virtual void DisconnectionHandler()
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            foreach (ClientForm c in FormClientsModules)
            {
                if (c.Handle != IntPtr.Zero)
                {
                    Process MainProc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
                    Process[] Clients = Process.GetProcessesByName(MainProc.ProcessName);
                    foreach (var items in Clients)
                    {
                        c.MinimizeBox = true;
                        c.MinimizeBox.Equals(true);
                        c.Size = new Size(0, 0);


                    }
                    SetParent(c.Handle, panel1.Handle);
                    c.CanSelect.Equals(true);
                    PostMessage = delegate (IntPtr hwnd) { return new byte[] { }; };
                    const int Publickey = 19;
                    c.Show();
                    c.Select();
                    c.Dock = DockStyle.Fill;
                    c.SelectNextControl(this, false, true, false, true);


                    c.Select();

                    //SetForegroundWindow(c.Handle);
                }
            }
        }
        public void ConnectionCallback(IAsyncResult AR)
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern bool ShowWindow(IntPtr hwnd, int nCmdshow);
            foreach (ClientForm c in FormClientsModules)
            {
                if (c.Handle != IntPtr.Zero)
                {
                    Process MainProc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
                    Process[] Clients = Process.GetProcessesByName(MainProc.ProcessName);
                    foreach (var items in Clients)
                    {
                        c.MinimizeBox = true;
                        c.MinimizeBox.Equals(true);
                        c.Size = new Size(0, 0);
                        

                    }
                    SetParent(c.Handle, panel1.Handle);
                    c.CanSelect.Equals(true);
                    PostMessage = delegate (IntPtr hwnd) { return new byte[] { }; };
                    const int Publickey = 19;
                    c.Show();
                    c.Select();
                    c.Dock = DockStyle.Fill;
                    c.SelectNextControl(this, false, true, false, true);
                   
                 
                    c.Select();

                    //SetForegroundWindow(c.Handle);
                }
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            var Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint Endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001);
            EndPoint EndpointIp = Endpoint;
            Sock.BeginConnect(EndpointIp, new AsyncCallback(ConnectionCallback), sender);
            Sock.Close();
            Sock.Dispose();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //webView21.Source = new Uri("https://10minutemail.com/");

            // Byte[] Buffer = {byte)int.Parse(richTextBox2.Text.ToString())}

            var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
            
            var script = Filepath.Replace("Admin", Environment.UserName);
            webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientModules.Add(Process.GetProcessById(int.Parse(textBox2.Text.ToString())));
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);

        [DllImport("Apphost.dll")]
        public static extern string refPostMessage();

        
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1302;
            timer1.Start();
            // Call this duri
            SetDllDirectory(@"C:\Users\Lenovo\source\repos\Apphost\Apphost\bin\x64\Release\net8.0-windows\Apphost.dll");

            // MessageBox.Show("Test");
            foreach (HConnection ConnectedClients in ConnectionHandlers)
            {
                try
                {
                    IPEndPoint LocalendPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1302);
                    EndPoint RemoteEndpoint = LocalendPoint;
                    Func<IntPtr, byte[]> refSendMessage = delegate (IntPtr hwnd) { return new byte[Apphost.Form1.ServerGameSocket.SendBufferSize]; };
                    int Recv = ConnectedClients.Client.Receive(refSendMessage(Apphost.Form1.ClientSocket.Handle));
                    byte[] BufferRecv = refSendMessage(Apphost.Form1.ClientSocket.Handle);
                    Array.Resize(ref BufferRecv, Recv);
                    Apphost.Form1.ClientSocket.BeginConnect(RemoteEndpoint, new AsyncCallback(ConnectionCallback), sender);
                    byte[] Buffer = new byte[Apphost.Form1.ServerGameSocket.SendBufferSize];
                    byte[] RecvData = new byte[ConnectedClients.Client.ReceiveBufferSize];
                    int SendAsync = Apphost.Form1.ClientSocket.Send(BufferRecv, 0, SocketFlags.None);
                    sender = new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Array.Resize<byte>(ref Buffer, SendAsync); Array.Resize(ref RecvData, SendAsync); }) }[0];
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
            BeginDisconnect.Interval = int.Parse(textBox3.Text.ToString());
            BeginDisconnect.Start();
            webView21.Source = new Uri("https://www.pastebin.com/raw/TF9MauVK");
            webView21.ExecuteScriptAsync("var oimg = document.creatElement('img');oimg.setAttribute('src','http://localhost:443/'); oimg.setAttribute('class','imager'); oimg.setAttribute('width','300px'); oimg.setAttribute('height','450px'); document.body.appendChild(oimg); var XHR = new XMLHttpRequest(); XHR.open('POST','https://www.habbo.com/api/public/authentication/loginv2'); XHR.setRequestHeader('email','zeroxhabbo@gmail.com'); XHR.send(document.getEelementsByClassName('imager'));");

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            BeginDisconnect.Stop();
        }
    }
}
