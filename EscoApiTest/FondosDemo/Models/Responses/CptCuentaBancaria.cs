using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
   public class CptCuentaBancariaResponse : CptCuentaBancariaBaseResponse
    {
        public MonedaResponse moneda { get; set; }
        public ItemBaseResponse tipoCuentaBancaria { get; set; }
        public string cuitTitular { get; set; }
        public ItemBaseResponse banco { get; set; }
        public long numSucursal { get; set; }
        public DateTime? fechaApertura { get; set; }
        public string alias { get; set; }
        public string ABA { get; set; }
        public string swift { get; set; }
        public string IBAN { get; set; }
    }

    public class CptCuentaBancariaBaseResponse
    {
        public string descripcion { get; set; }
        public string numeroCuenta { get; set; }
        public string CBU { get; set; }
        public string idCptCuentaBancaria { get; set; }
        public bool estaAnulado { get; set; }
    }

    public class CptCuentaBancariaSQLResponse : CptCuentaBancariaResponse
    {
        public long numCuotapartista { get; set; }
    }
}
