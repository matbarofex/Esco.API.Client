using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class OrdenesResponse {
        public long codComitente { get; set; }
        public long codOrden { get; set; }
        public long codInstrumentoOrd { get; set; }
        public string comitente { get; set; }
        public string tpOperacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string instrumentoAbrev { get; set; }
        public string instrumentoDesc { get; set; }
        public string tpVencimientoOrden { get; set; }
        public DateTime FVencimiento { get; set; }
        public decimal cantidad { get; set; }
        public decimal importe { get; set; }
        public decimal importeNeto { get; set; }
        public decimal precioTasa { get; set; }
        public long numOrden { get; set; }
        public string estado { get; set; }
        public decimal? cantidadEjecutada { get; set; }
        public decimal? ppp { get; set; }
        public decimal? importeBrutoEjec { get; set; }
        public decimal? cantidadPendiente { get; set; }
        public int codTpEstadoOrden { get; set; }
        public int codTpSubEstadoOrden  { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string moneda { get; set; }
        public int plazo { get; set; }
    }



}