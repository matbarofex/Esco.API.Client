using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class MonedaResponse
    {
        public string simbolo { get; set; }
        public string idMoneda { get; set; }
        public string codISO { get; set; }
        public string idCAFCI { get; set; }
        public string descripcion { get; set; }
        public bool estaAnulado { get; set; }
    }

    public class MonedaBaseResponse
    {
        /// <summary>
        /// Descripcion de la moneda 
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Codigo de interfaz de moneda 
        /// </summary>
        public string idMoneda { get; set; }
        /// <summary>
        /// Indica si la moneda esta anulada
        /// </summary>
        public bool estaAnulado { get; set; }
    }

    public class MonedaBaseTablaSistemaResponse
    {
        public long codigo { get; set; }
        public string descripcion { get; set; }
        public string idMoneda { get; set; }
        public string simbolo { get; set; }
        public string ISO { get; set; }
        public string CAFCI { get; set; }
    }
}
