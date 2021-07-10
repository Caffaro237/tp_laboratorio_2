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
    public partial class FrmNotebooks : Form
    {
        #region Atributo 

        ProductoDAO ProductoDAO;

        #endregion

        #region Constructor

        public FrmNotebooks()
        {
            InitializeComponent();
            ProductoDAO = new ProductoDAO();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento load que cargara en los ComboBox los datos de los enumerados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNotebooks_Load(object sender, EventArgs e)
        {
            cmbMarcas.DataSource = Enum.GetValues(typeof(EnumMarcas));
            cmbCPU.DataSource = Enum.GetValues(typeof(EnumCPU));
            cmbGPU.DataSource = Enum.GetValues(typeof(EnumGPU));
        }

        /// <summary>
        /// Boton que cancela el agregado del producto y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarNotebooks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boton que agrega una notebook a la base de datos
        /// Validando que los campos no esten vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarNotebook_Click(object sender, EventArgs e)
        {
            if(cmbMarcas.Text == string.Empty || cmbCPU.Text == string.Empty || cmbGPU.Text == string.Empty || RAM() == 0 || Almacenamiento() == 0 || Pulgadas() == 0 || HzPantalla() == 0)
            {
                MessageBox.Show("Datos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ProductoDAO.InsertNotebook(cmbMarcas.Text, cmbCPU.Text, cmbGPU.Text, RAM(), Almacenamiento(), Pulgadas(), HzPantalla());

                this.Close();
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que seleccionara la RAM que este chequeada
        /// </summary>
        /// <returns> Retornara el valor del radioButton que este chequeado </returns>
        private int RAM()
        {
            if(rdb8GB.Checked)
            {
                return int.Parse(rdb8GB.Text);
            }
            else if (rdb16GB.Checked)
            {
                return int.Parse(rdb16GB.Text);
            }
            else if (rdb32GB.Checked)
            {
                return int.Parse(rdb32GB.Text);
            }
            else if (rdb64GB.Checked)
            {
                return int.Parse(rdb64GB.Text);
            }

            return 0;
        }

        /// <summary>
        /// Metodo que seleccionara el Almacenamiento que este chequeado
        /// </summary>
        /// <returns> Retornara el valor del radioButton que este chequeado </returns>
        private int Almacenamiento()
        {
            if (rdb240GB.Checked)
            {
                return int.Parse(rdb240GB.Text);
            }
            else if (rdb500GB.Checked)
            {
                return int.Parse(rdb500GB.Text);
            }
            else if (rdb1000GB.Checked)
            {
                return int.Parse(rdb1000GB.Text);
            }
            else if (rdb4000GB.Checked)
            {
                return int.Parse(rdb4000GB.Text);
            }

            return 0;
        }

        /// <summary>
        /// Metodo que seleccionara ls pulgadas que este chequeada
        /// </summary>
        /// <returns> Retornara el valor del radioButton que este chequeado </returns>
        private double Pulgadas()
        {
            if (rdb14Pulgadas.Checked)
            {
                return double.Parse(rdb14Pulgadas.Text);
            }
            else if (rdb15Pulgadas.Checked)
            {
                return double.Parse(rdb15Pulgadas.Text);
            }
            else if (rdb17Pulgadas.Checked)
            {
                return double.Parse(rdb17Pulgadas.Text);
            }

            return 0;
        }

        /// <summary>
        /// Metodo que seleccionara los Hertz que este chequeado
        /// </summary>
        /// <returns> Retornara el valor del radioButton que este chequeado </returns>
        private int HzPantalla()
        {
            if (rdb60hz.Checked)
            {
                return int.Parse(rdb60hz.Text);
            }
            else if(rdb120hz.Checked)
            {
                return int.Parse(rdb120hz.Text);
            }
            else if (rdb144hz.Checked)
            {
                return int.Parse(rdb144hz.Text);
            }
            else if (rdb240hz.Checked)
            {
                return int.Parse(rdb240hz.Text);
            }

            return 0;
        }

        #endregion

    }
}
