using Desktop.Robot;
using Desktop.Robot.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        public bool showWindow(IntPtr hwnd, byte[] Message)
        {
            Func<IntPtr, byte[]> refPostMessae = delegate (IntPtr hwnd) { this.CanSelect.Equals(true); this.SelectNextControl(this, false, false, true, false); this.SelectNextControl(this, false, false, false, false); this.SelectNextControl(this, false, false, false, true); this.SelectNextControl(this, false, false, true, true); this.SelectNextControl(this, false, true, true, true); this.SelectNextControl(this, true, true, true, false); this.SelectNextControl(this, true, true, false, false); this.SelectNextControl(this, true, true, true, false); return Message; };
            Message.Equals(refPostMessae(hwnd));
            Message = refPostMessae(this.Handle);
            showWindow(this.Cursor.Handle, refPostMessae(this.Handle));
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
            const int SW_HIDE = 9;
            ShowWindow(this.Cursor.Handle, SW_HIDE);

            return false;

        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2301;
            timer1.Start();
        }
        public List<Form1.ModuleContainer> ClientForms = new List<Form1.ModuleContainer>();
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public List<byte[]> MessageHandler = new List<byte[]>();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Process[] Client = System.Diagnostics.Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                    foreach (var items in Client)
                    {
                        richTextBox2.Text += items.MainWindowTitle;
                        richTextBox2.Text += Form1.ClientModules[0].MainWindowTitle.Substring(0, 5);
                        OFD.FileName = "C://Users//" + Environment.UserName + "//Desktop//API//Public//Downloads";
                        textBox2.Text = OFD.FileName;
                        WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                        PostMethod.Method = "POST";
                        PostMethod.BeginGetRequestStream(new AsyncCallback((sender) => { [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hwnd, int nCmdShow); Func<IntPtr, byte[]> PostMessage = delegate (nint hwnd) { const int SW_HIDE = 9; ShowWindow(Form1.ClientModules[0].Handle, SW_HIDE); [DllImport("user32.dll", SetLastError = true)] static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent); SetParent(webView21.Handle, Form1.ClientModules[0].Handle); return new byte[] { (byte)Form1.ClientModules[0].MainWindowHandle }; }; PostMessage(IntPtr.Zero); }), sender);
                        WebClient wc = new WebClient();
                        wc.BaseAddress = new Uri("https://www.proxyium.com").ToString();
                        webView22.Source = new Uri(wc.BaseAddress.ToString());
                        using (var GetespStream = wc.OpenWrite("https://69.172.200.161", "POST"))
                        {
                            const string PostMsg = "var elem = document.getElementsByClassName('form-control'); elem[0].src='https://www.habbo';elem[0].value='https://www.habbo'\" + comboBox1.SelectedItem.ToString() + \"; let event = new MouseEvent(\\\"click\\\",{bubbles:true,view:window,cancelable:true}); var submitBtn= document.getElementById('unique-btn-blue');submitBtn.dispatchEvent(event)";
                            richTextBox1.Text += Newtonsoft.Json.JsonConvert.SerializeObject(Convert.ToBase64String(Encoding.UTF8.GetBytes(PostMsg)));
                            StreamWriter SW = new StreamWriter(GetespStream, new StreamReader(OFD.FileName + "//Index.php").CurrentEncoding);
                            SW.WriteLine("Accept", "text/html");
                            SW.Write("HTTP /1.1 200 OK\r");
                            SW.WriteLine("<html> <script> window.location='https://www.habbo.com'const int index= window.location.toString().length; for(var x=value;x>0;x--){var xhr=new XMLHttpRequest();xhr.open('POST','https://www.habbo.com');xhr.send(window.location); console.log('Disconnection');}</script> </html>");
                            byte[] Buffer = Encoding.Default.GetBytes(webView22.ExecuteScriptAsync("var elem = document.getElementsByClassName('form-control'); elem[0].src='https://www.habbo';elem[0].value='https://www.habbo'" + comboBox1.SelectedItem.ToString() + "; let event = new MouseEvent(\"click\",{bubbles:true,view:window,cancelable:true}); var submitBtn= document.getElementById('unique-btn-blue');submitBtn.dispatchEvent(event);").ToString().ToString());
                            GetespStream.Write(Buffer, 0, Buffer.Length);
                            SW.Close();
                            SW.Dispose();
                        }

                    }

                }
                catch (SocketException sockEx)
                {
                    MessageBox.Show("Disconnection" + sockEx.Message.ToString());
                    HttpClient hclient = new HttpClient();
                    hclient.BaseAddress = new Uri("https://www.habbo" + comboBox1.SelectedItem.ToString());
                    using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.proxyium.com/requests.php"))
                    {
                        MessageBox.Show("Test");
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            SetParent(Process.GetProcessById(int.Parse(textBox3.Text.ToString())).MainWindowHandle, panel2.Handle);
        }

        public UIntPtr GetWindow(ushort header)
        {
            foreach (ClientForm c in Form1.FormClients)
            {
                c.CanSelect.Equals(true);
                switch (c.CanSelect)
                {
                    default:
                        {
                            if (c.Handle.Equals(this.Handle))
                            {
                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                Process[] Clients = Process.GetProcesses();
                                List<Process> Disposed = new List<Process>();
                                foreach (System.Diagnostics.Process x in Disposed)
                                {

                                    if (!x.ProcessName.Contains("Habbo"))
                                    {
                                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { (byte)x.Handle })))
                                        {
                                            BW.Write(new byte[] { (byte)header });

                                        }


                                    }

                                    if (x.ProcessName.Contains("Habbo"))
                                    {
                                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SendMessage")]
                                        static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int LpARAM, int WParam);
                                        SendMessage(x.MainWindowHandle, new byte[] { (byte)header }[0], 0, 0);
                                        this.BeginInvoke(new Action(() => { Func<byte[], System.Windows.Forms.Keys> PostMessage = delegate (byte[] Buffer) { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return System.Windows.Forms.Keys.Control; }; Console.WriteLine(new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Disposed.Add(x); new KeyEventArgs(PostMessage(new byte[] { 0x11, 0, 0x0000, 0x11, 0, 0x0002 })); }) } }[0]); }));
                                    }
                                }
                                this.SelectNextControl(c, false, false, true, false);

                            }
                            if (!c.Handle.Equals(this.Handle))
                            {
                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                Process[] Clients = Process.GetProcesses();
                                List<Process> Disposed = new List<Process>();
                                foreach (System.Diagnostics.Process x in Disposed)
                                {

                                    if (!x.ProcessName.Contains("Habbo"))
                                    {
                                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { (byte)x.Handle })))
                                        {
                                            BW.Write(new byte[] { (byte)header });

                                        }


                                    }

                                    if (x.ProcessName.Contains("Habbo"))
                                    {
                                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SendMessage")]
                                        static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int LpARAM, int WParam);
                                        SendMessage(x.MainWindowHandle, new byte[] { (byte)header }[0], 0, 0);
                                        this.BeginInvoke(new Action(() => { Func<byte[], System.Windows.Forms.Keys> PostMessage = delegate (byte[] Buffer) { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return System.Windows.Forms.Keys.Control; }; Console.WriteLine(new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Disposed.Add(x); new KeyEventArgs(PostMessage(new byte[] { 0x11, 0, 0x0000, 0x11, 0, 0x0002 })); }) } }[0]); }));
                                    }
                                }
                                this.SelectNextControl(c, false, false, true, false);
                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                this.SelectNextControl(c, false, false, true, false);

                            }
                            if (this.Handle.Equals(c.Handle))
                            {

                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                Process[] Clients = Process.GetProcesses();
                                List<Process> Disposed = new List<Process>();
                                foreach (System.Diagnostics.Process x in Disposed)
                                {

                                    if (!x.ProcessName.Contains("Habbo"))
                                    {
                                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { (byte)x.Handle })))
                                        {
                                            BW.Write(new byte[] { (byte)header });

                                        }


                                    }

                                    if (x.ProcessName.Contains("Habbo"))
                                    {
                                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SendMessage")]
                                        static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int LpARAM, int WParam);
                                        SendMessage(x.MainWindowHandle, new byte[] { (byte)header }[0], 0, 0);
                                        this.BeginInvoke(new Action(() => { Func<byte[], System.Windows.Forms.Keys> PostMessage = delegate (byte[] Buffer) { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return System.Windows.Forms.Keys.Control; }; Console.WriteLine(new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Disposed.Add(x); new KeyEventArgs(PostMessage(new byte[] { 0x11, 0, 0x0000, 0x11, 0, 0x0002 })); }) } }[0]); }));
                                    }
                                }
                                this.SelectNextControl(c, false, false, true, false);
                                this.SelectNextControl(c, false, false, true, false);
                            }
                            if (!this.Handle.Equals(c.Handle))
                            {
                                c.CanSelect.Equals(true);
                                c.CanSelect.Equals(true);
                                c.SelectNextControl(this, false, true, true, false);
                                Process[] Clients = Process.GetProcesses();
                                List<Process> Disposed = new List<Process>();
                                foreach (System.Diagnostics.Process x in Disposed)
                                {

                                    if (!x.ProcessName.Contains("Habbo"))
                                    {
                                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { (byte)x.Handle })))
                                        {
                                            BW.Write(new byte[] { (byte)header });

                                        }


                                    }

                                    if (x.ProcessName.Contains("Habbo"))
                                    {
                                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SendMessage")]
                                        static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int LpARAM, int WParam);
                                        SendMessage(x.MainWindowHandle, new byte[] { (byte)header }[0], 0, 0);
                                        this.BeginInvoke(new Action(() => { Func<byte[], System.Windows.Forms.Keys> PostMessage = delegate (byte[] Buffer) { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0002, 0); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return System.Windows.Forms.Keys.Control; }; Console.WriteLine(new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Disposed.Add(x); new KeyEventArgs(PostMessage(new byte[] { 0x11, 0, 0x0000, 0x11, 0, 0x0002 })); }) } }[0]); }));
                                    }
                                }
                                this.SelectNextControl(c, false, false, true, false);
                                c.SelectNextControl(this, false, true, true, false);
                                this.SelectNextControl(c, false, false, true, false);
                            }
                            break;
                        }
                }
                return UIntPtr.Parse(c.Handle.ToString());
            }
            return UIntPtr.Parse(Process.GetCurrentProcess().MainWindowTitle);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetWindow(0x11);
            GetWindow(0x56);
            GetWindow(0x0D);
            GetWindow(0x5A);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
