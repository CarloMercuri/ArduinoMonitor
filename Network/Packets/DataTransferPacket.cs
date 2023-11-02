using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Packets
{
    internal class DataTransferPacket
    {
        private string PacketType { get; set; }
        private Dictionary<string, byte[]> Variables = new Dictionary<string, byte[]>();

        public DataTransferPacket(byte[] data)
        {
            PacketType = "_DTP";

            int variablesCount = data[4];

            int index = 5;

            for (int i = 0; i < variablesCount; i++)
            {
                int vNameLenght = data[index];
                index++;

                string varName = "";

                for (int j = 0; j < vNameLenght; j++)
                {
                    varName += data[index + j];
                    index++;
                }

                int varLength = data[index];
                index++;

                byte[] varData = new byte[varLength];

                for (int u = 0; u < varLength; u++)
                {
                    varData[u] = data[index];
                    index++;
                }

                Variables[varName] = varData;
            }

        }

        public byte[] ToByteArray()
        {
            return Encoding.ASCII.GetBytes(PacketType);

        }
    }
}
