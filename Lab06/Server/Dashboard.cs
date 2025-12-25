using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Server
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isRunning = false;

        
        // LOG GIAO DIỆN
        private void Log(string message)
        {
            if (textBox_Log.InvokeRequired)
            {
                textBox_Log.Invoke(new Action(() => Log(message)));
                return;
            }
            textBox_Log.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
        }
        private async void button_Listen_Click(object sender, EventArgs e)
        {
            if (isRunning) return;
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();
                isRunning = true;
                Log("Server đang lắng nghe tại Port 8080...");

                while (isRunning)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                    Log($"Client mới kết nối: {clientIP}");
                    lbClients.Items.Add($"{clientIP} - {DateTime.Now:HH:mm:ss}");

                    _ = HandleClient(client); // Xử lý Multi-Thr
                }
            }
            catch (Exception ex) { Log("Lỗi Server: " + ex.Message); }
        }
        private async Task HandleClient(TcpClient client)
        {
            var stream = client.GetStream();
            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream) { AutoFlush = true };

            try
            {
                while (client.Connected)
                {
                    string requestJson = await reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(requestJson)) break;

                    var request = JsonConvert.DeserializeObject<RequestPacket>(requestJson);

                    if (request.Command == "FETCH_DATA")
                    {
                        Log("Đang tra cứu API Vietstock...");
                        var stockData = await FetchVietstock(request.Payload.Size, request.Payload.Date);

                        var response = new ResponsePacket
                        {
                            Status = "Success",
                            Type = "DATA_RESULT",
                            Message = "Lấy dữ liệu thành công",
                            Data = stockData,
                            Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        };
                        await writer.WriteLineAsync(JsonConvert.SerializeObject(response));
                    }
                    else if (request.Command == "SEND_EMAIL")
                    {
                        // Xử lý Email
                        var stockData = await FetchVietstock(request.Payload.Size, request.Payload.Date);
                        await ProcessEmailService(request.Payload.Email, stockData);
                    }
                }
            }
            catch { }
            finally
            {
                clients.Remove(client);
                client.Close();
            }
        }

        // LOGIC GỌI API VIETSTOCK 
        private async Task<JArray> FetchVietstock(int size, string date)
        {
            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("size", size.ToString()),
                    new KeyValuePair<string, string>("date", date)
                });
                var res = await http.PostAsync("https://finance.vietstock.vn/vi/data/getstdbestpagedata", content);
                var json = await res.Content.ReadAsStringAsync();
                return (JArray)JArray.Parse(json)[2]; // Lấy phần tử mảng thứ 3 theo đề bài
            }
        }

        // EMAIL & LƯU TRỮ 
        private async Task ProcessEmailService(string targetEmail, JArray data)
        {
            string fileName = $"Report_{DateTime.Now:yyyyMMdd}.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("StockCode | StockName | ClosePrice | Change");
            foreach (var item in data)
            {
                sb.AppendLine($"{item["StockCode"]} | {item["StockName"]} | {item["ClosePrice"]} | {item["Change"]}");
            }
            File.WriteAllText(fileName, sb.ToString());
            Log($"Đã lưu file: {fileName}");

            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress("your-email@gmail.com");
                    mail.To.Add(targetEmail);
                    mail.Subject = $"Báo cáo thị trường ngày {DateTime.Now:dd/MM/yyyy}";
                    mail.Body = "Gửi bạn báo cáo chứng khoán đính kèm.";
                    mail.Attachments.Add(new Attachment(fileName));

                    using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                        Log("Đã gửi Email thành công tới " + targetEmail);
                    }
                }
            }
            catch (Exception ex) { Log("Lỗi Email: " + ex.Message); }
        }

        // BROADCAST
        private async void button_Broadcast_Click(object sender, EventArgs e)
        {
            var packet = new ResponsePacket
            {
                Status = "Success",
                Type = "NOTIFICATION",
                Message = textBox_Notification.Text,
                Data = new JArray(),
                Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            string json = JsonConvert.SerializeObject(packet);
            foreach (var client in clients)
            {
                try
                {
                    var writer = new StreamWriter(client.GetStream()) { AutoFlush = true };
                    await writer.WriteLineAsync(json);
                }
                catch { /* Xử lý khi client mất kết nối */ }
            }
            Log("Đã Broadcast thông báo tới tất cả Client.");
            textBox_Notification.Clear();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            server?.Stop();
            foreach (var c in clients) c.Close();
            clients.Clear();
            Log("Server đã dừng.");
        }
    }
}
