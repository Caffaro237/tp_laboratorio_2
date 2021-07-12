
namespace FormFabrica
{
    partial class FrmBorrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrarProducto));
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblIdABorrar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxTipo = new System.Windows.Forms.GroupBox();
            this.rdbPCEscritorio = new System.Windows.Forms.RadioButton();
            this.rdbNotebook = new System.Windows.Forms.RadioButton();
            this.grpBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(18, 162);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(296, 41);
            this.txbID.TabIndex = 0;
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lblIdABorrar
            // 
            this.lblIdABorrar.AutoSize = true;
            this.lblIdABorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdABorrar.Location = new System.Drawing.Point(12, 123);
            this.lblIdABorrar.Name = "lblIdABorrar";
            this.lblIdABorrar.Size = new System.Drawing.Size(302, 36);
            this.lblIdABorrar.TabIndex = 1;
            this.lblIdABorrar.Text = "Ingrese el ID a borrar:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 209);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 65);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 65);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el tipo:";
            // 
            // grpBoxTipo
            // 
            this.grpBoxTipo.Controls.Add(this.rdbPCEscritorio);
            this.grpBoxTipo.Controls.Add(this.rdbNotebook);
            this.grpBoxTipo.Location = new System.Drawing.Point(18, 48);
            this.grpBoxTipo.Name = "grpBoxTipo";
            this.grpBoxTipo.Size = new System.Drawing.Size(296, 75);
            this.grpBoxTipo.TabIndex = 5;
            this.grpBoxTipo.TabStop = false;
            // 
            // rdbPCEscritorio
            // 
            this.rdbPCEscritorio.AutoSize = true;
            this.rdbPCEscritorio.Location = new System.Drawing.Point(140, 32);
            this.rdbPCEscritorio.Name = "rdbPCEscritorio";
            this.rdbPCEscritorio.Size = new System.Drawing.Size(130, 21);
            this.rdbPCEscritorio.TabIndex = 1;
            this.rdbPCEscritorio.Text = "PC de Escritorio";
            this.rdbPCEscritorio.UseVisualStyleBackColor = true;
            // 
            // rdbNotebook
            // 
            this.rdbNotebook.AutoSize = true;
            this.rdbNotebook.Checked = true;
            this.rdbNotebook.Location = new System.Drawing.Point(26, 32);
            this.rdbNotebook.Name = "rdbNotebook";
            this.rdbNotebook.Size = new System.Drawing.Size(90, 21);
            this.rdbNotebook.TabIndex = 0;
            this.rdbNotebook.TabStop = true;
            this.rdbNotebook.Text = "Notebook";
            this.rdbNotebook.UseVisualStyleBackColor = true;
            // 
            // FrmBorrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.grpBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblIdABorrar);
            this.Controls.Add(this.txbID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBorrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBorrarProducto_FormClosing);
            this.grpBoxTipo.ResumeLayout(false);
            this.grpBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdABorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grpBoxTipo;
        public System.Windows.Forms.RadioButton rdbPCEscritorio;
        public System.Windows.Forms.RadioButton rdbNotebook;
    }
}