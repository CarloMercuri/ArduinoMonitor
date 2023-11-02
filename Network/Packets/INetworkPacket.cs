using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    public interface INetworkPacket
    {
        byte[] ToByteArray();
    }
}
