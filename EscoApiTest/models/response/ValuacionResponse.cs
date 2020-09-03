using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EscoApiTest.models.response {
    public class ValuacionResponse {
        //public long codigoCV { get; set; }
        public string abreviatura { get; set; }
        public decimal cantidad { get; set; }
        public decimal cantidadD { get; set; }
        public decimal cantidadND { get; set; }
        public long cuenta { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public string moneda { get; set; }
        public string monedaSimboloInstrumentto { get; set; }
        //public decimal pppCompra { get; set; }
        //public decimal cantAccionesLt { get; set; }
        public decimal precio { get; set; }
        public decimal precioEmi { get; set; }
        public string tpActivo { get; set; }
        //public string tpInstrumento { get; set; }
        public decimal valuacion { get; set; }
        public decimal valuacionEmision { get; set; }
        public string valuacionSimboloMoneda { get; set; }
        //public string grupo { get; set; }
        //public string idInstrumentto { get; set; }
        //public string idTpActivvo { get; set; }
        public string isin { get; set; }
        public string codInterfazBloomberg { get; set; }
        public string iso { get; set; }


    }
}