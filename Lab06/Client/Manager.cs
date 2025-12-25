using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Manager
    {
        private TcpClient dataClient;
        private StreamReader dataReader;
        private StreamWriter dataWriter;
    }
}
