using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EscoApiTest.helpers;
using EscoApiTest.models.request;
using EscoApiTest.models.response;
using MetroFramework.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pathoschild.Http.Client;

namespace EscoApiTest {
    public partial class frmTest : MetroFramework.Forms.MetroForm {

        public string token;
        public List<ValuacionResponse> valuacion;
        public List<string> tpActivos;


        #region "Eventos"
        public frmTest() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            tabControl1.SelectTab(0);
        }

        private async  void btnLogin_Click(object sender, EventArgs e) {
            //llamada al login
            await Login();
        }

        private async void btnCuentas_Click(object sender, EventArgs e) {
            //llamada a obtener cuentas
            await ObtenerCuentas();
        }

        private async void btnValuacion_Click(object sender, EventArgs e) {
            //llamada a obtener la valuacion
            await ObtenerValuacion(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString());
        }

        private async void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e) {
            //llamada a obtener la valuacion ante el cambio de la cuenta seleccionada
            if (cmbCuentas.SelectedItem != null) {
                await ObtenerValuacion(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString());
                ClearGrid(dgvOrdenes);
            }
        }

        private async void btnIngresarOrden_Click(object sender, EventArgs e) {
            //llamada para ingresar una orden
            await IngresarOrden(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta);
        }

        private void cmbTpActivo_SelectedIndexChanged(object sender, EventArgs e) {
            //arma los items a mostrar en el grafico de acuerdo al tipo de activo seleccionado
            List<PieItem> items;
            if (cmbTpActivo.SelectedIndex == 0) {
                items = valuacion.GroupBy(x => x.tpActivo).Select(g => new PieItem { activo = g.Key, tpActivo = g.Key, total = g.Sum(x => x.valuacion) }).ToList();
                SetChart(chartValuacion, items, "tpActivo");

            } else {
                items = valuacion.Select(g => new PieItem { activo = g.abreviatura, total = g.valuacion, tpActivo = g.tpActivo }).Where(g => g.tpActivo.Equals(cmbTpActivo.SelectedItem)).ToList();
                SetChart(chartValuacion, items, "activo");
            }
        }

        private void chartValuacion_GetTooltipText(object sender, ToolTipEventArgs e) {
            HitTestResult hitTestResult = chartValuacion.HitTest(e.X, e.Y);

            if (hitTestResult.PointIndex >= 0)
                if (hitTestResult.ChartElementType == ChartElementType.DataPoint) {
                    metroToolTip1.RemoveAll();

                    var results = chartValuacion.HitTest(e.X, e.Y, false,
                                                       ChartElementType.DataPoint);
                    foreach (var result in results) {
                        if (result.ChartElementType == ChartElementType.DataPoint) {
                            var prop = result.Object as DataPoint;
                            if (prop != null) {
                                metroToolTip1.Show("Total : $ " + prop.YValues[0], chartValuacion, e.X, e.Y - 15, 1000);
                            }
                        }
                    }
                }
        }

        private async void btnConsultarOrdenes_Click(object sender, EventArgs e) {
            //llamada para consultar ordenes
            await ObtenerOrdenes(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString()), dtpFechaDesde.Value, dtpFechaHasta.Value);
        }

        private async void btnCotizaciones_Click(object sender, EventArgs e) {
            //llamada para consultar cotizaciones
            await ObtenerCotizaciones(txtInstrumentoSearch.Text, chkExactMatch.Checked);
        }

        public int ManejarError(string mensaje) {
            txtEstado.Text = mensaje;
            return 0;
        }

        private async void btnConsultarDisponible_Click(object sender, EventArgs e) {
            //llamada para consultar disponible de monedas
            await ObtenerDisponible(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta));
        }

        private async void btnTraerCuentasBancarias_Click(object sender, EventArgs e) {
            //llamada para consultar cuentas bancarias del agente
            await ObtenerCuentasBancarias(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString()));
        }

        private async void btnConsultarFCI_Click(object sender, EventArgs e) {
            await ObtenerSolicitudesFCI(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString()), dtpFechaDesdeFCI.Value, dtpFechaHastaFCI.Value);
        }

        private async void btnInsertRecibo_Click(object sender, EventArgs e) {
            //llamada para ingresar una orden
            await IngresarRecibo(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta);
        }

        private async void btnConsultarRecibos_Click(object sender, EventArgs e) {
            //llamada para consultar ordenes
            await ObtenerRecibos(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString()), dtpFechaDesde.Value, dtpFechaHasta.Value);
        }

        #endregion


        #region "Llamadas EscoApi"
        /// <summary>
        /// autentica al usuario en la API y obtiene un token
        /// </summary>
        /// <returns></returns>
        private async Task Login() {
            //se prepara el objeto de request a enviar
            LoginRequest request = new LoginRequest { userName = txtUser.Text, password = txtClave.Text };
            LoginResponse response;

            try {
                //obtengo la respuesta del login al llamar a una funcion Generica para consumir EscoApi
                response = await HTTPHelper.ConsumirMetodoPostGenericoItem<LoginResponse>(request, "login", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

                if (response != null) {
                    //se obtuvo un token valido, ahora se buscan las cuentas relacionadas con el usaurio
                    token = response.access_token;
                    txtToken.Text = response.access_token;
                    await ObtenerCuentas();
                } else {
                    //no se pudo autenticar con EsoApi
                    token = "";
                    cmbCuentas.DataSource = null; 

                    ClearGrid(dgvValuacion);
                    ClearChart(chartValuacion);
                }

            } catch (Exception ex) {
                //se genero un error al llamar a EscoApi
                token = "";
                cmbCuentas.DataSource = null;
                txtEstado.Text = ex.Message;
                txtJson.Text = "";

                ClearGrid(dgvValuacion);
                ClearChart(chartValuacion);
            }
        }

        /// <summary>
        /// obtiene las cuentas con las cual puede trabajar el usuario logueado
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerCuentas() {
            //se prepara el objeto de request a enviar
            CuentasRequest request = new CuentasRequest { stringSearch = "", showAccountDescription= true };
            List<CuentaResponse> response;
                        
            try {
                //obtengo la respuesta de las cuentas al llamar a una funcion Generica para consumir EscoApi
                response = await HTTPHelper.ConsumirMetodoPostGenerico<CuentaResponse>(request, "buscar-cuentas",txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

                //al obtener los datos los muestro en una grilla
                SetList(cmbCuentas, response, "descripcion", "numeroCuenta");
                txtEstado.Text = "Existen " + response.Count.ToString() + " Cuentas para el usuario";

            } catch (Exception ex) {
                cmbCuentas.DataSource = null;              
            }
        }


        /// <summary>
        /// obtiene el estado de cuenta de una cuenta comitente especifica
        /// </summary>
        /// <param name="cuenta">Cuenta comitente a consultar</param>
        /// <returns></returns>
        private async Task ObtenerValuacion(string cuenta) {
            //se prepara el objeto de request a enviar
            ValuacionRequest request = new ValuacionRequest { cuentas= cuenta, agruparPorMoneda=true, esConsolidado=false, monedaValuacion ="ARS", porConcertacion =true, Fecha = DateTime.Now };
            List<ValuacionResponse> response = new List<ValuacionResponse>();

            try {
                string oData = (chkOData.Checked == true) ? txtOData.Text : "";
                //obtengo la respuesta del esatdo de cuenta al llamar a una funcion Generica para consumir EscoApi
                var responseContent = await HTTPHelper.ConsumirMetodoPost(request, "get-tenenciaval" + oData, txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                
                try {
                    //creo la lista de items de estado de cuenta con la respuesta recibida
                    response = JsonConvert.DeserializeObject<List<ValuacionResponse>>(responseContent);

                    //vuelco los datos del estado de cuenta a la grilla
                    valuacion = response;
                    SetGrid(dgvValuacion, response);

                    //sumo los items del esatdo de cuenta por tipo de activo y los muestro en un grafico
                    List<PieItem> items = response.GroupBy(x => x.tpActivo).Select(g => new PieItem { tpActivo = g.Key, total = g.Sum(x => x.valuacion) }).ToList();
                    SetChart(chartValuacion, items, "tpActivo");

                    //agrego los tipos de activo en un desplegable para poder filtrar el grafico
                    tpActivos = response.Select(o => o.tpActivo).Distinct().ToList();
                    tpActivos.Insert(0, "Todos");

                    SetList(cmbTpActivo, tpActivos);

                    //muestro el texto recibido por EscoApi en un TextBox
                    txtJson.Text = JValue.Parse(responseContent).ToString(Formatting.Indented);

                } catch (Exception ex) {
                    ClearGrid(dgvValuacion);
                }
            } catch (Exception ex) {
                txtEstado.Text = ex.Message;
                txtJson.Text = "";
            }
        }

        /// <summary>
        /// obtiene las ordenes de una cuenta especifica
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerOrdenes(long cuenta, DateTime fechaDesde, DateTime fechahasta) {
            OrdenesRequest request = new OrdenesRequest { cuenta = cuenta, FechaDesde = fechaDesde, FechaHasta = fechahasta };
            List<OrdenesResponse> response = new List<OrdenesResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoPostGenerico<OrdenesResponse>(request, "get-ordenes", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvOrdenes, response);
                
            } catch (Exception ex) {
                ClearGrid(dgvOrdenes);
            }
        }



        /// <summary>
        /// obtiene las solicitudes fci
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerSolicitudesFCI(long cuenta, DateTime fechaDesde, DateTime fechahasta) {
            SolicitudesFCIRequest request = new SolicitudesFCIRequest { cuentas = cuenta.ToString(), EsConsolidado=false, porConcertacion =chkConcertacion.Checked, fechaDesde= fechaDesde, fechaHasta = fechahasta };
            List<SolicitudesFCIResponse> response = new List<SolicitudesFCIResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoPostGenerico<SolicitudesFCIResponse>(request, "get-solicitudes-fondos", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvSolicitudesFCI, response);

            } catch (Exception ex) {
                ClearGrid(dgvSolicitudesFCI);
            }
        }



        /// <summary>
        /// obtiene las cotizaciones de un instrumento (Cotizaciones obtenidas del mercado via FIX)
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerCotizaciones(string instrumento, bool exactMatch) {
            CotizacionesRequest request = new CotizacionesRequest { instrumento = instrumento, exactMatch = exactMatch };
            List<CotizacionResponse> response = new List<CotizacionResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoPostGenerico<CotizacionResponse>(request, "get-cotizaciones", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvCotizaciones, response);
            } catch (Exception ex) {
                ClearGrid(dgvOrdenes);
            }
        }

        /// <summary>
        /// obtiene las cotizaciones de un instrumento (Cotizaciones obtenidas del mercado via FIX)
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerCuentasBancarias(long cuenta) {
            List<CuentaBancariaResponse> response = new List<CuentaBancariaResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoGetGenerico<CuentaBancariaResponse>("get-cuentas-bancarias-comitente?cuenta=" + cuenta.ToString(), txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvCuentasBancarias, response);
            } catch (Exception ex) {
                ClearGrid(dgvCuentasBancarias);
            }
        }


        /// <summary>
        /// obtiene el disponible en moneda para operar de una cuenta
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerDisponible(long cuenta) {
            DisponibleMonRequest request = new DisponibleMonRequest { cuenta = cuenta, diasRescatesPendientes=0, diasSuscripcionesPendientes = 0, fechaDisponible= DateTime.Now, incluyeCreditos=false, moneda ="ARS", plazo = 0, fechaColocacionHasta = DateTime.Now};            List<DisponibleMonResponse> response = new List<DisponibleMonResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoPostGenerico<DisponibleMonResponse>(request, "get-disponible-mon", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvDisponible, response);

            } catch (Exception ex) {
                ClearGrid(dgvDisponible);
            }
        }

        /// <summary>
        /// ingresa una orden de compra que posteriormente se rutea al mercado
        /// </summary>
        /// <returns></returns>
        private async Task IngresarOrden(long cuenta) {
            InsertOrdenRequest request = new InsertOrdenRequest { cuenta = cuenta, FechaConcertacion = DateTime.Now, aplicacion = "TEST" 
                ,cantidad=Convert.ToDecimal(txtCantidad.Text), precio = Convert.ToDecimal(txtPrecio.Text), controlaPerfilInversor=false, controlaSubyacente = false  
                ,mercado ="ME", incluyeGastosEnImporte = false, instrumentoAbreviatura = txtInstrumento.Text, moneda=txtMoneda.Text, ordenMarket=false, plazo = Convert.ToInt32( txtPlazo.Text)
                , rutearOrdenAlMercado=false, validarOrden=true, variacionPrecio=100};
            InsertOrdenResponse response;

            try {
                var responseContent = await HTTPHelper.ConsumirMetodoPost(request, "insert-orden-compra", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

                try {
                    response = JsonConvert.DeserializeObject<InsertOrdenResponse>(responseContent);
                    await ObtenerOrdenes(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta, dtpFechaDesde.Value, dtpFechaHasta.Value);
                } catch (Exception ex) {
                    ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                    txtEstado.Text = error.error.Msj;
                }

            } catch (Exception ex) {

            }
        }


        /// <summary>
        /// obtiene lso recibos y comrpobantes de una cuenta
        /// </summary>
        /// <returns></returns>
        private async Task ObtenerRecibos(long cuenta, DateTime fechaDesde, DateTime fechahasta) {
            RecibosComprobantesRequest request = new RecibosComprobantesRequest { cuentas = cuenta.ToString(), fechaDesde = DateTime.Now, fechaHasta = DateTime.Now, EsConsolidado = false, porConcertacion = true };
            List<RecibosComprobantesResponse> response = new List<RecibosComprobantesResponse>();

            try {
                response = await HTTPHelper.ConsumirMetodoPostGenerico<RecibosComprobantesResponse>(request, "get-recibos-comprobantes", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);
                SetGrid(dgvRecibos, response);

            } catch (Exception ex) {
                ClearGrid(dgvRecibos);
            }
        }


        /// <summary>
        /// ingresa un recibo de cobro
        /// </summary>
        /// <returns></returns>
        private async Task IngresarRecibo(long cuenta) {
            ReciboCobroRequest request = new ReciboCobroRequest {
                Cuenta = cuenta, FechaConcertacion = DateTime.Now, FechaLiquidacion = DateTime.Now, Importe = 1000, Moneda = "ARS", NumReferencia = "1", TpCambioMovPais = 1, CuentaContable = 229, CuentaBancariaComitente = 1
            };


            ReciboCobroResponse response;

            try {
                var responseContent = await HTTPHelper.ConsumirMetodoPost(request, "insert-recibo-cobro", txtUrl.Text, txtVersion.Text, txtToken.Text, ManejarError);

                try {
                    response = JsonConvert.DeserializeObject<ReciboCobroResponse>(responseContent);
                    await ObtenerRecibos(Convert.ToInt64(((CuentaResponse)cmbCuentas.SelectedItem).numeroCuenta.ToString()), dtpFechaDesde.Value, dtpFechaHasta.Value);
                } catch (Exception ex) {
                    ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                    txtEstado.Text = error.error.Msj;
                }

            } catch (Exception ex) {

            }
        }

        #endregion


        #region "Setear Objetos"

        private void SetGrid<T>(DataGridView grilla, List<T> source) {
            grilla.DataSource = source;
            grilla.Refresh();
        }

        private void ClearGrid(DataGridView grilla) {
            grilla.DataSource = null;
            grilla.Refresh();
        }

        private void SetChart<T>(Chart grafico, List<T> source, string field) {
            grafico.DataSource = source;
            grafico.Series["TpActivos"].XValueMember = field;
            grafico.Series["TpActivos"].YValueMembers = "total";
            grafico.Series["TpActivos"]["PieLabelStyle"] = "Disabled";
            grafico.DataBind();
        }

        private void ClearChart(Chart grafico) {
            grafico.DataSource = new List<ValuacionResponse>();
            grafico.DataBind();
        }

        private void SetList<T>(MetroComboBox lista, List<T> source, string displayMember, string valueMember) {
            lista.DataSource = source;
            lista.DisplayMember = "descripcion";
            lista.ValueMember = "numeroCuenta";
            lista.Refresh();
            lista.SelectedIndex = 0;
        }

        private void SetList<T>(MetroComboBox lista, List<T> source) {
            lista.DataSource = source;
            lista.Refresh();
            lista.SelectedIndex = 0;
        }







        #endregion

        
    }

}
