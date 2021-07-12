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

        public List<Producto> listaProductosDAO;
        private ProductoDAO ProductoDAO;
        private static Thread hilo;
        private int cantidadMaximaProductos;

        #endregion

        #region Costructor

        public FrmFabrica()
        {
            InitializeComponent();

            ProductoDAO = new ProductoDAO();
            listaProductosDAO = new List<Producto>();

            hilo = null;

            cantidadMaximaProductos = 10;
        }

        #endregion

        #region Eventos

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            txtInformacion.ReadOnly = true;
            txtArchivoGuardado.ReadOnly = true;

            txtArchivoGuardado.Text = "Apriete el boton Mostrar Archivo para visualizarlo aqui";

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
            if(this.listaProductosDAO.Count <= this.cantidadMaximaProductos)
            {
                FrmNotebooks formNotebooks = new FrmNotebooks();
                formNotebooks.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pueden agregar mas productos, deposito lleno");
            }
        }

        /// <summary>
        /// Boton que llamara al formulario para agregar una PC de Escritorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormPCEscritorio_Click(object sender, EventArgs e)
        {
            if (this.listaProductosDAO.Count <= this.cantidadMaximaProductos)
            {
                FrmPCEscritorio formPCEscritorio = new FrmPCEscritorio();
                formPCEscritorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pueden agregar mas productos, deposito lleno");
            }
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
            bool noHayId = false;

            Type tipo = typeof(Notebook);
            
            FrmBorrarProducto formBorrarProducto = new FrmBorrarProducto();
            formBorrarProducto.ShowDialog();

            int.TryParse(formBorrarProducto.txbID.Text, out id);

            if(formBorrarProducto.rdbNotebook.Checked)
            {
                PCoNotebook = false;
                tipo = typeof(Notebook);
            }
            else if(formBorrarProducto.rdbPCEscritorio.Checked)
            {
                PCoNotebook = true;
                tipo = typeof(PCEscritorio);
            }


            if(id != -1)
            {
                foreach(Producto producto in this.listaProductosDAO)
                {
                    if (producto.ID == id && tipo == producto.GetType())
                    {
                        noHayId = true;

                        if (MessageBox.Show(producto.ToString(),
                            "Desea borrar el producto?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (this.ProductoDAO.BorrarProducto(id, PCoNotebook))
                            {
                                MessageBox.Show("Producto borrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Borrado cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    } 
                }


                if (!noHayId)
                {
                    MessageBox.Show("No hay producto con el ID: " + id.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        /// <summary>
        /// Boton que guardara el archivo en un txt
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
            }
            catch (ArchivosExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Boton que mostrara el archivo en el segundo cuadro de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            txtArchivoGuardado.Text = Producto.Leer();
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

                sb.AppendLine("******************************");
                sb.AppendLine($"Computadoras en Stock: {this.listaProductosDAO.Count}");
                sb.AppendLine("******************************");

                if(this.listaProductosDAO.Count == 9)
                {
                    sb.AppendLine($"Se puede agregar: {this.cantidadMaximaProductos - this.listaProductosDAO.Count} producto mas");
                    sb.AppendLine("******************************");
                }
                else
                {
                    sb.AppendLine($"Se pueden agregar: {this.cantidadMaximaProductos - this.listaProductosDAO.Count} productos mas");
                    sb.AppendLine("******************************\n\n");
                }

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
