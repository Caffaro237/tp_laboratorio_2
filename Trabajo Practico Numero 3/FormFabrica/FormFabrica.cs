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
    public partial class FrmFabrica : Form
    {
        public FrmFabrica()
        {
            InitializeComponent();
        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductos = new List<Producto>();
        }

        private void btnFrmNotebook_Click(object sender, EventArgs e)
        {
            FrmNotebooks formNotebooks = new FrmNotebooks();
            formNotebooks.ShowDialog();
        }

        private void btnFormPCEscritorio_Click(object sender, EventArgs e)
        {
            FrmPCEscritorio formPCEscritorio = new FrmPCEscritorio();
            formPCEscritorio.ShowDialog();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            //Guardado de datos en un .txt
            try
            {
                Producto.Guardar();
                MessageBox.Show("Archivo guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArchivosExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            rtbInformacion.Text = Producto.Leer();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmFabrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro?",
                "Cerrando Fabrica",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
