namespace PiNaranja
{
    partial class FrmRecuperarCuenta
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
            this.btnEnviarMail = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCambiarContrasenya = new System.Windows.Forms.Button();
            this.lblNuevaCon = new System.Windows.Forms.Label();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbRecuperacion = new System.Windows.Forms.GroupBox();
            this.grbCambioCon = new System.Windows.Forms.GroupBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbRecuperacion.SuspendLayout();
            this.grbCambioCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMail.Location = new System.Drawing.Point(138, 152);
            this.btnEnviarMail.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(128, 44);
            this.btnEnviarMail.TabIndex = 0;
            this.btnEnviarMail.Text = "Enviar Mail";
            this.btnEnviarMail.UseVisualStyleBackColor = false;
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(158, 75);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(106, 106);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(160, 56);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 86);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(212, 26);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnCambiarContrasenya
            // 
            this.btnCambiarContrasenya.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarContrasenya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasenya.Location = new System.Drawing.Point(96, 236);
            this.btnCambiarContrasenya.Margin = new System.Windows.Forms.Padding(6);
            this.btnCambiarContrasenya.Name = "btnCambiarContrasenya";
            this.btnCambiarContrasenya.Size = new System.Drawing.Size(214, 44);
            this.btnCambiarContrasenya.TabIndex = 5;
            this.btnCambiarContrasenya.Text = "Cambiar Contraseña";
            this.btnCambiarContrasenya.UseVisualStyleBackColor = false;
            this.btnCambiarContrasenya.Click += new System.EventHandler(this.btnCambiarContrasenya_Click);
            // 
            // lblNuevaCon
            // 
            this.lblNuevaCon.AutoSize = true;
            this.lblNuevaCon.Location = new System.Drawing.Point(110, 139);
            this.lblNuevaCon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNuevaCon.Name = "lblNuevaCon";
            this.lblNuevaCon.Size = new System.Drawing.Size(141, 20);
            this.lblNuevaCon.TabIndex = 6;
            this.lblNuevaCon.Text = "Nueva Contraseña";
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(96, 169);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(6);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(212, 26);
            this.txtContrasenya.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(819, 433);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 44);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grbRecuperacion
            // 
            this.grbRecuperacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbRecuperacion.Controls.Add(this.txtUsuario);
            this.grbRecuperacion.Controls.Add(this.btnEnviarMail);
            this.grbRecuperacion.Controls.Add(this.lblUsuario);
            this.grbRecuperacion.Location = new System.Drawing.Point(13, 97);
            this.grbRecuperacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbRecuperacion.Name = "grbRecuperacion";
            this.grbRecuperacion.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbRecuperacion.Size = new System.Drawing.Size(434, 298);
            this.grbRecuperacion.TabIndex = 9;
            this.grbRecuperacion.TabStop = false;
            this.grbRecuperacion.Text = "Email de Recuperación";
            // 
            // grbCambioCon
            // 
            this.grbCambioCon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbCambioCon.Controls.Add(this.lblNuevaCon);
            this.grbCambioCon.Controls.Add(this.lblCodigo);
            this.grbCambioCon.Controls.Add(this.txtCodigo);
            this.grbCambioCon.Controls.Add(this.txtContrasenya);
            this.grbCambioCon.Controls.Add(this.btnCambiarContrasenya);
            this.grbCambioCon.Location = new System.Drawing.Point(523, 97);
            this.grbCambioCon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbCambioCon.Name = "grbCambioCon";
            this.grbCambioCon.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbCambioCon.Size = new System.Drawing.Size(396, 300);
            this.grbCambioCon.TabIndex = 10;
            this.grbCambioCon.TabStop = false;
            this.grbCambioCon.Text = "Cambio de Contraseña";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(680, 27);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(61, 20);
            this.lblIdioma.TabIndex = 11;
            this.lblIdioma.Text = "Idioma:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(788, 22);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(180, 28);
            this.cmbIdioma.TabIndex = 12;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PiNaranja.Properties.Resources.Logo_MyHomy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 492);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.grbCambioCon);
            this.Controls.Add(this.grbRecuperacion);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmRecuperarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperarCuenta";
            this.Load += new System.EventHandler(this.FrmRecuperarCuenta_Load);
            this.grbRecuperacion.ResumeLayout(false);
            this.grbRecuperacion.PerformLayout();
            this.grbCambioCon.ResumeLayout(false);
            this.grbCambioCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarMail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCambiarContrasenya;
        private System.Windows.Forms.Label lblNuevaCon;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grbRecuperacion;
        private System.Windows.Forms.GroupBox grbCambioCon;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}