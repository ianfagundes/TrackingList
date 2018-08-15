using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrackingList.Model;

namespace TrackingList.ViewModel
{
    public class TrackerViewModel
    {
        public IList<TrackerModel> CardViewCollection { get; set; }
        public object SelectedItem { get; set; }
        public TrackerViewModel()
        {
            CardViewCollection = new List<TrackerModel>();
            GerarCardViewModel();
        }

        private void GerarCardViewModel()
        {
            CardViewCollection = new ObservableCollection<TrackerModel>() {
                new TrackerModel()
                {
                    ID = 1,
                    Fabricante = "Virtec",
                    Rastreador = "Virloc",
                    Entradas = "Digital",
                    QtdEntradas = 5,
                    Saidas = "Digital",
                    QtdSaidas = 2,
                    Telemetria = "RPM",
                    QtdTelemetria = 2,
                    Imagem = "virloc.png"


                },
                  new TrackerModel()
                {
                    ID = 1,
                    Fabricante = "MXT",
                    Rastreador = "MXT-160",
                    Entradas = "Digital",
                    QtdEntradas = 2,
                    Saidas = "Digital",
                    QtdSaidas = 2,
                    Telemetria = "Hodometro",
                    QtdTelemetria = 1,
                    Imagem = "virloc.png"
                },
                  new TrackerModel()
                {
                    ID = 1,
                    Fabricante = "MXT",
                    Rastreador = "MXT-160",
                    Entradas = "Digital",
                    QtdEntradas = 2,
                    Saidas = "Digital",
                    QtdSaidas = 2,
                    Telemetria = "Hodometro",
                    QtdTelemetria = 1,
                    Imagem = "virloc.png"
                },
                  new TrackerModel()
                {
                    ID = 1,
                    Fabricante = "MXT",
                    Rastreador = "MXT-160",
                    Entradas = "Digital",
                    QtdEntradas = 2,
                    Saidas = "Digital",
                    QtdSaidas = 2,
                    Telemetria = "Hodometro",
                    QtdTelemetria = 1,
                    Imagem = "virloc.png"
                },
                  new TrackerModel()
                {
                    ID = 1,
                    Fabricante = "MXT",
                    Rastreador = "MXT-160",
                    Entradas = "Digital",
                    QtdEntradas = 2,
                    Saidas = "Digital",
                    QtdSaidas = 2,
                    Telemetria = "Hodometro",
                    QtdTelemetria = 1,
                    Imagem = "virloc.png"
                },

            };
        }
    }
}


