using MetroFramework.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscoApiTest.helpers
{
    public static class CommonHelper
    {
        public static void SetComboBox<T>(MetroComboBox cmbBox, List<T> source, string valueMember, string displayMember)
        {
            cmbBox.DataSource = null;
            cmbBox.ValueMember = valueMember;
            cmbBox.DisplayMember = displayMember;
            cmbBox.DataSource = source;
            if (source.Count > 0)
                cmbBox.SelectedIndex = 0;
        }

        public static void ClearComboBox(MetroComboBox cmbBox) =>
            cmbBox.DataSource = null;
    
        public static void SetGrid<T>(DataGridView grilla, List<T> source)
        {
            grilla.DataSource = source;
            grilla.Refresh();
        }

        public static void ClearGrid(DataGridView grilla)
        {
            grilla.DataSource = null;
            grilla.Refresh();
        }
    }
}
