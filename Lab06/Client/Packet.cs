using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class PayloadData
    {
        public int Size { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }

    public class Packet
    {
        public string Command { get; set; }
        public PayloadData Payload { get; set; }
    }

    public class StockData
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string ClosePrice { get; set; }
        public string Change { get; set; }
        public string PerChange { get; set; }
    }
}
