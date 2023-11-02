using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    internal class TransferStopPacket
    {
        private string PacketType { get; set; }

        public TransferStopPacket()
        {
            PacketType = "_TST";
        }

        public byte[] ToByteArray()
        {
            return Encoding.ASCII.GetBytes(PacketType);

        }
    }
}
