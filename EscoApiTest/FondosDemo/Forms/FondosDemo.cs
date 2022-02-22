using EscoApiTest.FondosDemo.Models;
using EscoApiTest.FondosDemo.Models.Requests;
using EscoApiTest.FondosDemo.Models.Responses;
using EscoApiTest.FondosDemo.Responses.Settings;
using EscoApiTest.helpers;
using EscoApiTest.models.request;
using EscoApiTest.models.response;
using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Forms
{
    public partial class frmFondosDemo : MetroFramework.Forms.MetroForm
    {
        private string _token = string.Empty;
        private RequestResponseData _requestResponseData = null;
        private List<OficialCtaBaseTablaSistemaResponse> _oficialesCta = new List<OficialCtaBaseTablaSistemaResponse>();
        private List<SucursalBaseTablaSistemaResponse> _sucursales = new List<SucursalBaseTablaSistemaResponse>();
        private List<ItemBaseTablaSistemaResponse> _agColocadores = new List<ItemBaseTablaSistemaResponse>();
        private List<PersonaInsertRequestMinimo> _personasAEnviar = new List<PersonaInsertRequestMinimo>();
        
        public frmFondosDemo()
        {
            InitializeComponent();
            txtUrl.Text = "http://localhost:6003/api/fondos";
            txtVersion.Text = "4";

            LoadGenerosComboBox();
        }
        
        #region "Eventos"
        private void Form_Load(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //llamada al login
            await Login();
            await LoadTipoDocumentoComboBoxes();
            await LoadOficialCuentaComboBox();
            await LoadSucursalComboBox();
            await LoadAgenteColocadorComboBox();
        }

        private async void btnObtenerPersonas_Click(object sender, EventArgs e)
        {
            PagedList<PersonaResponse> personas = await GetPersonas();

            if(personas?.data != null)
            {
                PagedList<FondosDemo.Models.Persona> personasBase = MapPersonas(personas);
                CommonHelper.SetGrid(dgvPersonas, personasBase.data.ToList());
            }
            else
                CommonHelper.ClearGrid(dgvPersonas);
        }

        private async void btnObtenerCPTs_Click(object sender, EventArgs e)
        {
            PagedList<CuotapartistaResponse> cpts = await GetCuotapartistas();

            if (cpts?.data != null)
            {
                PagedList<FondosDemo.Models.Cuotapartista> cptsBase = MapCuotapartistas(cpts);
                CommonHelper.SetGrid(dgvCuotapartistas, cptsBase.data.ToList());
            }
            else
                CommonHelper.ClearGrid(dgvCuotapartistas);
        }

        private void btn_ins_Personas_AgregarALista_Click(object sender, EventArgs e)
        {
            PersonaInsertRequestMinimo pers = GetPersonaFromFormControls();

            if (pers != null )
                _personasAEnviar.Add(pers);
        }

        private void btn_ins_Personas_VerListaPersonas_Click(object sender, EventArgs e)
        {
            frmFondosDemoListaPersonas frmListaPersonas = new frmFondosDemoListaPersonas(_personasAEnviar);
            frmListaPersonas.ShowDialog();
        }

        private async void btnEnviarCtaGlobal_Click(object sender, EventArgs e) =>
            await InsertCuotapartistaCuentaGlobal();
        
        private void cmb_ins_DatosGrales_OficialCta_SelectedValueChanged(object sender, EventArgs e) =>
            CommonHelper.SetComboBox(cmb_ins_DatosGrales_Sucursal, GetFilteredSucursalesComboBoxBySelectedOficialCta(), "IdEntidad", "Descripcion_Id");

        private void cmb_ins_DatosGrales_Sucursal_SelectedValueChanged(object sender, EventArgs e) =>
            CommonHelper.SetComboBox(cmb_ins_DatosGrales_AgenteColocador, GetFilteredAgColocadoresComboBoxBySelectedSucursal(), "IdEntidad", "Descripcion_Id");
        #endregion

        public int ManejarError(string mensaje)
        {
            txtEstado.Text = mensaje;

            return 0;
        }

        public int ManejaRequestResponseMsg(RequestResponseData data)
        {
            _requestResponseData = data;
            string msg = string.Empty;

            txtEstado.Text = Task.Run(async () =>
            {
                try
                {
                    string rta = await data.HttpResponseMessage.Content.ReadAsStringAsync();
                    InsertUpdateDeleteResponse objRta = JsonConvert.DeserializeObject<InsertUpdateDeleteResponse>(rta);
                    msg = objRta.descripcion;

                    if (objRta.exception != null)
                        msg += $"\r\n{string.Join(", ", objRta.exception.Sugerencias)}";
                }
                catch (Exception ex)
                {
                    int i = 0;
                }

                return msg;
            }).Result;

            return 0;
        }

        private PagedList<FondosDemo.Models.Persona> MapPersonas(PagedList<PersonaResponse> personas)
        {
            PagedList<FondosDemo.Models.Persona> personasBasePgd = new PagedList<FondosDemo.Models.Persona>();
            List<FondosDemo.Models.Persona> personasBase = new List<FondosDemo.Models.Persona>();

            foreach (var pers in personas.data)
            {
                personasBase.Add(new FondosDemo.Models.Persona()
                {
                    Apellido = pers.apellido,
                    CUIL = pers.CUIL.ToString(),
                    CUIT = pers.CUIT.ToString(),
                    IdPersona = pers.idPersona,
                    IdTipoDocumento = pers.tipoDocumentoIdentidad.Descripcion,
                    Nombre = pers.nombre,
                    NroDocumento = pers.numDocumento.ToString()
                });
            }

            personasBasePgd.data = personasBase;

            return personasBasePgd;
        }

        private PagedList<FondosDemo.Models.Cuotapartista> MapCuotapartistas(PagedList<CuotapartistaResponse> cuotapartistas)
        {
            PagedList<FondosDemo.Models.Cuotapartista> cptsBasePgd = new PagedList<FondosDemo.Models.Cuotapartista>();
            List<FondosDemo.Models.Cuotapartista> cptsBase = new List<FondosDemo.Models.Cuotapartista>();

            foreach (var cpt in cuotapartistas.data)
            {
                cptsBase.Add(new FondosDemo.Models.Cuotapartista()
                {
                    Nombre = cpt.DatosGenerales.Nombre,
                    Numero = cpt.DatosGenerales.Numero,
                    EMail = cpt.DatosGenerales.EMail,
                    EsFisico = cpt.DatosGenerales.EsFisico,
                    RequiereFirmaConjunta = cpt.DatosGenerales.RequiereFirmaConjunta,
                    EstaAnulado = cpt.DatosGenerales.EstaAnulado,
                    FechaIngreso = cpt.DatosGenerales.FechaIngreso,
                    NumCustodia = cpt.DatosGenerales.NumCustodia,
                    IdCuotapartista = cpt.DatosGenerales.IdCuotapartista
                });
            }

            cptsBasePgd.data = cptsBase;

            return cptsBasePgd;
        }

        private string FormatJson(string jsonStr)
        {
            if (jsonStr.Replace("\"", "").Trim() == string.Empty)
                return "{}";

            string formattedJson;

            Regex regex = new Regex("(},)", RegexOptions.IgnoreCase);
            formattedJson = regex.Replace(jsonStr, "\r\n},\r\n");

            regex = new Regex("({\")", RegexOptions.IgnoreCase);
            formattedJson = regex.Replace(formattedJson, "{\r\n\"");

            regex = new Regex("(,\")", RegexOptions.IgnoreCase);
            formattedJson = regex.Replace(formattedJson, ",\r\n\"");

            regex = new Regex("(\\[{)", RegexOptions.IgnoreCase);
            formattedJson = regex.Replace(formattedJson, "[\r\n\\{");

            regex = new Regex("(}])");
            formattedJson = regex.Replace(formattedJson, "}\r\n]");

            return formattedJson.Replace("\\{", "{");
        }

        private PersonaInsertRequestMinimo GetPersonaFromFormControls()
        {
            if (string.IsNullOrWhiteSpace(txt_ins_Personas_IdPers.Text) 
                || string.IsNullOrWhiteSpace(txt_ins_Personas_NombrePers.Text)
                || string.IsNullOrWhiteSpace(txt_ins_Personas_ApellidoPers.Text)
                || string.IsNullOrWhiteSpace(msktxt_ins_Personas_NroDocPers.Text)
                || string.IsNullOrWhiteSpace(cmb_ins_Personas_TipoDocPers.SelectedValue?.ToString()))
                return null;

            return new PersonaInsertRequestMinimo()
            {
                IdPersona = string.IsNullOrWhiteSpace(txt_ins_Personas_IdPers.Text) ? null : txt_ins_Personas_IdPers.Text.Trim(),
                Nombre = string.IsNullOrWhiteSpace(txt_ins_Personas_NombrePers.Text) ? null : txt_ins_Personas_NombrePers.Text.Trim(),
                Apellido = string.IsNullOrWhiteSpace(txt_ins_Personas_ApellidoPers.Text) ? null : txt_ins_Personas_ApellidoPers.Text.Trim(),
                IdTipoDocumento = cmb_ins_Personas_TipoDocPers.SelectedValue?.ToString(),
                NroDocumento = long.Parse(string.IsNullOrWhiteSpace(msktxt_ins_Personas_NroDocPers.Text) ? "0" : msktxt_ins_Personas_NroDocPers.Text.Trim()),
                EsMasculino = ((int)cmb_ins_Personas_GeneroPers.SelectedValue) == 1 ? true : false,
                EsPEP = chk_ins_Personas_EsPEP.Checked,
                EsSujetoObligado = chk_ins_Personas_EsSujetoObligado.Checked
            };
        }

        #region "Llamadas EscoApi"
        private async Task Login()
        {
            CommonHelper.ClearGrid(dgvPersonas);
            //se prepara el objeto de request a enviar
            LoginRequest request = new LoginRequest { userName = txtUser.Text, password = txtClave.Text };
            LoginResponse response;
            
            try
            {
                //obtengo la respuesta del login al llamar a una funcion Generica para consumir EscoApi
                response = await HTTPHelper.ConsumirMetodoPostGenericoItem<LoginResponse>(request, "login", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

                if (response != null)
                {
                    //se obtuvo un token valido, ahora se buscan las cuentas relacionadas con el usaurio
                    _token = response.access_token;
                    txtToken.Text = response.access_token;
                }
                else //no se pudo autenticar con EsoApi
                    _token = "";
            }
            catch (Exception ex)
            {
                //se genero un error al llamar a EscoApi
                _token = "";
                txtEstado.Text = ex.Message;
                CommonHelper.ClearGrid(dgvPersonas);
            }
        }

        private async Task<List<ItemBaseTablaSistemaResponse>> GetTiposDocumentoIdentidad()
        {
            List<ItemBaseTablaSistemaResponse> tiposDocRet = new List<ItemBaseTablaSistemaResponse>();
            List<ItemBaseTablaSistemaResponse> tiposDoc = new List<ItemBaseTablaSistemaResponse>();

            tiposDoc = await HTTPHelper.ConsumirMetodoGetGenerico<ItemBaseTablaSistemaResponse>(
                EscoApiTest.FondosDemo.Constants.UrlPaths.GetTiposDocumentoIdentidad, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

            tiposDocRet.Add(new ItemBaseTablaSistemaResponse()
            {
                Codigo = 0,
                Descripcion = "Seleccione...",
                IdEntidad = null
            });

            tiposDocRet.AddRange(tiposDoc);

            return tiposDocRet;
        }

        private async Task<PagedList<PersonaResponse>> GetPersonas()
        {
            IDictionary<string, string> parameters = GetPersonaQueryParametersFromFormControls();
            ClearJsonTxt(mtxtJsonPersonas);

            AddActionMethodNameAndQueryStringParamsToJsonTxt(FondosDemo.Constants.UrlPaths.GetPersonas, HTTPHelper.GetQueryParams(parameters), mtxtJsonPersonas);
            AddRequestBodyContentsToJsonTxt("", mtxtJsonPersonas);
            
            var response = await HTTPHelper.ConsumirMetodoGetGenericoItem<PagedList<PersonaResponse>>(
                FondosDemo.Constants.UrlPaths.GetPersonas, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError, parameters, ManejaRequestResponseMsg);

            AddRequestResponseDataToJsonTxt(_requestResponseData, mtxtJsonPersonas);
            AddResponseBodyContentsToJsonTxt(response, mtxtJsonPersonas);

            return response;
        }

        private async Task<PagedList<CuotapartistaResponse>> GetCuotapartistas()
        {
            IDictionary<string, string> parameters = GetCuotapartistaQueryParametersFromFormControls();
            ClearJsonTxt(mtxtJsonCuotapartistas);

            AddActionMethodNameAndQueryStringParamsToJsonTxt(FondosDemo.Constants.UrlPaths.GetCuotapartistas, HTTPHelper.GetQueryParams(parameters), mtxtJsonCuotapartistas);
            AddRequestBodyContentsToJsonTxt("", mtxtJsonCuotapartistas);
            
            var response = await HTTPHelper.ConsumirMetodoGetGenericoItem<PagedList<CuotapartistaResponse>>(
                FondosDemo.Constants.UrlPaths.GetCuotapartistas, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError, parameters, ManejaRequestResponseMsg);

            AddRequestResponseDataToJsonTxt(_requestResponseData, mtxtJsonCuotapartistas);
            AddResponseBodyContentsToJsonTxt(response, mtxtJsonCuotapartistas);

            return response;
        }

        private async Task<List<OficialCtaBaseTablaSistemaResponse>> GetOficialesCuenta()
        {
            List<OficialCtaBaseTablaSistemaResponse> oficialesCtaRet = new List<OficialCtaBaseTablaSistemaResponse>();
            List<OficialCtaBaseTablaSistemaResponse> oficialesCta = new List<OficialCtaBaseTablaSistemaResponse>();

            oficialesCta = await HTTPHelper.ConsumirMetodoGetGenerico<OficialCtaBaseTablaSistemaResponse>(
                EscoApiTest.FondosDemo.Constants.UrlPaths.GetOficialesCuenta, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

            oficialesCtaRet.Add(new OficialCtaBaseTablaSistemaResponse()
            {
                Codigo = 0,
                Descripcion = "Seleccione...",
                IdEntidad = null,
                IdAgenteColocador = null,
                IdSucursal = null
            });

            oficialesCtaRet.AddRange(oficialesCta);

            return oficialesCtaRet;
        }

        private async Task<List<SucursalBaseTablaSistemaResponse>> GetSucursales()
        {
            List<SucursalBaseTablaSistemaResponse> sucursalesRet = new List<SucursalBaseTablaSistemaResponse>();
            List<SucursalBaseTablaSistemaResponse> sucursales = new List<SucursalBaseTablaSistemaResponse>();

            sucursales = await HTTPHelper.ConsumirMetodoGetGenerico<SucursalBaseTablaSistemaResponse>(
                EscoApiTest.FondosDemo.Constants.UrlPaths.GetSucursales, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

            sucursalesRet.Add(new SucursalBaseTablaSistemaResponse()
            {
                Codigo = 0,
                Descripcion = "Seleccione...",
                IdEntidad = null,
                IdAgenteColocador = null
            });

            sucursalesRet.AddRange(sucursales);

            return sucursalesRet;
        }

        private async Task<List<ItemBaseTablaSistemaResponse>> GetAgentesColocadores()
        {
            List<ItemBaseTablaSistemaResponse> agColocadoresRet = new List<ItemBaseTablaSistemaResponse>();
            List<ItemBaseTablaSistemaResponse> agColocadores = new List<ItemBaseTablaSistemaResponse>();

            agColocadores = await HTTPHelper.ConsumirMetodoGetGenerico<ItemBaseTablaSistemaResponse>(
                EscoApiTest.FondosDemo.Constants.UrlPaths.GetAgentesColocadores, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

            agColocadoresRet.Add(new ItemBaseTablaSistemaResponse()
            {
                Codigo = 0,
                Descripcion = "Seleccione...",
                IdEntidad = null
            });

            agColocadoresRet.AddRange(agColocadores);

            return agColocadoresRet;
        }

        private async Task InsertCuotapartistaCuentaGlobal()
        {
            ClearJsonTxt(mtxtJsonCuotapartistas);

            CuotapartistaPersonaInsertUpdateRequestMinimo insertUpdateCtaGlobal = new CuotapartistaPersonaInsertUpdateRequestMinimo()
            {
                 IdCuotapartista = txt_ins_DatosGrales_IdCPT.Text?.Trim(),
                 Nombre = txt_ins_DatosGrales_NombreCPT.Text?.Trim() ?? null,
                 IdAgenteColocador = cmb_ins_DatosGrales_AgenteColocador.SelectedValue?.ToString() ?? null,
                 IdSucursal = cmb_ins_DatosGrales_Sucursal.SelectedValue?.ToString() ?? null,
                 IdOficialCuenta = cmb_ins_DatosGrales_OficialCta.SelectedValue?.ToString() ?? null,
                 EsPersonaFisica = chk_ins_DatosGrales_EsPersonaFisica.Checked,
                 RequiereFirmaConjunta = chk_ins_DatosGrales_RequiereFirmaConjunta.Checked,
                 Personas = _personasAEnviar.Count > 0 ? _personasAEnviar : null//,
                 //CuentasBancarias = _ctasBancarias.Count > 0 ? _ctasBancarias : null
            };

            AddActionMethodNameAndQueryStringParamsToJsonTxt(FondosDemo.Constants.UrlPaths.InsertUpdateCuentaGlobal, "", mtxtJsonCuotapartistas);
            AddRequestBodyContentsToJsonTxt(insertUpdateCtaGlobal, mtxtJsonCuotapartistas);

            var response = await HTTPHelper.ConsumirMetodoPostGenericoItem<InsertUpdateDeleteResponse>(insertUpdateCtaGlobal,
                FondosDemo.Constants.UrlPaths.InsertUpdateCuentaGlobal, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError, null, ManejaRequestResponseMsg);

            AddRequestResponseDataToJsonTxt(_requestResponseData, mtxtJsonCuotapartistas);
            AddResponseBodyContentsToJsonTxt(response, mtxtJsonCuotapartistas);

            _personasAEnviar = new List<PersonaInsertRequestMinimo>();
        }

        private IDictionary<string, string> GetPersonaQueryParametersFromFormControls()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            if (cmbTiposDocIdPers.SelectedValue != null)
                parameters.Add(new KeyValuePair<string, string>("idTipoDocumento", ((ItemBaseTablaSistemaResponse)cmbTiposDocIdPers.SelectedItem).IdEntidad));

            if (!string.IsNullOrWhiteSpace(msktxtNroDocIdPers.Text))
                parameters.Add(new KeyValuePair<string, string>("numeroDocumento", msktxtNroDocIdPers.Text.Trim()));

            if (!string.IsNullOrWhiteSpace(msktxtCUITPers.Text.Replace("-", "").Trim()))
                parameters.Add(new KeyValuePair<string, string>("cuit", msktxtCUITPers.Text.Replace("-", "").Trim()));

            if (!string.IsNullOrWhiteSpace(msktxtCUILPers.Text.Replace("-", "").Trim()))
                parameters.Add(new KeyValuePair<string, string>("cuil", msktxtCUILPers.Text.Replace("-", "").Trim()));

            if (!string.IsNullOrWhiteSpace(txtIdPers.Text))
                parameters.Add(new KeyValuePair<string, string>("idPersona", txtIdPers.Text.Trim()));

            parameters.Add(new KeyValuePair<string, string>("pageNumber", !string.IsNullOrWhiteSpace(msktxtPageNumPers.Text) ? msktxtPageNumPers.Text.Trim() : "1"));
            parameters.Add(new KeyValuePair<string, string>("pageSize", !string.IsNullOrWhiteSpace(msktxtPageSizePers.Text) ? msktxtPageSizePers.Text.Trim() : "20"));

            return parameters;
        }

        private IDictionary<string, string> GetCuotapartistaQueryParametersFromFormControls()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            if (cmbTiposDocIdCPT.SelectedValue != null)
                parameters.Add(new KeyValuePair<string, string>("idTipoDocumento", ((ItemBaseTablaSistemaResponse)cmbTiposDocIdCPT.SelectedItem).IdEntidad));

            if (!string.IsNullOrWhiteSpace(msktxtNroDocCPT.Text))
                parameters.Add(new KeyValuePair<string, string>("numeroDocumento", msktxtNroDocCPT.Text.Trim()));

            if (!string.IsNullOrWhiteSpace(msktxtCUITCPT.Text.Replace("-", "").Trim()))
                parameters.Add(new KeyValuePair<string, string>("cuit", msktxtCUITCPT.Text.Replace("-", "").Trim()));

            if (!string.IsNullOrWhiteSpace(msktxtCUILCPT.Text.Replace("-", "").Trim()))
                parameters.Add(new KeyValuePair<string, string>("cuil", msktxtCUILCPT.Text.Replace("-", "").Trim()));

            if (!string.IsNullOrWhiteSpace(mtxtNroCPT.Text))
                parameters.Add(new KeyValuePair<string, string>("numCuotapartista", mtxtNroCPT.Text.Trim()));
            
            if (!string.IsNullOrWhiteSpace(txtNroCustodiaCPT.Text))
                parameters.Add(new KeyValuePair<string, string>("numCustodia", txtNroCustodiaCPT.Text.Trim()));

            parameters.Add(new KeyValuePair<string, string>("pageNumber", !string.IsNullOrWhiteSpace(msktxtPageNumCPT.Text) ? msktxtPageNumCPT.Text.Trim() : "1"));
            parameters.Add(new KeyValuePair<string, string>("pageSize", !string.IsNullOrWhiteSpace(msktxtPageSizeCPT.Text) ? msktxtPageSizeCPT.Text.Trim() : "20"));

            return parameters;
        }
        #endregion

        #region "Setear Objetos"
        private async Task LoadTipoDocumentoComboBoxes()
        {
            CommonHelper.ClearComboBox(cmbTiposDocIdPers);
            CommonHelper.ClearComboBox(cmbTiposDocIdCPT);

            try
            {
                List<ItemBaseTablaSistemaResponse> tiposDoc = await GetTiposDocumentoIdentidad();

                CommonHelper.SetComboBox(cmbTiposDocIdPers, tiposDoc.AsQueryable().ToList(), "Codigo", "Descripcion");
                CommonHelper.SetComboBox(cmbTiposDocIdCPT, tiposDoc.AsQueryable().ToList(), "Codigo", "Descripcion");
                CommonHelper.SetComboBox(cmb_ins_Personas_TipoDocPers, tiposDoc.AsQueryable().ToList(), "IdEntidad", "Descripcion");
            }
            catch (Exception ex)
            {
                //se genero un error al llamar a EscoApi
                txtEstado.Text = ex.Message;
            }
        }

        private async Task LoadOficialCuentaComboBox()
        {
            CommonHelper.ClearComboBox(cmb_ins_DatosGrales_OficialCta);

            try
            {
                _oficialesCta = await GetOficialesCuenta();

                CommonHelper.SetComboBox(cmb_ins_DatosGrales_OficialCta, _oficialesCta, "IdEntidad", "Descripcion_Id");
            }
            catch (Exception ex)
            {
                txtEstado.Text = ex.Message;
            }
        }

        private async Task LoadSucursalComboBox()
        {
            CommonHelper.ClearComboBox(cmb_ins_DatosGrales_Sucursal);

            try
            {
                _sucursales = await GetSucursales();
                List<SucursalBaseTablaSistemaResponse> sucs = GetFilteredSucursalesComboBoxBySelectedOficialCta();

                CommonHelper.SetComboBox(cmb_ins_DatosGrales_Sucursal, sucs, "IdEntidad", "Descripcion_Id");
            }
            catch (Exception ex)
            {
                txtEstado.Text = ex.Message;
            }
        }

        private async Task LoadAgenteColocadorComboBox()
        {
            CommonHelper.ClearComboBox(cmb_ins_DatosGrales_AgenteColocador);

            try
            {
                _agColocadores = await GetAgentesColocadores();
                List<ItemBaseTablaSistemaResponse> agColocadores = GetFilteredAgColocadoresComboBoxBySelectedSucursal();

                CommonHelper.SetComboBox(cmb_ins_DatosGrales_AgenteColocador, agColocadores, "IdEntidad", "Descripcion_Id");
            }
            catch (Exception ex)
            {
                //se genero un error al llamar a EscoApi
                txtEstado.Text = ex.Message;
            }
        }

        private List<SucursalBaseTablaSistemaResponse> GetFilteredSucursalesComboBoxBySelectedOficialCta()
        {
            List<SucursalBaseTablaSistemaResponse> sucs = _sucursales.ToList();

            if (cmb_ins_DatosGrales_OficialCta.SelectedValue?.ToString() != null)
            {
                string idSuc = ((OficialCtaBaseTablaSistemaResponse)cmb_ins_DatosGrales_OficialCta.SelectedItem).IdSucursal;

                sucs = _sucursales.Where(s => idSuc == s.IdEntidad || s.Descripcion == "Seleccione...")
                                    .ToList();
            }

            return sucs;
        }

        private List<ItemBaseTablaSistemaResponse> GetFilteredAgColocadoresComboBoxBySelectedSucursal()
        {
            List<ItemBaseTablaSistemaResponse> agColocadores = _agColocadores.ToList();

            if (cmb_ins_DatosGrales_Sucursal.SelectedValue?.ToString() != null)
            {
                List<SucursalBaseTablaSistemaResponse> sucs = GetFilteredSucursalesComboBoxBySelectedOficialCta();
                agColocadores = _agColocadores.Where(ac => sucs.Any(s => s.IdAgenteColocador == ac.IdEntidad || ac.Descripcion == "Seleccione..."))
                                                .ToList();
            }

            return agColocadores;
        }

        private void LoadGenerosComboBox()
        {
            CommonHelper.ClearComboBox(cmb_ins_Personas_GeneroPers);
            CommonHelper.SetComboBox(cmb_ins_Personas_GeneroPers, Genero.GetGeneros(), "Codigo", "Descripcion");
        }

        private void ClearJsonTxt(MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text = string.Empty;

        private void AddActionMethodNameToJsonTxt(string actionMethod, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text += $"\r\nAction Method: {actionMethod}";

        private void AddParamContentsToJsonTxt(string qryParams, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text += $"\r\nQueryString Parameters:{qryParams}";

        private void AddActionMethodNameAndQueryStringParamsToJsonTxt(string actionMethod, string qsParams, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text += $"\r\nAction Method + params:\r\n{actionMethod}{qsParams}";

        private void SetRequestAndResponseContentsToJsonTxt<T, Z>(T req, Z resp, MetroTextBox jsonTxtBox)
        {
            jsonTxtBox.Text = $"Request:\r\n{FormatJson(JsonConvert.SerializeObject(req))}";
            jsonTxtBox.Text += $"\r\n\r\nResponse:\r\n{FormatJson(JsonConvert.SerializeObject(resp))}";
        }

        private void SetRequestContentsToJsonTxt<T>(T req, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text = $"Request:\r\n{FormatJson(JsonConvert.SerializeObject(req))}";

        private void SetResponseContentsToJsonTxt<T>(T resp, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text = $"Response:\r\n{FormatJson(JsonConvert.SerializeObject(resp))}";

        private void AddRequestBodyContentsToJsonTxt<T>(T req, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text += $"\r\n\r\nRequest Body:\r\n{FormatJson(JsonConvert.SerializeObject(req))}";

        private void AddResponseBodyContentsToJsonTxt<T>(T resp, MetroTextBox jsonTxtBox) =>
            jsonTxtBox.Text += $"\r\n\r\nResponse Body:\r\n{FormatJson(JsonConvert.SerializeObject(resp))}";

        private void AddRequestResponseDataToJsonTxt(RequestResponseData data, MetroTextBox jsonTxtBox)
        {
            if (data != null)
            {
                jsonTxtBox.Text += $"\r\n{data.HttpRequestMessage.Method} {data.HttpRequestMessage.Version} {data.HttpRequestMessage.RequestUri}";

                jsonTxtBox.Text += $"\r\nHeaders:";
                foreach (var header in data.HttpRequestMessage.Headers)
                    jsonTxtBox.Text += $"\r\n {header.Key}: {header.Value.FirstOrDefault()}";
            }
        }
        #endregion
    }

}
