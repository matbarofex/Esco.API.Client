using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.request {
    class CotizacionesRequest {
        public string instrumento { get; set; }
        public bool exactMatch { get; set; }
    }
}
