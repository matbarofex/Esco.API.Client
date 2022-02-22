using MetroFramework.Controls;

namespace EscoApiTest
{
    partial class frmDemoPpal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Sistema = new MetroFramework.Controls.MetroComboBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Sistema
            // 
            this.cmb_Sistema.FormattingEnabled = true;
            this.cmb_Sistema.ItemHeight = 23;
            this.cmb_Sistema.Location = new System.Drawing.Point(110, 92);
            this.cmb_Sistema.Name = "cmb_Sistema";
            this.cmb_Sistema.Size = new System.Drawing.Size(121, 29);
            this.cmb_Sistema.TabIndex = 0;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(125, 162);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(81, 31);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Abrir";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // frmDemoPpal
            // 
            this.ClientSize = new System.Drawing.Size(354, 237);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.cmb_Sistema);
            this.Name = "frmDemoPpal";
            this.Text = "Seleccione qué desea probar";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroComboBox cmb_Sistema;
        private System.Windows.Forms.Button btn_Open;
    }
}

