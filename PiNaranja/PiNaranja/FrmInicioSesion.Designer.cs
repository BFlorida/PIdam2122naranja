namespace PiNaranja
{
    partial class FrmInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.ptblogo = new System.Windows.Forms.PictureBox();
            this.btnRecContr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(276, 243);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(260, 314);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(208, 274);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(224, 30);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenya.Location = new System.Drawing.Point(208, 344);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(224, 30);
            this.txtContrasenya.TabIndex = 4;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(242, 401);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(154, 43);
            this.btnInicioSesion.TabIndex = 5;
            this.btnInicioSesion.Text = "INICIO SESION";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(228, 469);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(183, 43);
            this.btnCrearCuenta.TabIndex = 6;
            this.btnCrearCuenta.Text = "CREAR CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(366, 204);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(61, 20);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(448, 204);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(92, 21);
            this.cmbIdioma.TabIndex = 10;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // ptbSalir
            // 
            this.ptbSalir.Image = ((System.Drawing.Image)(resources.GetObject("ptbSalir.Image")));
            this.ptbSalir.Location = new System.Drawing.Point(513, 506);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(43, 46);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 7;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // ptblogo
            // 
            this.ptblogo.Image = ((System.Drawing.Image)(resources.GetObject("ptblogo.Image")));
            this.ptblogo.Location = new System.Drawing.Point(51, 43);
            this.ptblogo.Name = "ptblogo";
            this.ptblogo.Size = new System.Drawing.Size(488, 145);
            this.ptblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptblogo.TabIndex = 0;
            this.ptblogo.TabStop = false;
            // 
            // btnRecContr
            // 
            this.btnRecContr.Location = new System.Drawing.Point(37, 459);
            this.btnRecContr.Name = "btnRecContr";
            this.btnRecContr.Size = new System.Drawing.Size(133, 23);
            this.btnRecContr.TabIndex = 11;
            this.btnRecContr.Text = "Recuperar Contraseña";
            this.btnRecContr.UseVisualStyleBackColor = true;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnRecContr);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptblogo);
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptblogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Button btnRecContr;
    }
}

