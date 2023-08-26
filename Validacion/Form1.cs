using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (rbtFormatoViejo.Checked)
            {
                mtbPatenteVieja.Enabled = true;
                mtbPatenteNueva.Enabled = false;
            }
        }

        //boton patente
        private void btnIngresarPatente_Click(object sender, EventArgs e)
        {
            if (rbtFormatoViejo.Checked)
            {
                if (mtbPatenteVieja.Text.Length < 6)
                {
                    MessageBox.Show("Complete la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                lblPatenteResultado.Text = mtbPatenteVieja.Text.Substring(0, 3).ToUpper() + " " + mtbPatenteVieja.Text.Substring(3, 3);
            }
            else
            {
                if (mtbPatenteNueva.Text.Length < 7)
                {
                    MessageBox.Show("Complete la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                lblPatenteResultado.Text = mtbPatenteNueva.Text.Substring(0, 2).ToUpper() + " " + mtbPatenteNueva.Text.Substring(2, 3) + " " + mtbPatenteNueva.Text.Substring(5, 2).ToUpper();
            }
        }

        //boton CUIT
        private void btnIngresarCuit_Click(object sender, EventArgs e)
        {
            if (mtbCuit.Text.Length < 11)
            {
                MessageBox.Show("Complete el CUIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lblCuitResultado.Text = mtbCuit.Text.Substring(0, 2) + "-" + mtbCuit.Text.Substring(2, 8) + "-" + mtbCuit.Text.Substring(10, 1);
            lblDniResultado.Text = mtbCuit.Text.Substring(2, 8);
        }

        //método para cambiar el formato de la patente
        private void rbtFormatoNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFormatoViejo.Checked)
            {
                mtbPatenteVieja.Enabled = true;
                mtbPatenteNueva.Enabled = false;
                mtbPatenteNueva.Clear();
                mtbPatenteVieja.Clear();
                lblPatenteResultado.Text = "";
            }
            else
            {
                mtbPatenteNueva.Enabled = true;
                mtbPatenteVieja.Enabled = false;
                mtbPatenteNueva.Clear();
                mtbPatenteVieja.Clear();
                lblPatenteResultado.Text = "";
            }

        }

        //Validaciones para respetar formatos de las patentes y el CUIT
        private void mtbPatenteVieja_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Formato ingresado incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void mtbPatenteNueva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Formato ingresado incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void mtbCuit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Formato ingresado incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
    }
}
