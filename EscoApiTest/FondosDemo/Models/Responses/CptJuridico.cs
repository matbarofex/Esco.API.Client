using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class CptJuridicoResponse : CptJuridicoBaseResponse
    {
        /// <summary>
        /// Lugar de Constitución
        /// </summary>
        public string lugarConstitucion { get; set; }
        /// <summary>
        /// Libro
        /// </summary>
        public string libro { get; set; }
        /// <summary>
        /// Numero de instrucción
        /// </summary>
        public string numInscripcion { get; set; }
        /// <summary>
        /// Tomo
        /// </summary>
        public string tomo { get; set; }
        /// <summary>
        /// Escritura
        /// </summary>
        public string escritura { get; set; }
        /// <summary>
        /// Folio
        /// </summary>
        public string folio { get; set; }
        /// <summary>
        /// Fecha de Constitución
        /// </summary>
        public DateTime? fechaConstitucion { get; set; }
        /// <summary>
        /// GIIN Identificador FACTCA
        /// </summary>
        public string GIIN { get; set; }
        /// <summary>
        /// Estado OCDE
        /// </summary>
        public ItemBaseResponse TipoEstadoOCDE { get; set; }
    }

    public class CptJuridicoBaseResponse
    {
        /// <summary>
        /// Status FATCA
        /// </summary>
        public ItemBaseResponse StatusFatca { get; set; }
        /// <summary>
        /// Es sujeto obligado
        /// </summary>
        public bool esSujetoObligado { get; set; }
        /// <summary>
        /// CUIT 
        /// </summary>
        public long CUIT { get; set; }
        /// <summary>
        /// Tipo de Contribuyente
        /// </summary>
        public ItemBaseResponse tipoContribuyente { get; set; }
    }

    public class CptJuridicoSQLResponse : CptJuridicoResponse
    {
        /// <summary>
        /// Numero de cuotapartista
        /// </summary>
        public long numero { get; set; }
    }
}
