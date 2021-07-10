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
            txtInformacion.ReadOnly = true;
            txtArchivoGuardado.ReadOnly = true;

            Hilos.actualizarInfo += ActualizarTexto;
            Hilos.actualizarInfo += GenerarBackups;
            Hilos.actualizarInfo += EliminarZips;

            hilo = new Thread(Hilos.Comenzar);

            hilo.Start();
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

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            int id;
            bool PCoNotebook = false;

            FrmBorrarProducto formBorrarProducto = new FrmBorrarProducto();
            formBorrarProducto.ShowDialog();
            this.btnBorrarProducto.Enabled = false;


            int.TryParse(formBorrarProducto.txbID.Text, out id);


            if(formBorrarProducto.rdbNotebook.Checked)
            {
                PCoNotebook = false;
            }
            else if(formBorrarProducto.rdbPCEscritorio.Checked)
            {
                PCoNotebook = true;
            }

            if(this.ProductoDAO.BorrarProducto(id, PCoNotebook))
            {
                MessageBox.Show("Producto borrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (id != -1)
                {
                    MessageBox.Show("No hay producto con ese ID", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            btnBorrarProducto.Enabled = true;
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            //Guardado de datos en un .txt
            try
            {
                Producto.Guardar();
                MessageBox.Show("Archivo guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArchivoGuardado.Text = Producto.Leer();
            }
            catch (ArchivosExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        private void GenerarBackups()
        {
            ArchivosXml.GenerarBackup();
        }

        private void EliminarZips()
        {
            ArchivosXml.EliminarZip();
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
