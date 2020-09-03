using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.request {
    class InsertOrdenRequest {
        public string instrumentoAbreviatura { get; set; }
        public decimal? cantidad { get; set; }
        public decimal? precio { get; set; }
        public decimal? importe { get; set; }
        public long cuenta { get; set; }
        public string moneda { get; set; }
        public DateTime FechaConcertacion { get; set; }
        public int plazo { get; set; }
        public string aplicacion { get; set; }
        public bool incluyeGastosEnImporte { get; set; }
        public decimal variacionPrecio { get; set; }
        public string mercado { get; set; }
        public bool controlaPerfilInversor { get; set; }
        public bool controlaSubyacente { get; set; }
        public bool rutearOrdenAlMercado { get; set; }
        public bool validarOrden { get; set; }
        public bool ordenMarket { get; set; }
    }
} 
