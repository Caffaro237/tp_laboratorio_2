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
    public partial class FrmPCEscritorio : Form
    {
        public FrmPCEscritorio()
        {
            InitializeComponent();
        }

        private void FrmPCEscritorio_Load(object sender, EventArgs e)
        {
            cmbMarcas.DataSource = Enum.GetValues(typeof(EnumMarcas));
            cmbCPU.DataSource = Enum.GetValues(typeof(EnumCPU));
            cmbGPU.DataSource = Enum.GetValues(typeof(EnumGPU));
        }

        private void btnCancelarPCEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPCEscritorio_Click(object sender, EventArgs e)
        {
            if (cmbMarcas.Text == string.Empty || cmbCPU.Text == string.Empty || cmbGPU.Text == string.Empty || RAM() == 0 || Almacenamiento() == 0)
            {
                MessageBox.Show("Datos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fabrica.Producto = new PCEscritorio(1, cmbMarcas.Text, cmbCPU.Text, cmbGPU.Text, RAM(), Almacenamiento());

                this.Close();
            }
        }

        private int RAM()
        {
            if (rdb8GB.Checked)
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

    }
}
