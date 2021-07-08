
namespace FormFabrica
{
    partial class FrmFabrica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFrmNotebook = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnFormPCEscritorio = new System.Windows.Forms.Button();
            this.txtArchivoGuardado = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtInformacion = new System.Windows.Forms.RichTextBox();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrmNotebook
            // 
            this.btnFrmNotebook.Location = new System.Drawing.Point(12, 12);
            this.btnFrmNotebook.Name = "btnFrmNotebook";
            this.btnFrmNotebook.Size = new System.Drawing.Size(200, 64);
            this.btnFrmNotebook.TabIndex = 0;
            this.btnFrmNotebook.Text = "Agregar Notebook";
            this.btnFrmNotebook.UseVisualStyleBackColor = true;
            this.btnFrmNotebook.Click += new System.EventHandler(this.btnFrmNotebook_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(705, 12);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(200, 64);
            this.btnGuardarArchivo.TabIndex = 1;
            this.btnGuardarArchivo.Text = "Guardar y Mostrar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnFormPCEscritorio
            // 
            this.btnFormPCEscritorio.Location = new System.Drawing.Point(243, 12);
            this.btnFormPCEscritorio.Name = "btnFormPCEscritorio";
            this.btnFormPCEscritorio.Size = new System.Drawing.Size(200, 64);
            this.btnFormPCEscritorio.TabIndex = 14;
            this.btnFormPCEscritorio.Text = "Agregar PC de Escritorio";
            this.btnFormPCEscritorio.UseVisualStyleBackColor = true;
            this.btnFormPCEscritorio.Click += new System.EventHandler(this.btnFormPCEscritorio_Click);
            // 
            // txtArchivoGuardado
            // 
            this.txtArchivoGuardado.Location = new System.Drawing.Point(477, 82);
            this.txtArchivoGuardado.Name = "txtArchivoGuardado";
            this.txtArchivoGuardado.Size = new System.Drawing.Size(428, 451);
            this.txtArchivoGuardado.TabIndex = 16;
            this.txtArchivoGuardado.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(359, 539);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(200, 64);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(12, 82);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(431, 451);
            this.txtInformacion.TabIndex = 18;
            this.txtInformacion.Text = "";
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(477, 12);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(200, 64);
            this.btnBorrarProducto.TabIndex = 19;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // FrmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 614);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtArchivoGuardado);
            this.Controls.Add(this.btnFormPCEscritorio);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnFrmNotebook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de Computadoras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFabrica_FormClosing);
            this.Load += new System.EventHandler(this.FrmFabrica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmNotebook;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnFormPCEscritorio;
        private System.Windows.Forms.RichTextBox txtArchivoGuardado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RichTextBox txtInformacion;
        private System.Windows.Forms.Button btnBorrarProducto;
    }
}

