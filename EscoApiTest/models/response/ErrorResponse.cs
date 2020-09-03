using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class ErrorResponse {
        public ErrorLogin error { get; set; }
    }

    public class ErrorLogin {
        public string CodError { get; set; }
        public string Msj { get; set; }

    }
}
