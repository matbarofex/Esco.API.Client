using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models.Responses
{
    public class PersonaResponse : PersonaBaseResponse
    {
        /// <summary>
        /// Fecha de Nacimiento 
        /// </summary>
        public DateTime? fechaNacimiento { get; set; }
        /// <summary>
        /// Es masculino
        /// </summary>
        public bool esMasculino { get; set; }
        /// <summary>
        /// Es PEP
        /// </summary>
        public bool esPEP { get; set; }
        /// <summary>
        /// Es sujeto obligado
        /// </summary>
        public bool esSujetoObligado { get; set; }
        /// <summary>
        /// Calle 
        /// </summary>
        public string calle { get; set; }
        /// <summary>
        /// Altura 
        /// </summary>
        public string altura { get; set; }
        /// <summary>
        /// Piso 
        /// </summary>
        public string piso { get; set; }
        /// <summary>
        /// Departamento 
        /// </summary>
        public string departamento { get; set; }
        /// <summary>
        /// Codigo Postal 
        /// </summary>
        public string codigoPostal { get; set; }
        /// <summary>
        /// Localidad 
        /// </summary>
        public string localidad { get; set; }
        /// <summary>
        /// Telefono 
        /// </summary>
        public string telefono { get; set; }
        /// <summary>
        /// Pais
        /// </summary>
        public ItemBaseResponse pais { get; set; }
        /// <summary>
        /// Provincia
        /// </summary>
        public ItemBaseResponse provincia { get; set; }
        /// <summary>
        /// Email 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Codigo de Interfaz Adicional
        /// </summary>
        public string idPersonaAdicional { get; set; }
        /// <summary>
        /// Importe Patrimonio Neto
        /// </summary>
        public decimal importePatrimonioNeto { get; set; }
        /// <summary>
        /// Pais de la Nacionalidad
        /// </summary>
        public ItemBaseResponse paisNacionalidad { get; set; }
        /// <summary>
        /// Estado Civil
        /// </summary>
        public ItemBaseResponse estadoCivil { get; set; }
        /// <summary>
        /// Actividad
        /// </summary>
        public ItemBaseResponse actividad { get; set; }
        /// <summary>
        /// Tipo de Contribuyente
        /// </summary>
        public ItemBaseResponse tipoContribuyente { get; set; }
    }

    public class PersonaBaseResponse
    {
        /// <summary>
        /// Tipo de Documento de Identidad
        /// </summary>
        public TipoDocumentoIdentidadBaseResponses tipoDocumentoIdentidad { get; set; }
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public string apellido { get; set; }
        /// <summary>
        /// Codigo de interfaz de la persona
        /// </summary>
        public string idPersona { get; set; }
        /// <summary>
        /// Numero de documento
        /// </summary>
        public long numDocumento { get; set; }
        /// <summary>
        /// CUIT 
        /// </summary>
        public long CUIT { get; set; }
        /// <summary>
        /// CUIL 
        /// </summary>
        public long CUIL { get; set; }
        /// <summary>
        /// CDI 
        /// </summary>
        public long CDI { get; set; }
        /// <summary>
        /// Anulada
        /// </summary>
        public bool estaAnulado { get; set; }
    }
}
