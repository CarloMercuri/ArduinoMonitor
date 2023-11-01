using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Network.Models
{
    public class ArduinoUpdateEventModel
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int xAxis { get; set; }
        public int yAxis { get; set; }

    }
}
