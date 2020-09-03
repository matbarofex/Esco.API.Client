using MetroFramework.Controls;

namespace EscoApiTest {
    partial class frmTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.txtToken = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCuentas = new MetroFramework.Controls.MetroButton();
            this.btnValuacion = new MetroFramework.Controls.MetroButton();
            this.dgvValuacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVersion = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chartValuacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCuentas = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.txtJson = new MetroFramework.Controls.MetroTextBox();
            this.cmbTpActivo = new MetroFramework.Controls.MetroComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultarOrdenes = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIngresarOrden = new MetroFramework.Controls.MetroButton();
            this.txtPlazo = new MetroFramework.Controls.MetroTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoneda = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInstrumento = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.chkExactMatch = new MetroFramework.Controls.MetroCheckBox();
            this.txtInstrumentoSearch = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCotizaciones = new MetroFramework.Controls.MetroButton();
            this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.btnConsultarDisponible = new MetroFramework.Controls.MetroButton();
            this.dgvDisponible = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dgvSolicitudesFCI = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkConcertacion = new MetroFramework.Controls.MetroCheckBox();
            this.dtpFechaDesdeFCI = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConsultarFCI = new MetroFramework.Controls.MetroButton();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaHastaFCI = new System.Windows.Forms.DateTimePicker();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.btnConsultarRecibos = new MetroFramework.Controls.MetroButton();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCuentaBancariaComitente = new MetroFramework.Controls.MetroTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCuentaAgente = new MetroFramework.Controls.MetroTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnInsertRecibo = new MetroFramework.Controls.MetroButton();
            this.txtImporteRecibo = new MetroFramework.Controls.MetroTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvCuentasBancarias = new System.Windows.Forms.DataGridView();
            this.btnTraerCuentasBancarias = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.chkOData = new MetroFramework.Controls.MetroCheckBox();
            this.txtOData = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValuacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValuacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
            this.metroTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesFCI)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.metroTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasBancarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(60, 13);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(60, 42);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(241, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(50, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(209, 20);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "https://api.sistemasesco.com/api";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(50, 42);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(291, 20);
            this.txtToken.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "URL";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(103, 599);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(434, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado";
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(364, 9);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(111, 23);
            this.btnCuentas.TabIndex = 5;
            this.btnCuentas.Text = "Obtener Cuentas";
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnValuacion
            // 
            this.btnValuacion.Location = new System.Drawing.Point(485, 9);
            this.btnValuacion.Name = "btnValuacion";
            this.btnValuacion.Size = new System.Drawing.Size(111, 23);
            this.btnValuacion.TabIndex = 13;
            this.btnValuacion.Text = "Obtener Valuacion";
            this.btnValuacion.Click += new System.EventHandler(this.btnValuacion_Click);
            // 
            // dgvValuacion
            // 
            this.dgvValuacion.AllowUserToAddRows = false;
            this.dgvValuacion.AllowUserToDeleteRows = false;
            this.dgvValuacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValuacion.Location = new System.Drawing.Point(0, 3);
            this.dgvValuacion.Name = "dgvValuacion";
            this.dgvValuacion.ReadOnly = true;
            this.dgvValuacion.RowHeadersVisible = false;
            this.dgvValuacion.Size = new System.Drawing.Size(496, 357);
            this.dgvValuacion.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVersion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtToken);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(628, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 77);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(315, 13);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVersion.Size = new System.Drawing.Size(26, 20);
            this.txtVersion.TabIndex = 10;
            this.txtVersion.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Version";
            // 
            // chartValuacion
            // 
            this.chartValuacion.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartValuacion.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartValuacion.Legends.Add(legend1);
            this.chartValuacion.Location = new System.Drawing.Point(523, 45);
            this.chartValuacion.Name = "chartValuacion";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "TpActivos";
            this.chartValuacion.Series.Add(series1);
            this.chartValuacion.Size = new System.Drawing.Size(565, 359);
            this.chartValuacion.TabIndex = 16;
            this.chartValuacion.Text = "Valuacion";
            this.chartValuacion.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chartValuacion_GetTooltipText);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCuentas);
            this.panel1.Controls.Add(this.btnValuacion);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cmbCuentas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 84);
            this.panel1.TabIndex = 17;
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.ItemHeight = 23;
            this.cmbCuentas.Location = new System.Drawing.Point(241, 46);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(356, 29);
            this.cmbCuentas.TabIndex = 22;
            this.cmbCuentas.SelectedIndexChanged += new System.EventHandler(this.cmbCuentas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(198, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cuenta";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metroTabPage1);
            this.tabControl1.Controls.Add(this.metroTabPage8);
            this.tabControl1.Controls.Add(this.metroTabPage2);
            this.tabControl1.Controls.Add(this.metroTabPage4);
            this.tabControl1.Controls.Add(this.metroTabPage7);
            this.tabControl1.Controls.Add(this.metroTabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 5;
            this.tabControl1.Size = new System.Drawing.Size(1096, 444);
            this.tabControl1.TabIndex = 18;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTabControl1);
            this.metroTabPage1.Controls.Add(this.cmbTpActivo);
            this.metroTabPage1.Controls.Add(this.chartValuacion);
            this.metroTabPage1.Controls.Add(this.label14);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Estado de Cuenta";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(507, 399);
            this.metroTabControl1.TabIndex = 24;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage5.Controls.Add(this.dgvValuacion);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(499, 360);
            this.metroTabPage5.TabIndex = 0;
            this.metroTabPage5.Text = "Grilla";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage6.Controls.Add(this.txtJson);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(499, 360);
            this.metroTabPage6.TabIndex = 1;
            this.metroTabPage6.Text = "Json";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(1, 4);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJson.Size = new System.Drawing.Size(498, 356);
            this.txtJson.TabIndex = 2;
            // 
            // cmbTpActivo
            // 
            this.cmbTpActivo.FormattingEnabled = true;
            this.cmbTpActivo.ItemHeight = 23;
            this.cmbTpActivo.Location = new System.Drawing.Point(657, 9);
            this.cmbTpActivo.Name = "cmbTpActivo";
            this.cmbTpActivo.Size = new System.Drawing.Size(289, 29);
            this.cmbTpActivo.TabIndex = 23;
            this.cmbTpActivo.SelectedIndexChanged += new System.EventHandler(this.cmbTpActivo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(575, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tipo de Activo";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dgvOrdenes);
            this.metroTabPage2.Controls.Add(this.groupBox4);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Ordenes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(0, 119);
            this.dgvOrdenes.MultiSelect = false;
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersVisible = false;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(1086, 285);
            this.dgvOrdenes.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dtpFechaDesde);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnConsultarOrdenes);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dtpFechaHasta);
            this.groupBox4.Location = new System.Drawing.Point(3, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 91);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultar Ordenes";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(94, 20);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesde.TabIndex = 16;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 1, 1, 14, 46, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Desde";
            // 
            // btnConsultarOrdenes
            // 
            this.btnConsultarOrdenes.Location = new System.Drawing.Point(137, 55);
            this.btnConsultarOrdenes.Name = "btnConsultarOrdenes";
            this.btnConsultarOrdenes.Size = new System.Drawing.Size(111, 23);
            this.btnConsultarOrdenes.TabIndex = 19;
            this.btnConsultarOrdenes.Text = "Consultar";
            this.btnConsultarOrdenes.Click += new System.EventHandler(this.btnConsultarOrdenes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(292, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaHasta.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnIngresarOrden);
            this.groupBox3.Controls.Add(this.txtPlazo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtMoneda);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtInstrumento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(468, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 91);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alta de Orden";
            // 
            // btnIngresarOrden
            // 
            this.btnIngresarOrden.Location = new System.Drawing.Point(270, 55);
            this.btnIngresarOrden.Name = "btnIngresarOrden";
            this.btnIngresarOrden.Size = new System.Drawing.Size(111, 23);
            this.btnIngresarOrden.TabIndex = 20;
            this.btnIngresarOrden.Text = "Ingresar Orden";
            this.btnIngresarOrden.Click += new System.EventHandler(this.btnIngresarOrden_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(561, 22);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(40, 20);
            this.txtPlazo.TabIndex = 9;
            this.txtPlazo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Plazo";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(462, 22);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(40, 20);
            this.txtMoneda.TabIndex = 7;
            this.txtMoneda.Text = "ARS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Moneda";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(348, 22);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecio.Size = new System.Drawing.Size(40, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "160";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Precio";
            // 
            // txtInstrumento
            // 
            this.txtInstrumento.Location = new System.Drawing.Point(80, 22);
            this.txtInstrumento.Name = "txtInstrumento";
            this.txtInstrumento.Size = new System.Drawing.Size(81, 20);
            this.txtInstrumento.TabIndex = 2;
            this.txtInstrumento.Text = "BMA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Instrumento";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(251, 22);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidad.Size = new System.Drawing.Size(40, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cantidad";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.chkExactMatch);
            this.metroTabPage4.Controls.Add(this.txtInstrumentoSearch);
            this.metroTabPage4.Controls.Add(this.label16);
            this.metroTabPage4.Controls.Add(this.btnCotizaciones);
            this.metroTabPage4.Controls.Add(this.dgvCotizaciones);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Cotizaciones";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // chkExactMatch
            // 
            this.chkExactMatch.AutoSize = true;
            this.chkExactMatch.Location = new System.Drawing.Point(173, 21);
            this.chkExactMatch.Name = "chkExactMatch";
            this.chkExactMatch.Size = new System.Drawing.Size(88, 15);
            this.chkExactMatch.TabIndex = 23;
            this.chkExactMatch.Text = "Exact Match";
            this.chkExactMatch.UseVisualStyleBackColor = true;
            // 
            // txtInstrumentoSearch
            // 
            this.txtInstrumentoSearch.Location = new System.Drawing.Point(67, 18);
            this.txtInstrumentoSearch.Name = "txtInstrumentoSearch";
            this.txtInstrumentoSearch.Size = new System.Drawing.Size(81, 20);
            this.txtInstrumentoSearch.TabIndex = 22;
            this.txtInstrumentoSearch.Text = "AY24";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(0, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Instrumento";
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.Location = new System.Drawing.Point(310, 15);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Size = new System.Drawing.Size(111, 23);
            this.btnCotizaciones.TabIndex = 20;
            this.btnCotizaciones.Text = "Consultar";
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // dgvCotizaciones
            // 
            this.dgvCotizaciones.AllowUserToAddRows = false;
            this.dgvCotizaciones.AllowUserToDeleteRows = false;
            this.dgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizaciones.Location = new System.Drawing.Point(1, 47);
            this.dgvCotizaciones.MultiSelect = false;
            this.dgvCotizaciones.Name = "dgvCotizaciones";
            this.dgvCotizaciones.ReadOnly = true;
            this.dgvCotizaciones.RowHeadersVisible = false;
            this.dgvCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotizaciones.Size = new System.Drawing.Size(1092, 355);
            this.dgvCotizaciones.TabIndex = 14;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.btnConsultarDisponible);
            this.metroTabPage7.Controls.Add(this.dgvDisponible);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage7.TabIndex = 4;
            this.metroTabPage7.Text = "Disponible para Operar";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            // 
            // btnConsultarDisponible
            // 
            this.btnConsultarDisponible.Location = new System.Drawing.Point(1, 20);
            this.btnConsultarDisponible.Name = "btnConsultarDisponible";
            this.btnConsultarDisponible.Size = new System.Drawing.Size(111, 23);
            this.btnConsultarDisponible.TabIndex = 24;
            this.btnConsultarDisponible.Text = "Consultar";
            this.btnConsultarDisponible.Click += new System.EventHandler(this.btnConsultarDisponible_Click);
            // 
            // dgvDisponible
            // 
            this.dgvDisponible.AllowUserToAddRows = false;
            this.dgvDisponible.AllowUserToDeleteRows = false;
            this.dgvDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponible.Location = new System.Drawing.Point(1, 60);
            this.dgvDisponible.MultiSelect = false;
            this.dgvDisponible.Name = "dgvDisponible";
            this.dgvDisponible.ReadOnly = true;
            this.dgvDisponible.RowHeadersVisible = false;
            this.dgvDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponible.Size = new System.Drawing.Size(1086, 342);
            this.dgvDisponible.TabIndex = 23;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.dgvSolicitudesFCI);
            this.metroTabPage3.Controls.Add(this.groupBox5);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Solicitudes FCI";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // dgvSolicitudesFCI
            // 
            this.dgvSolicitudesFCI.AllowUserToAddRows = false;
            this.dgvSolicitudesFCI.AllowUserToDeleteRows = false;
            this.dgvSolicitudesFCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesFCI.Location = new System.Drawing.Point(0, 119);
            this.dgvSolicitudesFCI.MultiSelect = false;
            this.dgvSolicitudesFCI.Name = "dgvSolicitudesFCI";
            this.dgvSolicitudesFCI.ReadOnly = true;
            this.dgvSolicitudesFCI.RowHeadersVisible = false;
            this.dgvSolicitudesFCI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudesFCI.Size = new System.Drawing.Size(1086, 285);
            this.dgvSolicitudesFCI.TabIndex = 22;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.chkConcertacion);
            this.groupBox5.Controls.Add(this.dtpFechaDesdeFCI);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.btnConsultarFCI);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.dtpFechaHastaFCI);
            this.groupBox5.Location = new System.Drawing.Point(3, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 91);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consultar Ordenes";
            // 
            // chkConcertacion
            // 
            this.chkConcertacion.AutoSize = true;
            this.chkConcertacion.Checked = true;
            this.chkConcertacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConcertacion.Location = new System.Drawing.Point(415, 24);
            this.chkConcertacion.Name = "chkConcertacion";
            this.chkConcertacion.Size = new System.Drawing.Size(115, 15);
            this.chkConcertacion.TabIndex = 20;
            this.chkConcertacion.Text = "Por Concertacion";
            this.chkConcertacion.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDesdeFCI
            // 
            this.dtpFechaDesdeFCI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeFCI.Location = new System.Drawing.Point(94, 20);
            this.dtpFechaDesdeFCI.Name = "dtpFechaDesdeFCI";
            this.dtpFechaDesdeFCI.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesdeFCI.TabIndex = 16;
            this.dtpFechaDesdeFCI.Value = new System.DateTime(2020, 1, 1, 14, 46, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Fecha Desde";
            // 
            // btnConsultarFCI
            // 
            this.btnConsultarFCI.Location = new System.Drawing.Point(215, 56);
            this.btnConsultarFCI.Name = "btnConsultarFCI";
            this.btnConsultarFCI.Size = new System.Drawing.Size(111, 23);
            this.btnConsultarFCI.TabIndex = 19;
            this.btnConsultarFCI.Text = "Consultar";
            this.btnConsultarFCI.Click += new System.EventHandler(this.btnConsultarFCI_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Fecha Hasta";
            // 
            // dtpFechaHastaFCI
            // 
            this.dtpFechaHastaFCI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaFCI.Location = new System.Drawing.Point(292, 19);
            this.dtpFechaHastaFCI.Name = "dtpFechaHastaFCI";
            this.dtpFechaHastaFCI.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaHastaFCI.TabIndex = 18;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.Controls.Add(this.btnConsultarRecibos);
            this.metroTabPage8.Controls.Add(this.dgvRecibos);
            this.metroTabPage8.Controls.Add(this.groupBox6);
            this.metroTabPage8.Controls.Add(this.dgvCuentasBancarias);
            this.metroTabPage8.Controls.Add(this.btnTraerCuentasBancarias);
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(1088, 405);
            this.metroTabPage8.TabIndex = 5;
            this.metroTabPage8.Text = "Cash In";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            // 
            // btnConsultarRecibos
            // 
            this.btnConsultarRecibos.Location = new System.Drawing.Point(3, 153);
            this.btnConsultarRecibos.Name = "btnConsultarRecibos";
            this.btnConsultarRecibos.Size = new System.Drawing.Size(111, 23);
            this.btnConsultarRecibos.TabIndex = 26;
            this.btnConsultarRecibos.Text = "Consultar Recibos";
            this.btnConsultarRecibos.Click += new System.EventHandler(this.btnConsultarRecibos_Click);
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 182);
            this.dgvRecibos.MultiSelect = false;
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(1082, 220);
            this.dgvRecibos.TabIndex = 25;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.txtCuentaBancariaComitente);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.txtCuentaAgente);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.metroTextBox2);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.btnInsertRecibo);
            this.groupBox6.Controls.Add(this.txtImporteRecibo);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Location = new System.Drawing.Point(468, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(617, 91);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alta de Recibo";
            // 
            // txtCuentaBancariaComitente
            // 
            this.txtCuentaBancariaComitente.Location = new System.Drawing.Point(541, 25);
            this.txtCuentaBancariaComitente.Name = "txtCuentaBancariaComitente";
            this.txtCuentaBancariaComitente.Size = new System.Drawing.Size(40, 20);
            this.txtCuentaBancariaComitente.TabIndex = 23;
            this.txtCuentaBancariaComitente.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(449, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Cuenta Bancaria";
            // 
            // txtCuentaAgente
            // 
            this.txtCuentaAgente.Location = new System.Drawing.Point(376, 25);
            this.txtCuentaAgente.Name = "txtCuentaAgente";
            this.txtCuentaAgente.Size = new System.Drawing.Size(40, 20);
            this.txtCuentaAgente.TabIndex = 9;
            this.txtCuentaAgente.Text = "229";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(292, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Cuenta Agente";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(206, 25);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(40, 20);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.Text = "ARS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(155, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Moneda";
            // 
            // btnInsertRecibo
            // 
            this.btnInsertRecibo.Location = new System.Drawing.Point(259, 62);
            this.btnInsertRecibo.Name = "btnInsertRecibo";
            this.btnInsertRecibo.Size = new System.Drawing.Size(111, 23);
            this.btnInsertRecibo.TabIndex = 21;
            this.btnInsertRecibo.Text = "Ingresar Recibo";
            this.btnInsertRecibo.Click += new System.EventHandler(this.btnInsertRecibo_Click);
            // 
            // txtImporteRecibo
            // 
            this.txtImporteRecibo.Location = new System.Drawing.Point(82, 25);
            this.txtImporteRecibo.Name = "txtImporteRecibo";
            this.txtImporteRecibo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImporteRecibo.Size = new System.Drawing.Size(40, 20);
            this.txtImporteRecibo.TabIndex = 3;
            this.txtImporteRecibo.Text = "1000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Importe";
            // 
            // dgvCuentasBancarias
            // 
            this.dgvCuentasBancarias.AllowUserToAddRows = false;
            this.dgvCuentasBancarias.AllowUserToDeleteRows = false;
            this.dgvCuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasBancarias.Location = new System.Drawing.Point(0, 43);
            this.dgvCuentasBancarias.MultiSelect = false;
            this.dgvCuentasBancarias.Name = "dgvCuentasBancarias";
            this.dgvCuentasBancarias.ReadOnly = true;
            this.dgvCuentasBancarias.RowHeadersVisible = false;
            this.dgvCuentasBancarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasBancarias.Size = new System.Drawing.Size(457, 86);
            this.dgvCuentasBancarias.TabIndex = 23;
            // 
            // btnTraerCuentasBancarias
            // 
            this.btnTraerCuentasBancarias.Location = new System.Drawing.Point(0, 14);
            this.btnTraerCuentasBancarias.Name = "btnTraerCuentasBancarias";
            this.btnTraerCuentasBancarias.Size = new System.Drawing.Size(214, 23);
            this.btnTraerCuentasBancarias.TabIndex = 22;
            this.btnTraerCuentasBancarias.Text = "Consultar Cuentas Bancarias";
            this.btnTraerCuentasBancarias.Click += new System.EventHandler(this.btnTraerCuentasBancarias_Click);
            // 
            // chkOData
            // 
            this.chkOData.AutoSize = true;
            this.chkOData.Location = new System.Drawing.Point(560, 602);
            this.chkOData.Name = "chkOData";
            this.chkOData.Size = new System.Drawing.Size(97, 15);
            this.chkOData.TabIndex = 24;
            this.chkOData.Text = "Filtrar ODData";
            this.chkOData.UseVisualStyleBackColor = true;
            // 
            // txtOData
            // 
            this.txtOData.Location = new System.Drawing.Point(663, 599);
            this.txtOData.Name = "txtOData";
            this.txtOData.Size = new System.Drawing.Size(444, 20);
            this.txtOData.TabIndex = 25;
            this.txtOData.Text = "?$select=valuacion,tpActivo,abreviatura&$filter=grupo eq \'MON\'";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscoApiTest.Properties.Resources.ESCO_Wall;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOData);
            this.Controls.Add(this.chkOData);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstado);
            this.Name = "frmTest";
            this.Text = "EscoApi - Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValuacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValuacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
            this.metroTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesFCI)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.metroTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasBancarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroTextBox txtUser;
        private MetroTextBox txtClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroTextBox txtUrl;
        private MetroTextBox txtToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroTextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvValuacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValuacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroTextBox txtPlazo;
        private System.Windows.Forms.Label label13;
        private MetroTextBox txtMoneda;
        private System.Windows.Forms.Label label12;
        private MetroTextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private MetroTextBox txtInstrumento;
        private System.Windows.Forms.Label label9;
        private MetroTextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private MetroTabControl tabControl1;
        private MetroButton btnLogin;
        private MetroButton btnCuentas;
        private MetroButton btnValuacion;
        private MetroButton btnConsultarOrdenes;
        private MetroButton btnIngresarOrden;
        private MetroComboBox cmbCuentas;
        private MetroTabPage metroTabPage1;
        private MetroTabPage metroTabPage2;
        private MetroComboBox cmbTpActivo;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroTabPage metroTabPage3;
        private MetroTabPage metroTabPage4;
        private MetroButton btnCotizaciones;
        private System.Windows.Forms.DataGridView dgvCotizaciones;
        private MetroTabControl metroTabControl1;
        private MetroTabPage metroTabPage5;
        private MetroTabPage metroTabPage6;
        private MetroTextBox txtJson;
        private MetroTextBox txtVersion;
        private System.Windows.Forms.Label label15;
        private MetroTextBox txtInstrumentoSearch;
        private System.Windows.Forms.Label label16;
        private MetroCheckBox chkExactMatch;
        private MetroCheckBox chkOData;
        private MetroTextBox txtOData;
        private System.Windows.Forms.DataGridView dgvSolicitudesFCI;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeFCI;
        private System.Windows.Forms.Label label17;
        private MetroButton btnConsultarFCI;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaFCI;
        private MetroCheckBox chkConcertacion;
        private MetroTabPage metroTabPage7;
        private MetroButton btnConsultarDisponible;
        private System.Windows.Forms.DataGridView dgvDisponible;
        private MetroTabPage metroTabPage8;
        private MetroButton btnInsertRecibo;
        private System.Windows.Forms.DataGridView dgvCuentasBancarias;
        private MetroButton btnTraerCuentasBancarias;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroTextBox txtCuentaBancariaComitente;
        private System.Windows.Forms.Label label21;
        private MetroTextBox txtCuentaAgente;
        private System.Windows.Forms.Label label19;
        private MetroTextBox metroTextBox2;
        private System.Windows.Forms.Label label20;
        private MetroTextBox txtImporteRecibo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroButton btnConsultarRecibos;
        private System.Windows.Forms.DataGridView dgvRecibos;
    }
}

