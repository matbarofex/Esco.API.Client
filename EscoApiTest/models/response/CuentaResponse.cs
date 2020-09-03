using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class CuentaResponse {
        public string descripcion { get; set; }
        //public bool operaByMA { get; set; }
        //public bool operaROFEX { get; set; }
        public bool esFisico { get; set; }
        public long numeroCuenta { get; set; }
        //public long codComitente { get; set; }
        public string email { get; set; }
    }

}
