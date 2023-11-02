using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    public class ScoutPacket : INetworkPacket
    {

        private string PacketType { get; set; }

        public ScoutPacket()
        {
            PacketType = "_SCT";
        }

        public byte[] ToByteArray()
        {
            return Encoding.ASCII.GetBytes(PacketType);

        }
    }
}
