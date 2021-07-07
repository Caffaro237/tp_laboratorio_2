using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFabrica
{
    public partial class FrmFabrica : Form
    {
        List<Producto> listaProductosDAO;
        ProductoDAO ProductoDAO;
        bool pcEscritorio = true;
        bool notebook = false;
        private static Thread hilo;

        public FrmFabrica()
        {
            InitializeComponent();
            ProductoDAO = new ProductoDAO();
            listaProductosDAO = new List<Producto>();
            hilo = null;
        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            Hilos.actualizarInfo += ActualizarTexto;

            hilo = new Thread(Hilos.Comenzar);

            hilo.Start();


        }

        private void btnFrmNotebook_Click(object sender, EventArgs e)
        {
            this.InsertarProducto(EnumMarcas.Acer.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120, notebook);

            

            //FrmNotebooks formNotebooks = new FrmNotebooks();
            //formNotebooks.ShowDialog();
        }

        private void btnFormPCEscritorio_Click(object sender, EventArgs e)
        {
            //this.InsertarProducto(EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.GTX1080.ToString(), 8, 500, 0, 0, pcEscritorio);

            this.ProductoDAO.BorrarProducto(16, notebook);

            //FrmPCEscritorio formPCEscritorio = new FrmPCEscritorio();
            //formPCEscritorio.ShowDialog();
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
            hilo.Abort();
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
            else
            {
                hilo.Abort();
            }
        }

        public void MostrarInformacion()
        {
            try
            {
                this.listaProductosDAO = this.ProductoDAO.EnlistadorProductos();

                StringBuilder sb = new StringBuilder();

                foreach (Producto p in listaProductosDAO)
                {
                    if (p is Notebook)
                    {
                        sb.AppendLine("****** NOTEBOOK ******");
                        sb.AppendLine(p.ToString());
                    }
                    else if (p is PCEscritorio)
                    {
                        sb.AppendLine("****** PC ESCRITORIO ******");
                        sb.AppendLine(p.ToString());
                    }
                }

                txtInformacion.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertarProducto(string marca, string CPU, string GPU, int RAM, int almacenamiento, double pulgadas, int hertz, bool PCoNotebook)
        {
            try
            {
                if(PCoNotebook)
                {
                    this.ProductoDAO.InsertPCEscritorio(marca, CPU, GPU, RAM, almacenamiento);
                }
                else
                {
                    this.ProductoDAO.InsertNotebook(marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarTexto()
        {
            if (this.txtInformacion.InvokeRequired)
            {
                ActualizarInformacion delegado = new ActualizarInformacion(this.ActualizarTexto);
                this.txtInformacion.Invoke(delegado);
            }
            else
            {
                this.MostrarInformacion();
            }
        }
    }
}
