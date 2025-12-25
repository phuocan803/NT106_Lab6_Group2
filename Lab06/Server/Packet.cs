using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class RequestPacket
    {
        public string Command { get; set; }
        public PayloadData Payload { get; set; }
    }
    public class PayloadData
    {
        public int Size { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }
    public class ResponsePacket
    {
        public string Status { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string Timestamp { get; set; }
    }
}
