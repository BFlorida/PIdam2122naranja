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
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.Location = new System.Drawing.Point(168, 144);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(183, 23);
            this.btnEnviarMail.TabIndex = 0;
            this.btnEnviarMail.Text = "Enviar Mail";
            this.btnEnviarMail.UseVisualStyleBackColor = true;
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(165, 102);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(234, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Introduce el usuario del que recuperar el usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(168, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(165, 188);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(228, 26);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Introduce aqui el codigo que has recibido en el\r\ncorreo asociado al usuario intro" +
    "ducido arriba";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 218);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnCambiarContrasenya
            // 
            this.btnCambiarContrasenya.Location = new System.Drawing.Point(168, 283);
            this.btnCambiarContrasenya.Name = "btnCambiarContrasenya";
            this.btnCambiarContrasenya.Size = new System.Drawing.Size(183, 23);
            this.btnCambiarContrasenya.TabIndex = 5;
            this.btnCambiarContrasenya.Text = "Cambiar Contraseña";
            this.btnCambiarContrasenya.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenya.Click += new System.EventHandler(this.btnCambiarContrasenya_Click);
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Location = new System.Drawing.Point(165, 241);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(152, 13);
            this.lblContrasenya.TabIndex = 6;
            this.lblContrasenya.Text = "Introduce la nueva contraseña";
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(168, 257);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(183, 20);
            this.txtContrasenya.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(57, 355);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.lblContrasenya);
            this.Controls.Add(this.btnCambiarContrasenya);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEnviarMail);
            this.Name = "FrmRecuperarCuenta";
            this.Text = "FrmRecuperarCuenta";
            this.Load += new System.EventHandler(this.FrmRecuperarCuenta_Load);
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
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnVolver;
    }
}