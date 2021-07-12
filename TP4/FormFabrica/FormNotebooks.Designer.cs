
namespace FormFabrica
{
    partial class FrmNotebooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotebooks));
            this.grbHzPantalla = new System.Windows.Forms.GroupBox();
            this.rdb240hz = new System.Windows.Forms.RadioButton();
            this.rdb144hz = new System.Windows.Forms.RadioButton();
            this.rdb120hz = new System.Windows.Forms.RadioButton();
            this.rdb60hz = new System.Windows.Forms.RadioButton();
            this.lblHzPantalla = new System.Windows.Forms.Label();
            this.lblPulgadas = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.grbPulgadas = new System.Windows.Forms.GroupBox();
            this.rdb17Pulgadas = new System.Windows.Forms.RadioButton();
            this.rdb15Pulgadas = new System.Windows.Forms.RadioButton();
            this.rdb14Pulgadas = new System.Windows.Forms.RadioButton();
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
            this.btnAgregarNotebook = new System.Windows.Forms.Button();
            this.btnCancelarNotebooks = new System.Windows.Forms.Button();
            this.grbHzPantalla.SuspendLayout();
            this.grbPulgadas.SuspendLayout();
            this.grbAlmacenamiento.SuspendLayout();
            this.grbRAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHzPantalla
            // 
            this.grbHzPantalla.Controls.Add(this.rdb240hz);
            this.grbHzPantalla.Controls.Add(this.rdb144hz);
            this.grbHzPantalla.Controls.Add(this.rdb120hz);
            this.grbHzPantalla.Controls.Add(this.rdb60hz);
            this.grbHzPantalla.Location = new System.Drawing.Point(699, 71);
            this.grbHzPantalla.Name = "grbHzPantalla";
            this.grbHzPantalla.Size = new System.Drawing.Size(119, 215);
            this.grbHzPantalla.TabIndex = 7;
            this.grbHzPantalla.TabStop = false;
            // 
            // rdb240hz
            // 
            this.rdb240hz.AutoSize = true;
            this.rdb240hz.Location = new System.Drawing.Point(7, 171);
            this.rdb240hz.Name = "rdb240hz";
            this.rdb240hz.Size = new System.Drawing.Size(53, 21);
            this.rdb240hz.TabIndex = 3;
            this.rdb240hz.TabStop = true;
            this.rdb240hz.Text = "240";
            this.rdb240hz.UseVisualStyleBackColor = true;
            // 
            // rdb144hz
            // 
            this.rdb144hz.AutoSize = true;
            this.rdb144hz.Location = new System.Drawing.Point(7, 119);
            this.rdb144hz.Name = "rdb144hz";
            this.rdb144hz.Size = new System.Drawing.Size(53, 21);
            this.rdb144hz.TabIndex = 2;
            this.rdb144hz.TabStop = true;
            this.rdb144hz.Text = "144";
            this.rdb144hz.UseVisualStyleBackColor = true;
            // 
            // rdb120hz
            // 
            this.rdb120hz.AutoSize = true;
            this.rdb120hz.Location = new System.Drawing.Point(6, 69);
            this.rdb120hz.Name = "rdb120hz";
            this.rdb120hz.Size = new System.Drawing.Size(53, 21);
            this.rdb120hz.TabIndex = 1;
            this.rdb120hz.TabStop = true;
            this.rdb120hz.Text = "120";
            this.rdb120hz.UseVisualStyleBackColor = true;
            // 
            // rdb60hz
            // 
            this.rdb60hz.AutoSize = true;
            this.rdb60hz.Location = new System.Drawing.Point(7, 21);
            this.rdb60hz.Name = "rdb60hz";
            this.rdb60hz.Size = new System.Drawing.Size(45, 21);
            this.rdb60hz.TabIndex = 0;
            this.rdb60hz.TabStop = true;
            this.rdb60hz.Text = "60";
            this.rdb60hz.UseVisualStyleBackColor = true;
            // 
            // lblHzPantalla
            // 
            this.lblHzPantalla.AutoSize = true;
            this.lblHzPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHzPantalla.Location = new System.Drawing.Point(694, 43);
            this.lblHzPantalla.Name = "lblHzPantalla";
            this.lblHzPantalla.Size = new System.Drawing.Size(111, 25);
            this.lblHzPantalla.TabIndex = 27;
            this.lblHzPantalla.Text = "Hz Pantalla";
            // 
            // lblPulgadas
            // 
            this.lblPulgadas.AutoSize = true;
            this.lblPulgadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulgadas.Location = new System.Drawing.Point(553, 43);
            this.lblPulgadas.Name = "lblPulgadas";
            this.lblPulgadas.Size = new System.Drawing.Size(94, 25);
            this.lblPulgadas.TabIndex = 26;
            this.lblPulgadas.Text = "Pulgadas";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(377, 43);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(158, 25);
            this.lblAlmacenamiento.TabIndex = 25;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(262, 43);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(56, 25);
            this.lblRAM.TabIndex = 24;
            this.lblRAM.Text = "RAM";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(43, 158);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(112, 25);
            this.lblCPU.TabIndex = 23;
            this.lblCPU.Text = "Procesador";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(43, 271);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(140, 25);
            this.lblGPU.TabIndex = 22;
            this.lblGPU.Text = "Tarjeta Grafica";
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(43, 43);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(77, 25);
            this.lblMarcas.TabIndex = 21;
            this.lblMarcas.Text = "Marcas";
            // 
            // grbPulgadas
            // 
            this.grbPulgadas.Controls.Add(this.rdb17Pulgadas);
            this.grbPulgadas.Controls.Add(this.rdb15Pulgadas);
            this.grbPulgadas.Controls.Add(this.rdb14Pulgadas);
            this.grbPulgadas.Location = new System.Drawing.Point(558, 71);
            this.grbPulgadas.Name = "grbPulgadas";
            this.grbPulgadas.Size = new System.Drawing.Size(119, 215);
            this.grbPulgadas.TabIndex = 6;
            this.grbPulgadas.TabStop = false;
            // 
            // rdb17Pulgadas
            // 
            this.rdb17Pulgadas.AutoSize = true;
            this.rdb17Pulgadas.Location = new System.Drawing.Point(6, 119);
            this.rdb17Pulgadas.Name = "rdb17Pulgadas";
            this.rdb17Pulgadas.Size = new System.Drawing.Size(57, 21);
            this.rdb17Pulgadas.TabIndex = 2;
            this.rdb17Pulgadas.TabStop = true;
            this.rdb17Pulgadas.Text = "17.3";
            this.rdb17Pulgadas.UseVisualStyleBackColor = true;
            // 
            // rdb15Pulgadas
            // 
            this.rdb15Pulgadas.AutoSize = true;
            this.rdb15Pulgadas.Location = new System.Drawing.Point(6, 69);
            this.rdb15Pulgadas.Name = "rdb15Pulgadas";
            this.rdb15Pulgadas.Size = new System.Drawing.Size(57, 21);
            this.rdb15Pulgadas.TabIndex = 1;
            this.rdb15Pulgadas.TabStop = true;
            this.rdb15Pulgadas.Text = "15.6";
            this.rdb15Pulgadas.UseVisualStyleBackColor = true;
            // 
            // rdb14Pulgadas
            // 
            this.rdb14Pulgadas.AutoSize = true;
            this.rdb14Pulgadas.Location = new System.Drawing.Point(7, 21);
            this.rdb14Pulgadas.Name = "rdb14Pulgadas";
            this.rdb14Pulgadas.Size = new System.Drawing.Size(45, 21);
            this.rdb14Pulgadas.TabIndex = 0;
            this.rdb14Pulgadas.TabStop = true;
            this.rdb14Pulgadas.Text = "14";
            this.rdb14Pulgadas.UseVisualStyleBackColor = true;
            // 
            // grbAlmacenamiento
            // 
            this.grbAlmacenamiento.Controls.Add(this.rdb4000GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb1000GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb500GB);
            this.grbAlmacenamiento.Controls.Add(this.rdb240GB);
            this.grbAlmacenamiento.Location = new System.Drawing.Point(382, 71);
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
            this.grbRAM.Location = new System.Drawing.Point(267, 71);
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
            this.cmbGPU.Location = new System.Drawing.Point(46, 299);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(178, 33);
            this.cmbGPU.TabIndex = 3;
            // 
            // cmbCPU
            // 
            this.cmbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(46, 186);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(178, 33);
            this.cmbCPU.TabIndex = 2;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.AllowDrop = true;
            this.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(46, 71);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(178, 33);
            this.cmbMarcas.TabIndex = 1;
            // 
            // btnAgregarNotebook
            // 
            this.btnAgregarNotebook.Location = new System.Drawing.Point(209, 398);
            this.btnAgregarNotebook.Name = "btnAgregarNotebook";
            this.btnAgregarNotebook.Size = new System.Drawing.Size(200, 64);
            this.btnAgregarNotebook.TabIndex = 8;
            this.btnAgregarNotebook.Text = "Agregar";
            this.btnAgregarNotebook.UseVisualStyleBackColor = true;
            this.btnAgregarNotebook.Click += new System.EventHandler(this.btnAgregarNotebook_Click);
            // 
            // btnCancelarNotebooks
            // 
            this.btnCancelarNotebooks.Location = new System.Drawing.Point(477, 398);
            this.btnCancelarNotebooks.Name = "btnCancelarNotebooks";
            this.btnCancelarNotebooks.Size = new System.Drawing.Size(200, 64);
            this.btnCancelarNotebooks.TabIndex = 9;
            this.btnCancelarNotebooks.Text = "Cancelar";
            this.btnCancelarNotebooks.UseVisualStyleBackColor = true;
            this.btnCancelarNotebooks.Click += new System.EventHandler(this.btnCancelarNotebooks_Click);
            // 
            // FrmNotebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 543);
            this.Controls.Add(this.btnCancelarNotebooks);
            this.Controls.Add(this.btnAgregarNotebook);
            this.Controls.Add(this.grbHzPantalla);
            this.Controls.Add(this.lblHzPantalla);
            this.Controls.Add(this.lblPulgadas);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.grbPulgadas);
            this.Controls.Add(this.grbAlmacenamiento);
            this.Controls.Add(this.grbRAM);
            this.Controls.Add(this.cmbGPU);
            this.Controls.Add(this.cmbCPU);
            this.Controls.Add(this.cmbMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotebooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Notebook";
            this.Load += new System.EventHandler(this.FrmNotebooks_Load);
            this.grbHzPantalla.ResumeLayout(false);
            this.grbHzPantalla.PerformLayout();
            this.grbPulgadas.ResumeLayout(false);
            this.grbPulgadas.PerformLayout();
            this.grbAlmacenamiento.ResumeLayout(false);
            this.grbAlmacenamiento.PerformLayout();
            this.grbRAM.ResumeLayout(false);
            this.grbRAM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHzPantalla;
        private System.Windows.Forms.RadioButton rdb240hz;
        private System.Windows.Forms.RadioButton rdb144hz;
        private System.Windows.Forms.RadioButton rdb120hz;
        private System.Windows.Forms.RadioButton rdb60hz;
        private System.Windows.Forms.Label lblHzPantalla;
        private System.Windows.Forms.Label lblPulgadas;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.GroupBox grbPulgadas;
        private System.Windows.Forms.RadioButton rdb17Pulgadas;
        private System.Windows.Forms.RadioButton rdb15Pulgadas;
        private System.Windows.Forms.RadioButton rdb14Pulgadas;
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
        private System.Windows.Forms.Button btnAgregarNotebook;
        private System.Windows.Forms.Button btnCancelarNotebooks;
    }
}