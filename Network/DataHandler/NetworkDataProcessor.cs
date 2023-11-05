using ArduinoMonitor.Network.DataReceiver;
using ArduinoMonitor.Network.Interfaces;
using ArduinoMonitor.Network.Models;
using ArduinoMonitor.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.DataHandler
{
    public class NetworkDataProcessor
    {
        public static event EventHandler<ArduinoUpdateEventModel> ArduinoUpdateEvent;
        private NetComm _netComm;
        private IPEndPoint targetEndpoint;
        
        public void Initialize()
        {
            _netComm = NetComm.Instance;
            //Task t1 = Task.Factory.StartNew(() => { this.FakeArduinoInputs(); });
        }

        private void FakeArduinoInputs()
        {
            int count = 0;
            ArduinoUpdateEventModel model = new ArduinoUpdateEventModel();
            model.Temperature = 10;
            model.Humidity = 10;

            while (true)
            {
                if(count > 5)
                {
                    count = 0;

                    model.Temperature += 2;
                    if(model.Temperature > 70)
                    {
                        model.Temperature = -30;
                    }

                    model.Humidity += 2;
                    if (model.Humidity > 90)
                    {
                        model.Humidity = 0;
                    }
                    ArduinoUpdateEvent?.Invoke(null, model);
                }

                count++;
                Thread.Sleep(50);
            }
        }

        public void ScoutNetwork()
        {
            _netComm.ScoutNetworkDevices();
        }

        public void ProcessRawData(byte[] data, IPEndPoint endPoint)
        {
            // Grab the first 4 bytes, which are the packet type
            string pType = Encoding.Default.GetString(data.Take(4).ToArray());

            switch (pType)
            {
                case "_UPD":
                    ArduinoUpdateEventModel updateData = ExtractUpdateData(data);
                    ArduinoUpdateEvent?.Invoke(null, updateData);
                    break;

                case "_SRP":
                    targetEndpoint = endPoint;
                    TransferStartPacket packet = new TransferStartPacket();
                    _netComm.SendByteArray(packet.ToByteArray(), new IPEndPoint(
                      targetEndpoint.Address, 25000
                      ));
                    break;

                case "_DTP":
                    ReadDataPacket(data);
                    break;
            }
        }

        private void ReadDataPacket(byte[] data)
        {
            PacketsReader _reader = new PacketsReader();
            ArduinoUpdateEventModel updateEventModel = new ArduinoUpdateEventModel();

            int index = 4; // we start after the signature

            int number_of_variables = data[index];
            index++;

            for (int i = 0; i < number_of_variables; i++)
            {
                int varNameLength = data[index];
                index++;

                string varName = _reader.ReadString(data, ref index, varNameLength).ToLower();
                int varType = data[index];
                index++;

                switch (varName)
                {
                    case "temperature":
                        updateEventModel.Temperature = _reader.ReadShort(data, ref index);
                        break;
                    case "humidity":
                        updateEventModel.Humidity = _reader.ReadShort(data, ref index);
                        break;
                    case "xaxis":
                        updateEventModel.xAxis = _reader.ReadShort(data, ref index);
                        break;
                    case "yaxis":
                        updateEventModel.yAxis = _reader.ReadShort(data, ref index);
                        break;
                }
            }

            ArduinoUpdateEvent?.Invoke(null, updateEventModel);
        }

        private ArduinoUpdateEventModel ExtractUpdateData(byte[] data)
        {
            return null;
        }
    }
}
