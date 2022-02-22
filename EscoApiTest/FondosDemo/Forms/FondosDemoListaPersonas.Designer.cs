using MetroFramework.Controls;

namespace EscoApiTest.FondosDemo.Forms
{
    partial class frmFondosDemoListaPersonas
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
            this.dgvPersonasEnLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEnLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonasEnLista
            // 
            this.dgvPersonasEnLista.AllowUserToAddRows = false;
            this.dgvPersonasEnLista.AllowUserToDeleteRows = false;
            this.dgvPersonasEnLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasEnLista.Location = new System.Drawing.Point(9, 63);
            this.dgvPersonasEnLista.Name = "dgvPersonasEnLista";
            this.dgvPersonasEnLista.ReadOnly = true;
            this.dgvPersonasEnLista.RowHeadersVisible = false;
            this.dgvPersonasEnLista.Size = new System.Drawing.Size(824, 372);
            this.dgvPersonasEnLista.TabIndex = 15;
            // 
            // frmFondosDemoListaPersonas
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 461);
            this.Controls.Add(this.dgvPersonasEnLista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFondosDemoListaPersonas";
            this.ShowInTaskbar = false;
            this.Text = "Lista de condóminos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEnLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonasEnLista;
    }
}

