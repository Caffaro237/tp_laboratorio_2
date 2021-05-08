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

namespace MiCalculadora
{
    public partial class FrmMiCalculadora : Form
    {
        #region Metodos

        public FrmMiCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "Resultado";
        }

        private static double Operar(string strNumero1, string strNumero2, string operador)
        {
            Numero numero1 = new Numero(strNumero1);
            Numero numero2 = new Numero(strNumero2);

            return Calculadora.Operar(numero1, numero2, operador);
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento de carga del Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMiCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento de cierre del Formulario preguntando si se quiere cerrar o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMiCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro?", 
                "Cerrando Calculadora", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Botones

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double respuesta = 0;

            respuesta = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            this.lblResultado.Text = respuesta.ToString();
        }


        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();

            this.lblResultado.Text = numero1.DecimalBinario(this.lblResultado.Text);
        }
        

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();

            this.lblResultado.Text = numero1.BinarioDecimal(this.lblResultado.Text);
        }

        #endregion

        #region TextBox error letras

        /// <summary>
        /// Verifica que no se ingresen letras para que el programa no de error
        /// Tambien se verifico que solo se pueda ingresar un solo . para los numeros con decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                foreach (char item in this.txtNumero1.Text)
                {
                    if(item == '.')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else if (e.KeyChar.ToString().Equals("-"))
            {
                foreach (char item in this.txtNumero1.Text)
                {
                    if (item == '-')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros o numeros decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verifica que no se ingresen letras para que el programa no de error
        /// Tambien se verifico que solo se pueda ingresar un solo . para los numeros con decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                foreach (char item in this.txtNumero2.Text)
                {
                    if (item == '.')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else if (e.KeyChar.ToString().Equals("-"))
            {
                foreach (char item in this.txtNumero2.Text)
                {
                    if (item == '-')
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se puede ingresar un solo menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
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
