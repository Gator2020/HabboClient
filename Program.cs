using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static List<System.Reflection.ParameterModifier> parameterModifiers = new List<System.Reflection.ParameterModifier>();
        public static System.Reflection.ParameterModifier MethodInfo()
        {
            foreach(System.Diagnostics.Process x in Form1.ClientModules)
            {
                long lpBaseAddress = 0x0 *1*x.MainModule.BaseAddress;
                IntPtr hwndRefHandler = (IntPtr)lpBaseAddress;
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
                static extern bool PostMessage(IntPtr hwnd, uint Message, IntPtr LpARAM, IntPtr WpARAM);
                PostMessage(x.MainWindowHandle, new byte[] { 0x11, 0, 0x0000, 0 }[0], IntPtr.Zero, x.Handle);
                PostMessage(x.MainWindowHandle, new byte[] { 0x11, 0, 0x0002, 0 }[0], IntPtr.Zero, x.MainWindowHandle);
                ShowWindow(hwndRefHandler, 9);
                SetParent(hwndRefHandler, x.MainWindowHandle);
                SetParent(x.MainWindowHandle, hwndRefHandler);

                return parameterModifiers[0];
            }
            return MethodInfo();
        }
        public static System.Reflection.MethodBase[] runtimeMethodHandle()
        {
            parameterModifiers.Add(MethodInfo());
            return runtimeMethodHandle();
        }
        public static void ConnectionCallBack(IAsyncResult AR)
        {
            Form1 Application = new Form1();
            while(AR.AsyncState!=null)
            {
                switch(Application.CanSelect)
                {
                    case false:
                        {
                            #region sort
                            [DllImport("user32.dll")]
                            static extern void PostMessage(IntPtr hwnd, uint Msg, IntPtr Lparam, IntPtr wParam);
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            foreach(System.Diagnostics.Process x in Form1.ClientModules)
                            {
                                System.Reflection.Binder AttributeBinder = null;
                                List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<byte[], IntPtr> SendMesage = delegate (byte[] hwnd) { runtimeMethodHandle(); return x.MainWindowHandle; };Console.WriteLine(SendMesage(new byte[] { })); PostMessage(x.MainWindowHandle, (uint)SendMesage(new byte[] { 0x11 }), IntPtr.Zero, x.MainWindowHandle); }) } };
                                object[] DataGram = { DisposedBuffer[0] };
                                foreach (var item in DataGram)
                                {
                                    object Hmessage = item;
                                    AttributeBinder.BindToMethod(System.Reflection.BindingFlags.CreateInstance, ((System.Reflection.MethodBase[])runtimeMethodHandle()),ref DataGram, new System.Reflection.ParameterModifier[] { parameterModifiers[0] }, System.Globalization.CultureInfo.CurrentCulture, new string[] { x.MainWindowTitle }, out Hmessage);
                                    x.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DisposedBuffer[0]);
                                    x.MainModule.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);
                                    x.MainWindowHandle.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);

                                }
                            }
                            break;
                            #endregion
                        }

                    case true:
                        {
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            [DllImport("user32.dll")]
                            static extern void PostMessage(IntPtr hwnd, uint Msg, IntPtr Lparam, IntPtr wParam);
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            foreach (System.Diagnostics.Process x in Form1.ClientModules)
                            {
                                System.Reflection.Binder AttributeBinder = null;
                                List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<byte[], IntPtr> SendMesage = delegate (byte[] hwnd) { runtimeMethodHandle(); return x.MainWindowHandle; }; Console.WriteLine(SendMesage(new byte[] { })); PostMessage(x.MainWindowHandle, (uint)SendMesage(new byte[] { 0x11 }), IntPtr.Zero, x.MainWindowHandle); }) } };
                                object[] DataGram = { DisposedBuffer[0] };
                                foreach (var item in DataGram)
                                {
                                    object Hmessage = item;
                                    AttributeBinder.BindToMethod(System.Reflection.BindingFlags.CreateInstance, ((System.Reflection.MethodBase[])runtimeMethodHandle()), ref DataGram, new System.Reflection.ParameterModifier[] { parameterModifiers[0] }, System.Globalization.CultureInfo.CurrentCulture, new string[] { x.MainWindowTitle }, out Hmessage);
                                    x.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DisposedBuffer[0]);
                                    x.MainModule.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);
                                    x.MainWindowHandle.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);

                                }
                            }
                            break;
                        }
                }
            }

            while(AR.AsyncState==null)
            {
                switch (Application.CanSelect)
                {
                    case true:
                        {
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            [DllImport("user32.dll")]
                            static extern void PostMessage(IntPtr hwnd, uint Msg, IntPtr Lparam, IntPtr wParam);
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            foreach (System.Diagnostics.Process x in Form1.ClientModules)
                            {
                                System.Reflection.Binder AttributeBinder = null;
                                List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<byte[], IntPtr> SendMesage = delegate (byte[] hwnd) { runtimeMethodHandle(); return x.MainWindowHandle; }; Console.WriteLine(SendMesage(new byte[] { })); PostMessage(x.MainWindowHandle, (uint)SendMesage(new byte[] { 0x11 }), IntPtr.Zero, x.MainWindowHandle); }) } };
                                object[] DataGram = { DisposedBuffer[0] };
                                foreach (var item in DataGram)
                                {
                                    object Hmessage = item;
                                    AttributeBinder.BindToMethod(System.Reflection.BindingFlags.CreateInstance, ((System.Reflection.MethodBase[])runtimeMethodHandle()), ref DataGram, new System.Reflection.ParameterModifier[] { parameterModifiers[0] }, System.Globalization.CultureInfo.CurrentCulture, new string[] { x.MainWindowTitle }, out Hmessage);
                                    x.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DisposedBuffer[0]);
                                    x.MainModule.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);
                                    x.MainWindowHandle.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);

                                }
                            }
                            break;
                        }

                    case false:
                        {
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            [DllImport("user32.dll")]
                            static extern void PostMessage(IntPtr hwnd, uint Msg, IntPtr Lparam, IntPtr wParam);
                            Application.DisconnectionHandler();
                            Application.CanSelect.Equals(true);
                            foreach (System.Diagnostics.Process x in Form1.ClientModules)
                            {
                                System.Reflection.Binder AttributeBinder = null;
                                List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<byte[], IntPtr> SendMesage = delegate (byte[] hwnd) { runtimeMethodHandle(); return x.MainWindowHandle; }; Console.WriteLine(SendMesage(new byte[] { })); PostMessage(x.MainWindowHandle, (uint)SendMesage(new byte[] { 0x11 }), IntPtr.Zero, x.MainWindowHandle); }) } };
                                object[] DataGram = { DisposedBuffer[0] };
                                foreach (var item in DataGram)
                                {
                                    object Hmessage = item;
                                    AttributeBinder.BindToMethod(System.Reflection.BindingFlags.CreateInstance, ((System.Reflection.MethodBase[])runtimeMethodHandle()), ref DataGram, new System.Reflection.ParameterModifier[] { parameterModifiers[0] }, System.Globalization.CultureInfo.CurrentCulture, new string[] { x.MainWindowTitle }, out Hmessage);
                                    x.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DisposedBuffer[0]);
                                    x.MainModule.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);
                                    x.MainWindowHandle.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, AttributeBinder, Hmessage, DataGram);

                                }
                            }
                            break;
                        }

                   
                }
            }
        }
       public static byte AcceptClient(Socket Client)
        {
            byte[] Buffer = new byte[Client.SendBufferSize * Client.ReceiveBufferSize];
            using (MemoryStream MS = new MemoryStream(Buffer))
            {
                Form1 Application = new Form1();
                Func<IntPtr, byte[]> recvBuffer = delegate (nint hwnd) { Application.DisconnectionHandler(); return new byte[Client.SendBufferSize]; };
                foreach (System.Diagnostics.Process x in Form1.ClientModules)
                {
                    Application.ConnectionCallback(Client.BeginReceive(recvBuffer(x.MainWindowHandle), 0, recvBuffer(x.MainWindowHandle).Length, SocketFlags.None, new AsyncCallback(ConnectionCallBack), new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { [DllImport("user32.dll")] static extern void keybd_event(byte BKey, byte Bscan, int dwFlags, int dwExtraInfo); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); keybd_event(0x01, 0, 0x0002, 0); })} }[0]));
                    return recvBuffer(x.MainWindowHandle)[0];
                }
              
            }
            return (new byte[] {(byte)(int) Client.Receive(new byte[] {AcceptClient(Client)})}[0]);
        }
        public static List<Microsoft.Web.WebView2.WinForms.WebView2> BrowserClients = new List<Microsoft.Web.WebView2.WinForms.WebView2>();
        public static UIntPtr BeginConnect()
        {
            Socket IcmpListener =new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IcmpListener.Bind(new IPEndPoint(IPAddress.Any, 443));
            WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.instagram.com");
            PostMethod.Method = "GET";
            PostMethod.Headers.Add("User-Agent", "");
            PostMethod.Headers.Add("Cookie", "");
            Stream OBJ = PostMethod.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(OBJ);
            while(SR.ReadToEnd().ToString()!=null)
            {
                List<Socket> Sockets = new List<Socket>();
                if (Sockets.Count >= 0)
                {
                    using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/logout"))
                    {

                        Microsoft.Web.WebView2.WinForms.WebView2 BrowserModule = new Microsoft.Web.WebView2.WinForms.WebView2();
                        BrowserModule.Source = new Uri("https://www.habbo.com/logout");
                        IcmpListener.Listen(1302);
                        Socket Accepted = IcmpListener.Accept();
                        if(Accepted.Handle!=IntPtr.Zero)
                        {
                            [DllImport("user32.dll")]
                            static extern bool PostMessage(IntPtr hwnd, uint Msg, IntPtr LpARAM, IntPtr WpARAM);
                            PostMessage(Accepted.Handle, AcceptClient(Accepted), IntPtr.Zero, IntPtr.Zero);
                            Sockets.Add(Accepted);
                            Console.WriteLine(Accepted.RemoteEndPoint.ToString());
                            PostMessage(ClientForm.ActiveWindow.MainWindowHandle, AcceptClient(Accepted), IntPtr.Zero, IntPtr.Zero);
                            return UIntPtr.Parse(Accepted.Handle.ToString());
                        }

                        if(Accepted.Handle==IntPtr.Zero)
                        {
                            BrowserModule.ExecuteScriptAsync("function PostMessage(){window.location='https://www.habbo.com.br';}setTimeout(()=>{PostMessage();},9130);");
                            BrowserClients.Add(BrowserModule);
                            foreach (var itemClient in BrowserClients)
                            {
                                var HttpClient = new HttpClient { BaseAddress = new Uri(itemClient.Source.ToString()) };
                               if(HttpClient.BaseAddress.ToString()=="https://www.habbo.com/br")
                                {
                                    HttpReqMsg.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(new List<string> { "user='Admin'", "password='pass'" }));
                                    var Filepath = "C://Users//"+Environment.UserName+"//Desktop"+"//Handles.txt";
                                    StreamWriter SW = new StreamWriter(Filepath);
                                    SW.WriteLine("<script>console.log('Start');</script>");
                                    SW.Close();
                                    SW.Dispose();
                                }

                                return UIntPtr.Parse(itemClient.Source.ToString());
                            }
                        }

                    }
                    Console.WriteLine(SR.ReadToEnd());
                }
            }

            return (new UIntPtr(0));
        }
    }
}