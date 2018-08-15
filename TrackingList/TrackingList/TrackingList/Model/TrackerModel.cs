using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingList.Model
{
    public class TrackerModel
    {
        public int ID { get; set; }
        public string Rastreador { get; set; }
        public string Fabricante { get; set; }
        public string Entradas { get; set; }
        public int QtdEntradas { get; set; }
        public string Saidas { get; set; }
        public int QtdSaidas { get; set; }
        public string Telemetria { get; set; }
        public int QtdTelemetria { get; set; }
    }
}
