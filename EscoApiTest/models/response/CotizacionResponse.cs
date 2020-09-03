using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class CotizacionResponse {
        public string abreviatura { get; set; }
        public long plazo { get; set; }
        public string moneda { get; set; }
        public decimal? precioUltimo { get; set; }
    }



}