using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ArduinoMonitor.Network.DataHandler;
using ArduinoMonitor.Network.Interfaces;
using ArduinoMonitor.Network.Packets;

namespace ArduinoMonitor.Network.DataReceiver
{
    public class NetComm
    {
        //NEW
        private UdpClient _socket;

        private IPEndPoint _listenerEP { get; set; }

        private int _packetCount = 1;

        private int _listeningPort = 25000;

        private IPAddress _localAddress;
        private NetworkDataProcessor _processor;

        private static NetComm _instance = null;
        private static readonly object singletonLock = new object();

        public static NetComm Instance
        {
            get
            {
                lock (singletonLock)
                {
                    if (_instance == null)
                    {
                        _instance = new NetComm();
                    }
                    return _instance;
                }
            }
        }

        public void InitializeNetwork()
        {
            _processor = new NetworkDataProcessor();
            _processor.Initialize();

            _localAddress = IPAddress.Parse(GetLocalIPAddress());
            _listenerEP = new IPEndPoint(IPAddress.Any, _listeningPort);
            _socket = new UdpClient(_listeningPort);
            _socket.BeginReceive(new AsyncCallback(ReceiveCompletedCallback), null);

        }

        private void ReceiveCompletedCallback(IAsyncResult aResult)
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            byte[] data = _socket.EndReceive(aResult, ref remoteEP);
            _socket.BeginReceive(ReceiveCompletedCallback, null);

            // All valid packets have to contain a 4 byte header with the packet type
            if (data.Length < 4)
            {
                return;
            }

            // TODO: authorization?
            //if (!.IsEndpointAuthorized(remoteEP))
            //{
            //    return;
            //}

            // Forward the buffer directly
            _processor.ProcessRawData(data, remoteEP);




        }       

        /// <summary>
        /// Send a byte array to the specified endpoint
        /// </summary>
        /// <param name="data"></param>
        /// <param name="remoteEP"></param>
        public void SendByteArray(byte[] data, IPEndPoint remoteEP)
        {
            _socket.SendAsync(data, data.Length, remoteEP);
        }

        public void ScoutNetworkDevices()
        {
            ScoutPacket packet = new ScoutPacket();

            SendByteArray(packet.ToByteArray(), new IPEndPoint(
              IPAddress.Broadcast, 25000
              ));

        }


        /// <summary>
        /// Returns the local IP address of the machine
        /// </summary>
        /// <returns></returns>
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

    }

}
