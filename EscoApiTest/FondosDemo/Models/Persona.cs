using EscoApiTest.FondosDemo.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models
{
    public class Persona
    {
        public string IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string CUIL { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
    }
}
