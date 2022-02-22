using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models
{
    public class Cuotapartista
    {
        public long Numero { get; set; }
        public string Nombre { get; set; }
        public string IdCuotapartista { get; set; }
        public string IdCoreBanco { get; set; }
        public string EMail { get; set; }
        public bool EsFisico { get; set; }
        public bool EstaAnulado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public bool RequiereFirmaConjunta { get; set; }
        public string NumCustodia { get; set; }

    }
}
