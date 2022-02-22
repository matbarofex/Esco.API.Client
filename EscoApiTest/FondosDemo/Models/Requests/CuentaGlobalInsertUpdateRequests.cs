using System;
using System.Collections.Generic;

namespace EscoApiTest.FondosDemo.Models.Requests
{
    #region Completos
    public class CuotapartistaPersonaInsertUpdateRequest {
        public string IdCuotapartista { get; set; }
        public string Nombre { get; set; }
        public string IdAgenteColocador { get; set; }
        public string IdSucursal { get; set; }
        public string IdOficialCuenta { get; set; }
        public bool EsPersonaFisica { get; set; }
        public bool RequiereFirmaConjunta { get; set; } = true;
        public string IdTipoInversor { get; set; }
        public string IdCanalVenta { get; set; }
        public string IdCuotapartistaAdicional { get; set; }
        public CptJuridicoBaseConMontoPatrimonioRequest Juridicos { get; set; }
        public CuotapartistaUIFInsertRequest DatosUIF { get; set; }
        public List<PersonaInsertRequest> Personas { get; set; }
        public List<CptCuentaBancariaBaseConNumSucursalRequest> CuentasBancarias { get; set; }
    }

    public class CptJuridicoBaseConMontoPatrimonioRequest : CptJuridicoBaseRequest
    {
        public decimal? MontoPatrimonio { get; set; }
    }

    public class CptJuridicoBaseRequest
    {
        public string IdStatusFatca { get; set; }
        public bool EsSujetoObligado { get; set; }
        public long CUIT { get; set; }
        public string IdTipoContribuyente { get; set; }
    }

    public class CuotapartistaUIFInsertRequest
    {

        public CuotapartistaUIFInsertRequest() { }
        public decimal? ImporteActividadEsperadaCuenta { get; set; }
        public decimal? ImporteMaximoPorSolicitud { get; set; }
        public decimal? ImporteEstimadoOperaciones { get; set; }
    }

    public class PersonaInsertRequest : PersonaBaseRequest
    {
        public DateTime? FechaNacimiento { get; set; }
    }

    public class PersonaBaseRequest : PersonaCodInterfaz
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public long? NroDocumento { get; set; }
        public bool? EsMasculino { get; set; }
        public bool? EsPEP { get; set; }
        public bool? EsSujetoObligado { get; set; }
        public long? CUIT { get; set; }
        public long? CUIL { get; set; }
        public string IdTipoDocumento { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }
        public string IdPais { get; set; }
        public string IdProvincia { get; set; }
        public string Email { get; set; }
        public long? CDI { get; set; }
        public string IdPaisNacionalidad { get; set; }
        public string IdPersonaAdicional { get; set; }
        public string IdEstadoCivil { get; set; }
        public string IdActividad { get; set; }
        public string IdTipoContribuyente { get; set; }
        public decimal? ImportePatrimonioNeto { get; set; }
    }

    public class PersonaCodInterfaz
    {
        public string IdPersona { get; set; }
    }

    public class CptCuentaBancariaBaseConNumSucursalRequest : CptCuentaBancariaBaseRequest
    {
        public int numSucursal { get; set; }
    }

    public class CptCuentaBancariaBaseRequest : CptCtaBancariaCodInterfaz
    {
        public string CBU { get; set; }
        public string moneda { get; set; }
        public string idTipoCuentaBancaria { get; set; }
        public string numeroCuenta { get; set; }
        public long CuitTitular { get; set; }
        public string idBanco { get; set; }
    }

    public class CptCtaBancariaCodInterfaz
    {
        public string idCptCuentaBancaria { get; set; }
    }
    #endregion

    #region Minimos
    public class CuotapartistaPersonaInsertUpdateRequestMinimo
    {
        public string IdCuotapartista { get; set; }
        public string Nombre { get; set; }
        public string IdAgenteColocador { get; set; }
        public string IdSucursal { get; set; }
        public string IdOficialCuenta { get; set; }
        public bool EsPersonaFisica { get; set; }
        public bool RequiereFirmaConjunta { get; set; } = true;
        public List<PersonaInsertRequestMinimo> Personas { get; set; }
        public List<CptCuentaBancariaRequestMinimo> CuentasBancarias { get; set; }
    }

    public class PersonaInsertRequestMinimo
    {
        public string IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdTipoDocumento { get; set; }
        public long NroDocumento { get; set; }
        public bool EsMasculino { get; set; }
        public bool EsPEP { get; set; }
        public bool EsSujetoObligado { get; set; }
    }

    public class CptCuentaBancariaRequestMinimo
    {
        public string idCptCuentaBancaria { get; set; }
        public string CBU { get; set; }
        public string Moneda { get; set; }
        public string IdTipoCuentaBancaria { get; set; }
        public string NumeroCuenta { get; set; }
        //public long CuitTitular { get; set; }
        //public string idBanco { get; set; }
    }

    #endregion
}
