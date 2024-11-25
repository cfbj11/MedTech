using MedTech.Dao;
using MedTech.Servicio;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTech.Formularios
{
    public partial class ExpedienteFrm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForm accForms;
        private readonly GuardarExpediente guardarExpediente;
        private bool flag = true;

        public ExpedienteFrm()
        {
            InitializeComponent();
            accForms = new AccForm(this);
            guardarExpediente = new GuardarExpediente("Expedientes.txt");
            lblInstruccion.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            accForms.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accForms.Cancelar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            accForms.Volver(ref flag);
        }

        private void ExpedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
