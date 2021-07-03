﻿using System;
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
        List<Producto> listaProductosDAO;
        ProductoDAO ProductoDAO;
        bool pcEscritorio = true;
        bool notebook = false;

        public FrmFabrica()
        {
            InitializeComponent();
            ProductoDAO = new ProductoDAO();
            listaProductosDAO = new List<Producto>();
        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
        }

        private void btnFrmNotebook_Click(object sender, EventArgs e)
        {
            this.InsertarProducto(EnumMarcas.Acer.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120, notebook);




            //this.BorrarRtb();
            //this.LeerSQL(notebook);
            //this.LeerSQL(pcEscritorio);

            //FrmNotebooks formNotebooks = new FrmNotebooks();
            //formNotebooks.ShowDialog();
        }

        private void btnFormPCEscritorio_Click(object sender, EventArgs e)
        {
            this.LeerSQL(notebook);
            //this.LeerSQL(pcEscritorio);

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

        public void LeerSQL(bool PCoNotebook)
        {
            try
            {
                this.listaProductosDAO = this.ProductoDAO.GetNotebooks();

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

                richTextBox1.Text = sb.ToString();
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

        public void BorrarRtb()
        {
            richTextBox1.Clear();
        }
    }
}
