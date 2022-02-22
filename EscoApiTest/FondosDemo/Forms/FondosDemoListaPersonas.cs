using EscoApiTest.FondosDemo.Models;
using EscoApiTest.FondosDemo.Models.Requests;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscoApiTest.FondosDemo.Forms
{
    public partial class frmFondosDemoListaPersonas : MetroFramework.Forms.MetroForm
    {
        #region "Eventos"
        public frmFondosDemoListaPersonas(List<PersonaInsertRequestMinimo> personas)
        {
            InitializeComponent();
            CenterToScreen();

            ClearGrid(dgvPersonasEnLista);
            SetGrid(dgvPersonasEnLista, personas);
        }

        #endregion

        #region Setear Objetos
        private void SetGrid<T>(DataGridView grilla, List<T> source)
        {
            grilla.DataSource = source;
            grilla.Refresh();
        }

        private void ClearGrid(DataGridView grilla)
        {
            grilla.DataSource = null;
            grilla.Refresh();
        }
        #endregion
    }

}
