using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    public class ScoutResponsePacket
    {
        private string PacketType { get; set; }
        private string _deviceName;

        public string DeviceName
        {
            get { return _deviceName; }
        }

        public ScoutResponsePacket(byte[] data)
        {
            PacketType = "_SRP";

            // minimum 4 bytes for the type, 1 byte for the length of the device name
            // and 1 byte (at minimum) for the device name
            if (data.Length < 6) 
            {
                _deviceName = "PACKET ERROR";
            } else
            {
                byte nameLenght = data[4];
                string name = "";

                for (int i = 0; i < nameLenght; i++)
                {
                    name += (char)data[i + 5];
                }

                _deviceName = name;
            }

        }

        public byte[] ToByteArray()
        {
            return Encoding.ASCII.GetBytes(PacketType);

        }
    }
}
