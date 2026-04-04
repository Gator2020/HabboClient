using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace App
{
   
    public class HConnection
    {
        public Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public HConnection(Apphost.Form1 Connection)
        {
            int ProcessModule = Process.GetCurrentProcess().Id;
            Console.WriteLine(ProcessModule);
            byte[] hBuffer = new byte[ProcessModule];
            var FileData = File.ReadAllText("C://Users//Desktop//Admin//Index.php".Replace("Admin", Environment.UserName));
            try
            {
                if(!FileData.Contains(Process.GetCurrentProcess().Id.ToString()))
                {
                    MessageBox.Show("lIstening on port 443...." + DateTime.Now.ToLongDateString() + Process.GetCurrentProcess().Id.ToString() + ":?=PID");
                    var httpClient = new HttpClient();
                    Connection.SendMessage(Process.GetCurrentProcess().MainWindowHandle);
                    Server = Apphost.Form1.ServerGameSocket;
                    Client = Apphost.Form1.AcceptedSocketHandler;
                    httpClient.BaseAddress = new Uri("https://69.172.200.161/public/api");
                    Connection.ICMPListener();
                    using (var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/api/public/authentication/loginv2"))
                    {
                        var GetAsync = httpClient.GetAsync("https://www.habbo.com/logout/");
                        const char BeginRead = '"';
                        const char EndRead = '"';
                        Console.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//Index.php");
                        SW.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        var HControl = new Apphost.Form1();
                        MessageBox.Show("Disconnection" + HControl.Handle);
                        List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<HConnection, Apphost.Form1> PostMessage = delegate (HConnection Client) { SW.Close(); SW.Dispose(); return HControl; }; HConnection ClientSocket = new HConnection(PostMessage(new HConnection(HControl))); }) } };
                        WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                        PostMethod.Method = "GET";
                        WebClient wc = new WebClient();
                        wc.Headers.Add("browser_token", "s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod = (HttpWebRequest)WebRequest.CreateHttp("https://www.habbo.com/api/public");
                        PostMethod.Method = "POST";
                        PostMethod.Headers.Add("Cookie", "browser_token=s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod.Headers.Add("Cache-Control", "no-cache");
                        PostMethod.Headers.Add("dis-remote-addr", "107.207.178.195");
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
                        byte[] WebBuffer = File.ReadAllBytes(FilepathData);
                        PostAsync.Write(WebBuffer, 0, WebBuffer.Length);



                    }

                }
                if(FileData.Contains(Process.GetCurrentProcess().Id.ToString()))
                {
                    var httpClient = new HttpClient();
                    Client = Apphost.Form1.ClientSocket;
                    Server = Apphost.Form1.AcceptedSocketHandler;
                 
                    httpClient.BaseAddress = new Uri("https://69.172.200.161/public/api");
                    using (var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/api/public/authentication/loginv2"))
                    {
                        var GetAsync = httpClient.GetAsync("https://www.habbo.com/logout/");
                        const char BeginRead = '"';
                        const char EndRead = '"';
                        Console.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//Index.php");
                        SW.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        var HControl = new Apphost.Form1();
                        //MessageBox.Show("Disconnection" + HControl.Handle);
                        List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<HConnection, Apphost.Form1> PostMessage = delegate (HConnection Client) { SW.Close(); SW.Dispose(); return HControl; }; HConnection ClientSocket = new HConnection(PostMessage(new HConnection(HControl))); }) } };
                        WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                        PostMethod.Method = "GET";
                        WebClient wc = new WebClient();
                        wc.Headers.Add("browser_token", "s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod = (HttpWebRequest)WebRequest.CreateHttp("https://www.habbo.com/api/public");
                        PostMethod.Method = "POST";
                        PostMethod.Headers.Add("Cookie", "browser_token=s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod.Headers.Add("Cache-Control", "no-cache");
                        PostMethod.Headers.Add("dis-remote-addr", "107.207.178.195");
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
                        byte[] WebBuffer = File.ReadAllBytes(FilepathData);
                        PostAsync.Write(WebBuffer, 0, WebBuffer.Length);



                    }
                }
            }
            catch(SocketException sockEx)
            {
                MessageBox.Show("An exception was Thrown:" + sockEx.Message.ToString());
                if (sockEx.Message.ToString().Length>=0)
                {
                    var httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri("https://69.172.200.161/public/api");
                    using(var httpReqMsg=new HttpRequestMessage(HttpMethod.Post,"https://www.habbo.com/api/public/authentication/loginv2"))
                    {
                        var GetAsync = httpClient.GetAsync("https://www.habbo.com/logout/");
                        const char BeginRead = '"';
                        const char EndRead = '"';
                        Console.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        StreamWriter SW = new StreamWriter("C://Users//"+Environment.UserName+"//Desktop//Index.php");
                        SW.WriteLine("echo" + BeginRead + GetAsync.Result.ToString() + EndRead + ";" + "echo" + BeginRead + Process.GetCurrentProcess().Id + EndRead + ";");
                        var HControl = new Apphost.Form1();
                         MessageBox.Show("Disconnection"+HControl.Handle);
                        List<object[]> DisposedBuffer = new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Func<HConnection, Apphost.Form1> PostMessage = delegate (HConnection Client) { SW.Close();SW.Dispose(); return HControl;   }; HConnection ClientSocket = new HConnection(PostMessage(new HConnection(HControl))); }) } };
                        WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                        PostMethod.Method = "GET";
                        WebClient wc = new WebClient();
                        wc.Headers.Add("browser_token", "s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod = (HttpWebRequest)WebRequest.CreateHttp("https://www.habbo.com/api/public");
                        PostMethod.Method = "POST";
                        PostMethod.Headers.Add("Cookie", "browser_token=s%3A-uiwB5ZGiefywGPXhCKXB8eIcYZWBfUNymSGWUIvOYs.idueYGIA1MT4IGArZ%2BVL7scNq7LW4lcRTAzHzrgk%2B3s; Path=/; HttpOnly; Expires=Mon, 31 Mar 2036 15:53:17 GMT;");
                        PostMethod.Headers.Add("Cache-Control", "no-cache");
                        PostMethod.Headers.Add("dis-remote-addr", "107.207.178.195");
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
                        byte[] WebBuffer = File.ReadAllBytes(FilepathData);
                        PostAsync.Write(WebBuffer, 0, WebBuffer.Length);



                    }
                 }
            }

        }
    }
}
