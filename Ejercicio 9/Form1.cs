using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class frmCambio : Form
    {
        public frmCambio()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text)||string.IsNullOrEmpty(txtDinero.Text))
            {
                lblError.Text = "Por favor, ingrese ambos valores.";
            }
            else {
                if (double.TryParse(txtMonto.Text, out double monto) && double.TryParse(txtDinero.Text, out double dinero))
                {
                    if ((dinero < monto)&&(monto>0&&dinero>0))
                    {
                        lblError.Text = "El dinero ingresado es insuficiente para cubrir el monto.";
                    }
                    else
                    {
                        double cambio = dinero - monto;
                        txtCambio.Text = cambio.ToString("F2");
                        lblError.Text = string.Empty;
                        txtDinero.ReadOnly = true;
                        txtMonto.ReadOnly = true;
                    }
                }
                else
                {
                    lblError.Text = "Por favor, ingrese valores numéricos válidos.";
                }
            }
        }
        private void btnNuevoCalculo_Click(object sender, EventArgs e)
        {
            txtCambio.Clear();
            txtDinero.Clear();
            txtMonto.Clear();
            txtDinero.ReadOnly = false;
            txtMonto.ReadOnly = false;
            lblError.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCambio_Load(object sender, EventArgs e)
        {

        }
    }
}
