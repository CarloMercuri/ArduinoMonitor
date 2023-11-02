using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    internal class TransferStartPacket
    {
        private string PacketType { get; set; }

        public TransferStartPacket()
        {
            PacketType = "_TSP";
        }

        public byte[] ToByteArray()
        {
            return Encoding.ASCII.GetBytes(PacketType);

        }
    }
}
