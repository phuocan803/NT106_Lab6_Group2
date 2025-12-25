using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;

namespace Client
{
    public partial class CLient : Form
    {
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        Thread receiveThread;
        bool isConnected = false;
        JavaScriptSerializer js = new JavaScriptSerializer();

        public CLient()
        {
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            try
            {
                if (client != null && client.Connected) return;
                
                if (client != null) client.Close();
                client = new TcpClient("127.0.0.1", 9999);
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream) { AutoFlush = true };
                isConnected = true;

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                isConnected = false;
                MessageBox.Show("Cannot connect to server (127.0.0.1:9999): " + ex.Message);
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            if (isConnected)
            {
                MessageBox.Show("Connected to server successfully!");
            }
        }

        private void ReceiveMessages()
        {
            while (isConnected)
            {
                try
                {
                    string message = reader.ReadLine();
                    if (message != null)
                    {
                        ProcessMessage(message);
                    }
                }
                catch
                {
                    isConnected = false;
                }
            }
        }

        private void ProcessMessage(string message)
        {
            try
            {
                // Try to parse as ResponsePacket
                dynamic response = js.DeserializeObject(message);
                
                if (response != null && response.ContainsKey("Type"))
                {
                    string type = response["Type"];
                    
                    if (type == "DATA_RESULT")
                    {
                        UpdateGrid(response["Data"]);
                        AddNotification(response["Message"]);
                    }
                    else if (type == "NOTIFICATION")
                    {
                        AddNotification(response["Message"]);
                    }
                    else if (type == "ERROR")
                    {
                        AddNotification($"❌ Lỗi: {response["Message"]}");
                    }
                }
                else
                {
                    AddNotification(message);
                }
            }
            catch
            {
                AddNotification(message);
            }
        }

        private void UpdateGrid(object dataObj)
        {
            try
            {
                List<StockData> stocks = new List<StockData>();
                
                if (dataObj is System.Collections.ArrayList dataList)
                {
                    foreach (var item in dataList)
                    {
                        if (item is System.Collections.Generic.Dictionary<string, object> dict)
                        {
                            stocks.Add(new StockData
                            {
                                StockCode = dict.ContainsKey("StockCode") ? dict["StockCode"]?.ToString() : "",
                                StockName = dict.ContainsKey("StockName") ? dict["StockName"]?.ToString() : "",
                                ClosePrice = dict.ContainsKey("ClosePrice") ? dict["ClosePrice"]?.ToString() : "",
                                Change = dict.ContainsKey("Change") ? dict["Change"]?.ToString() : "",
                                PerChange = dict.ContainsKey("PerChange") ? dict["PerChange"]?.ToString() : ""
                            });
                        }
                    }
                }
                
                if (this.DataGridView.InvokeRequired)
                {
                    this.DataGridView.Invoke(new Action(() => { BindGrid(stocks); }));
                }
                else
                {
                    BindGrid(stocks);
                }
            }
            catch (Exception e)
            {
                AddNotification("Error parsing data: " + e.Message);
            }
        }

        private void BindGrid(List<StockData> stocks)
        {
            DataGridView.Rows.Clear();
            foreach (var s in stocks)
            {
                DataGridView.Rows.Add(s.StockCode, s.StockName, s.ClosePrice, s.Change, s.PerChange);
            }
        }

        private void AddNotification(string msg)
        {
            if (this.ListBox_Mess.InvokeRequired)
            {
                this.ListBox_Mess.Invoke(new Action<string>(AddNotification), msg);
                return;
            }
            string time = DateTime.Now.ToString("HH:mm:ss");
            ListBox_Mess.Items.Add($"[{time}] {msg}");
        }

        private void SendRequest(string command)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected to server!");
                return;
            }

            int size = 0;
            int.TryParse(Tb_Size.Text, out size);

            Packet pkg = new Packet
            {
                Command = command,
                Payload = new PayloadData
                {
                    Size = size,
                    Date = DT_Date.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                    Email = Tb_Email.Text
                }
            };

            string json = js.Serialize(pkg);
            writer.WriteLine(json);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SendRequest("FETCH_DATA");
        }

        private void Btn_SendEmail_Click(object sender, EventArgs e)
        {
            SendRequest("SEND_EMAIL");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
