using ArduinoMonitor.Network.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Interfaces
{
    public interface INetworkDataProcessor
    {
        event EventHandler<ArduinoUpdateEventModel> ArduinoUpdateEvent;
    }
}
