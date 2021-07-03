
namespace FormFabrica
{
    partial class FrmPCEscritorio
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
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.grbAlmacenamiento = new System.Windows.Forms.GroupBox();
            this.rdb4000GB = new System.Windows.Forms.RadioButton();
            this.rdb1000GB = new System.Windows.Forms.RadioButton();
            this.rdb500GB = new System.Windows.Forms.RadioButton();
            this.rdb240GB = new System.Windows.Forms.RadioButton();
            this.grbRAM = new System.Windows.Forms.GroupBox();
            this.rdb64GB = new System.Windows.Forms.RadioButton();
            this.rdb32GB = new System.Windows.Forms.RadioButton();
            this.rdb8GB = new System.Windows.Forms.RadioButton();
            this.rdb16GB = new System.Windows.Forms.RadioButton();
            this.cmbGPU = new System.Windows.Forms.ComboBox();
            this.cmbCPU = new System.Windows.Forms.ComboBox();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.btnAgregarPCEscritorio = new System.Windows.Forms.Button();
            this.btnCancelarPCEscritorio = new System.Windows.Forms.Button();
            this.grbAlmacenamiento.SuspendLayout();
            this.grbRAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(347, 81);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(158, 25);
            this.lblAlmacenamiento.TabIndex = 25;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(232, 81);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(56, 25);
            this.lblRAM.TabIndex = 24;
            this.lblRAM.Text = "RAM";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(13, 196);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(112, 25);
            this.lblCPU.TabIndex = 23;
            this.lblCPU.Text = "Procesador";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(13, 309);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(140, 25);
            this.lblGPU.TabIndex = 22;
            this.lblGPU.Text = "Tarjeta Grafica";
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(13, 81);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(77, 25);
            this.lblMarcas.TabIndex = 21;
            this.lblMarcas.Text = "Marcas";
            // 
            // grbAlmacenamiento
            // 
            this.grbAlmacenamiento.Controls.Add(this.rdb4000GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb1000GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb500GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb240GB);
            this.grbAlmacenamiento.Location = new System.Drawing.Point(352, 109);
            this.grbAlmacenamiento.Name = "grbAlmacenamiento";
            this.grbAlmacenamiento.Size = new System.Drawing.Size(101, 215);
            this.grbAlmacenamiento.TabIndex = 5;
            this.grbAlmacenamiento.TabStop = false;
            // 
            // rdb4000GB
            // 
            this.rdb4000GB.AutoSize = true;
            this.rdb4000GB.Location = new System.Drawing.Point(6, 171);
            this.rdb4000GB.Name = "rdb4000GB";
            this.rdb4000GB.Size = new System.Drawing.Size(61, 21);
            this.rdb4000GB.TabIndex = 3;
            this.rdb4000GB.TabStop = true;
            this.rdb4000GB.Text = "4000";
            this.rdb4000GB.UseVisualStyleBackColor = true;
            // 
            // rdb1000GB
            // 
            this.rdb1000GB.AutoSize = true;
            this.rdb1000GB.Location = new System.Drawing.Point(6, 119);
            this.rdb1000GB.Name = "rdb1000GB";
            this.rdb1000GB.Size = new System.Drawing.Size(61, 21);
            this.rdb1000GB.TabIndex = 2;
            this.rdb1000GB.TabStop = true;
            this.rdb1000GB.Text = "1000";
            this.rdb1000GB.UseVisualStyleBackColor = true;
            // 
            // rdb500GB
            // 
            this.rdb500GB.AutoSize = true;
            this.rdb500GB.Location = new System.Drawing.Point(6, 69);
            this.rdb500GB.Name = "rdb500GB";
            this.rdb500GB.Size = new System.Drawing.Size(53, 21);
            this.rdb500GB.TabIndex = 1;
            this.rdb500GB.TabStop = true;
            this.rdb500GB.Text = "500";
            this.rdb500GB.UseVisualStyleBackColor = true;
            // 
            // rdb240GB
            // 
            this.rdb240GB.AutoSize = true;
            this.rdb240GB.Location = new System.Drawing.Point(6, 21);
            this.rdb240GB.Name = "rdb240GB";
            this.rdb240GB.Size = new System.Drawing.Size(53, 21);
            this.rdb240GB.TabIndex = 0;
            this.rdb240GB.TabStop = true;
            this.rdb240GB.Text = "240";
            this.rdb240GB.UseVisualStyleBackColor = true;
            // 
            // grbRAM
            // 
            this.grbRAM.Controls.Add(this.rdb64GB);
            this.grbRAM.Controls.Add(this.rdb32GB);
            this.grbRAM.Controls.Add(this.rdb8GB);
            this.grbRAM.Controls.Add(this.rdb16GB);
            this.grbRAM.Location = new System.Drawing.Point(237, 109);
            this.grbRAM.Name = "grbRAM";
            this.grbRAM.Size = new System.Drawing.Size(99, 215);
            this.grbRAM.TabIndex = 4;
            this.grbRAM.TabStop = false;
            // 
            // rdb64GB
            // 
            this.rdb64GB.AutoSize = true;
            this.rdb64GB.Location = new System.Drawing.Point(6, 171);
            this.rdb64GB.Name = "rdb64GB";
            this.rdb64GB.Size = new System.Drawing.Size(45, 21);
            this.rdb64GB.TabIndex = 3;
            this.rdb64GB.TabStop = true;
            this.rdb64GB.Text = "64";
            this.rdb64GB.UseVisualStyleBackColor = true;
            // 
            // rdb32GB
            // 
            this.rdb32GB.AutoSize = true;
            this.rdb32GB.Location = new System.Drawing.Point(6, 119);
            this.rdb32GB.Name = "rdb32GB";
            this.rdb32GB.Size = new System.Drawing.Size(45, 21);
            this.rdb32GB.TabIndex = 2;
            this.rdb32GB.TabStop = true;
            this.rdb32GB.Text = "32";
            this.rdb32GB.UseVisualStyleBackColor = true;
            // 
            // rdb8GB
            // 
            this.rdb8GB.AutoSize = true;
            this.rdb8GB.Location = new System.Drawing.Point(6, 21);
            this.rdb8GB.Name = "rdb8GB";
            this.rdb8GB.Size = new System.Drawing.Size(37, 21);
            this.rdb8GB.TabIndex = 0;
            this.rdb8GB.TabStop = true;
            this.rdb8GB.Text = "8";
            this.rdb8GB.UseVisualStyleBackColor = true;
            // 
            // rdb16GB
            // 
            this.rdb16GB.AutoSize = true;
            this.rdb16GB.Location = new System.Drawing.Point(6, 69);
            this.rdb16GB.Name = "rdb16GB";
            this.rdb16GB.Size = new System.Drawing.Size(45, 21);
            this.rdb16GB.TabIndex = 1;
            this.rdb16GB.TabStop = true;
            this.rdb16GB.Text = "16";
            this.rdb16GB.UseVisualStyleBackColor = true;
            // 
            // cmbGPU
            // 
            this.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGPU.FormattingEnabled = true;
            this.cmbGPU.Location = new System.Drawing.Point(16, 337);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(178, 33);
            this.cmbGPU.TabIndex = 3;
            // 
            // cmbCPU
            // 
            this.cmbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(16, 224);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(178, 33);
            this.cmbCPU.TabIndex = 2;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(16, 109);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(178, 33);
            this.cmbMarcas.TabIndex = 1;
            // 
            // btnAgregarPCEscritorio
            // 
            this.btnAgregarPCEscritorio.Location = new System.Drawing.Point(51, 428);
            this.btnAgregarPCEscritorio.Name = "btnAgregarPCEscritorio";
            this.btnAgregarPCEscritorio.Size = new System.Drawing.Size(200, 64);
            this.btnAgregarPCEscritorio.TabIndex = 6;
            this.btnAgregarPCEscritorio.Text = "Agregar";
            this.btnAgregarPCEscritorio.UseVisualStyleBackColor = true;
            this.btnAgregarPCEscritorio.Click += new System.EventHandler(this.btnAgregarPCEscritorio_Click);
            // 
            // btnCancelarPCEscritorio
            // 
            this.btnCancelarPCEscritorio.Location = new System.Drawing.Point(275, 428);
            this.btnCancelarPCEscritorio.Name = "btnCancelarPCEscritorio";
            this.btnCancelarPCEscritorio.Size = new System.Drawing.Size(200, 64);
            this.btnCancelarPCEscritorio.TabIndex = 7;
            this.btnCancelarPCEscritorio.Text = "Cancelar";
            this.btnCancelarPCEscritorio.UseVisualStyleBackColor = true;
            this.btnCancelarPCEscritorio.Click += new System.EventHandler(this.btnCancelarPCEscritorio_Click);
            // 
            // FrmPCEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 528);
            this.Controls.Add(this.btnCancelarPCEscritorio);
            this.Controls.Add(this.btnAgregarPCEscritorio);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.grbAlmacenamiento);
            this.Controls.Add(this.grbRAM);
            this.Controls.Add(this.cmbGPU);
            this.Controls.Add(this.cmbCPU);
            this.Controls.Add(this.cmbMarcas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPCEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar PC de Escritorio";
            this.Load += new System.EventHandler(this.FrmPCEscritorio_Load);
            this.grbAlmacenamiento.ResumeLayout(false);
            this.grbAlmacenamiento.PerformLayout();
            this.grbRAM.ResumeLayout(false);
            this.grbRAM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.GroupBox grbAlmacenamiento;
        private System.Windows.Forms.RadioButton rdb4000GB;
        private System.Windows.Forms.RadioButton rdb1000GB;
        private System.Windows.Forms.RadioButton rdb500GB;
        private System.Windows.Forms.RadioButton rdb240GB;
        private System.Windows.Forms.GroupBox grbRAM;
        private System.Windows.Forms.RadioButton rdb64GB;
        private System.Windows.Forms.RadioButton rdb32GB;
        private System.Windows.Forms.RadioButton rdb8GB;
        private System.Windows.Forms.RadioButton rdb16GB;
        private System.Windows.Forms.ComboBox cmbGPU;
        private System.Windows.Forms.ComboBox cmbCPU;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Button btnAgregarPCEscritorio;
        private System.Windows.Forms.Button btnCancelarPCEscritorio;
    }
}