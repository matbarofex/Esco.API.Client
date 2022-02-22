using EscoApiTest.FondosDemo.Forms;
using EscoApiTest.helpers;
using EscoApiTest.models.generic;
using System;
using System.Collections.Generic;

namespace EscoApiTest
{
    public enum Systems
    {
        Bolsa,
        Fondos
    }

    public partial class frmDemoPpal : MetroFramework.Forms.MetroForm
    {
        public frmDemoPpal()
        {
            InitializeComponent();

            LoadSystemsComboBox();
        }

        private void Form_Load(object sender, EventArgs e)
        {            
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (cmb_Sistema.SelectedValue?.ToString() == Systems.Bolsa.ToString())
            {
                frmTest bolsaForm = new frmTest();
                bolsaForm.ShowDialog();
            }

            if (cmb_Sistema.SelectedValue?.ToString() == Systems.Fondos.ToString())
            {
                frmFondosDemo fondosForm = new frmFondosDemo();
                fondosForm.ShowDialog();

            }
        }

        private void LoadSystemsComboBox()
        {
            List<SystemToTry> systems = new List<SystemToTry>()
            {
                new SystemToTry()
                {
                     Id = Systems.Bolsa.ToString(),
                     Name = Systems.Bolsa.ToString()
                },
                new SystemToTry()
                {
                    Id = Systems.Fondos.ToString(),
                    Name = Systems.Fondos.ToString()
                }
            };

            CommonHelper.SetComboBox(cmb_Sistema, systems, "Id", "Name");
        }
    }
}
