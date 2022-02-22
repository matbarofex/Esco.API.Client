using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class CuotapartistaResponse
    {
        /// <summary>
        /// Datos comunes del cuotapartista
        /// </summary>
        public CuotapartistaDatosGenerales DatosGenerales { get; set; }
        /// <summary>
        /// Datos Juridicos del cuotapartista
        /// </summary>
        public CptJuridicoResponse DatosJuridicos { get; set; }
        /// <summary>
        /// Lista de titulares
        /// </summary>
        public List<PersonaBaseResponse> Titulares { get; set; }
        /// <summary>
        /// Lista de Cuentas Bancarias
        /// </summary>
        public List<CptCuentaBancariaResponse> CuentasBancarias { get; set; }
    }

    public class CuotapartistaDatosGenerales : CuotapartistaPorNumDocResponse
    {
        /// <summary>
        /// Numero de Custodia
        /// </summary>
        public string NumCustodia { get; set; }
    }

    public class CuotapartistaBaseResponse
    {
        /// <summary>
        /// Numero del cuotapartista
        /// </summary>
        public long Numero { get; set; }
        /// <summary>
        /// Nombre del cuotapartista
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Codigo de interfaz del cuotapartista
        /// </summary>
        public string IdCuotapartista { get; set; }
        /// <summary>
        /// Codigo único del cliente en sistema externo
        /// </summary>
        public string IdCoreBanco { get; set; }
    }

    public class CuotapartistaPorNumDocResponse : CuotapartistaBaseResponse
    {
        /// <summary>
        /// Email
        /// </summary>
        public string EMail { get; set; }
        /// <summary>
        /// Es fisico o no
        /// </summary>
        public bool EsFisico { get; set; }
        /// <summary>
        /// Esta anulado o no
        /// </summary>
        public bool EstaAnulado { get; set; }
        /// <summary>
        /// Fecha de Ingreso
        /// </summary>
        public DateTime? FechaIngreso { get; set; }
        /// <summary>
        /// Requiere firma conjunta o no
        /// </summary>
        public bool RequiereFirmaConjunta { get; set; }
    }
}
