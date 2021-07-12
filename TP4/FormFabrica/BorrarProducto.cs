using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFabrica
{
    public partial class FrmBorrarProducto : Form
    {
        #region Constructor

        public FrmBorrarProducto()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if(this.txbID.Text == "")
            {
                this.txbID.Text = "-1";
            }

            this.Close();
        }

        private void FrmBorrarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ActiveControl.Text != "Aceptar")
            {
                this.txbID.Text = "-1";
            }
        }

        /// <summary>
        /// Evento que dara error cuando se presione una tecla que no sea un numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
