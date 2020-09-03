using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.request {
    class ValuacionRequest {
        public string cuentas { get; set; }
        public DateTime Fecha { get; set; }
        public bool porConcertacion { get; set; }
        public bool esConsolidado { get; set; }
        public bool agruparPorMoneda { get; set; }
        public string monedaValuacion { get; set; }
    }
}
