namespace PiNaranja
{
    partial class FrmCreaCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreaCuenta));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.lblCreaCuenta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.grbRellena = new System.Windows.Forms.GroupBox();
            this.txtNombreHogar = new System.Windows.Forms.TextBox();
            this.lblNombreHogar = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.grbRellena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(234, 150);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 20);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(226, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.AutoSize = true;
            this.lblConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstraseña.Location = new System.Drawing.Point(214, 202);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(92, 20);
            this.lblConstraseña.TabIndex = 6;
            this.lblConstraseña.Text = "Contraseña";
            // 
            // lblCreaCuenta
            // 
            this.lblCreaCuenta.AutoSize = true;
            this.lblCreaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaCuenta.Location = new System.Drawing.Point(152, 32);
            this.lblCreaCuenta.Name = "lblCreaCuenta";
            this.lblCreaCuenta.Size = new System.Drawing.Size(299, 25);
            this.lblCreaCuenta.TabIndex = 7;
            this.lblCreaCuenta.Text = "Crear Nueva Cuenta myHomy";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(172, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(172, 225);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(185, 26);
            this.txtCon.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(172, 270);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(185, 49);
            this.btnCrearCuenta.TabIndex = 13;
            this.btnCrearCuenta.Text = "CREAR CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // grbRellena
            // 
            this.grbRellena.Controls.Add(this.txtNombreHogar);
            this.grbRellena.Controls.Add(this.lblNombreHogar);
            this.grbRellena.Controls.Add(this.cmbIdioma);
            this.grbRellena.Controls.Add(this.lblIdioma);
            this.grbRellena.Controls.Add(this.btnCrearCuenta);
            this.grbRellena.Controls.Add(this.txtCon);
            this.grbRellena.Controls.Add(this.txtEmail);
            this.grbRellena.Controls.Add(this.txtNombre);
            this.grbRellena.Controls.Add(this.lblConstraseña);
            this.grbRellena.Controls.Add(this.lblCorreo);
            this.grbRellena.Controls.Add(this.lblNombre);
            this.grbRellena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRellena.Location = new System.Drawing.Point(31, 81);
            this.grbRellena.Name = "grbRellena";
            this.grbRellena.Size = new System.Drawing.Size(525, 349);
            this.grbRellena.TabIndex = 14;
            this.grbRellena.TabStop = false;
            this.grbRellena.Text = "Rellena los siguientes campos";
            // 
            // txtNombreHogar
            // 
            this.txtNombreHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHogar.Location = new System.Drawing.Point(172, 120);
            this.txtNombreHogar.Name = "txtNombreHogar";
            this.txtNombreHogar.Size = new System.Drawing.Size(185, 23);
            this.txtNombreHogar.TabIndex = 17;
            // 
            // lblNombreHogar
            // 
            this.lblNombreHogar.AutoSize = true;
            this.lblNombreHogar.Location = new System.Drawing.Point(196, 97);
            this.lblNombreHogar.Name = "lblNombreHogar";
            this.lblNombreHogar.Size = new System.Drawing.Size(142, 20);
            this.lblNombreHogar.TabIndex = 16;
            this.lblNombreHogar.Text = "Nombre del Hogar:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(422, 20);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(99, 28);
            this.cmbIdioma.TabIndex = 15;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(346, 22);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(61, 20);
            this.lblIdioma.TabIndex = 14;
            this.lblIdioma.Text = "Idioma:";
            // 
            // ptbSalir
            // 
            this.ptbSalir.Image = ((System.Drawing.Image)(resources.GetObject("ptbSalir.Image")));
            this.ptbSalir.Location = new System.Drawing.Point(534, 503);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(43, 46);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 15;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(121, 436);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(341, 113);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 8;
            this.ptbLogo.TabStop = false;
            // 
            // FrmCreaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 561);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.grbRellena);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblCreaCuenta);
            this.Name = "FrmCreaCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crea Cuenta";
            this.Load += new System.EventHandler(this.FrmCreaCuenta_Load);
            this.grbRellena.ResumeLayout(false);
            this.grbRellena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblConstraseña;
        private System.Windows.Forms.Label lblCreaCuenta;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.GroupBox grbRellena;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtNombreHogar;
        private System.Windows.Forms.Label lblNombreHogar;
    }
}