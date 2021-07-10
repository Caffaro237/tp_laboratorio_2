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
        #region Atributos

        List<Producto> listaProductosDAO;
        ProductoDAO ProductoDAO;
        private static Thread hilo;

        #endregion

        #region Costructor

        public FrmFabrica()
        {
            InitializeComponent();
            ProductoDAO = new ProductoDAO();
            listaProductosDAO = new List<Producto>();
            hilo = null;
        }

        #endregion

        #region Eventos

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            txtInformacion.ReadOnly = true;
            txtArchivoGuardado.ReadOnly = true;

            //Secuencia que hara el hilo secundario
            Hilos.actualizarInfo += ActualizarTexto;
            Hilos.actualizarInfo += GenerarBackups;
            Hilos.actualizarInfo += EliminarZips;

            hilo = new Thread(Hilos.Comenzar);

            hilo.Start();
        }

        /// <summary>
        /// Boton que llamara al formulario para agregar una Notebook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmNotebook_Click(object sender, EventArgs e)
        {
            FrmNotebooks formNotebooks = new FrmNotebooks();
            formNotebooks.ShowDialog();
        }

        /// <summary>
        /// Boton que llamara al formulario para agregar una PC de Escritorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormPCEscritorio_Click(object sender, EventArgs e)
        {
            FrmPCEscritorio formPCEscritorio = new FrmPCEscritorio();
            formPCEscritorio.ShowDialog();
        }


        /// <summary>
        /// Boton que llamara al formulario para borrar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Boton que guardara y mostrara el archivo en el segundo cuadro de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Boton que cerrara el formulario sin preguntar si desea o no cerrar
        /// Deteniendo el hilo secundario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

            //Finalizacion del hilo secundario
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
                //Finalizacion del hilo secundario
                hilo.Abort();
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que mostrara la lista de productos en el cuadro de texto
        /// </summary>
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

        /// <summary>
        /// Metodo usado para el hilo secundario
        /// que invocara a GenerarBackup de la clase Archivo.cs
        /// </summary>
        private void GenerarBackups()
        {
            ArchivosXml.GenerarBackup();
        }

        /// <summary>
        /// Metodo usado para el hilo secundario
        /// que invocara a EiminarZip de la clase Archivo.cs
        /// </summary>
        private void EliminarZips()
        {
            ArchivosXml.EliminarZip();
        }

        /// <summary>
        /// Metodo usado para el hilo secundario
        /// usando delegado invocara a MostrarInformacion
        /// </summary>
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

        #endregion

    }
}
