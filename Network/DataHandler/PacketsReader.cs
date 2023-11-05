using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.DataHandler
{
    public class PacketsReader
    {
        public short ReadShort(byte[] data, ref int index)
        {
            short value = BitConverter.ToInt16(data, index);
            index += 2;
            return value;
        }

        public string ReadString(byte[] data, ref int index, int length)
        {
            string value = Encoding.ASCII.GetString(data, index, length);
            index += length;
            //string value = "";
            //for (int i = 0; i < length; i++)
            //{
            //    value += (char)data[index + i];
            //    index++;
            //}

            return value;
        }
    }
}
