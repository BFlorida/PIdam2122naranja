namespace PiNaranja
{
    partial class FrmVerificacion
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
            this.lblSendedEmail = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCheckVCode = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSendedEmail
            // 
            this.lblSendedEmail.AutoSize = true;
            this.lblSendedEmail.Location = new System.Drawing.Point(163, 84);
            this.lblSendedEmail.Name = "lblSendedEmail";
            this.lblSendedEmail.Size = new System.Drawing.Size(62, 16);
            this.lblSendedEmail.TabIndex = 0;
            this.lblSendedEmail.Text = "sendMail";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(166, 151);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(163, 132);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 16);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "codigo";
            // 
            // btnCheckVCode
            // 
            this.btnCheckVCode.Location = new System.Drawing.Point(166, 191);
            this.btnCheckVCode.Name = "btnCheckVCode";
            this.btnCheckVCode.Size = new System.Drawing.Size(75, 23);
            this.btnCheckVCode.TabIndex = 3;
            this.btnCheckVCode.Text = "verificar";
            this.btnCheckVCode.UseVisualStyleBackColor = true;
            this.btnCheckVCode.Click += new System.EventHandler(this.btnCheckVCode_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(166, 260);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "volver";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckVCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblSendedEmail);
            this.Name = "FrmVerificacion";
            this.Text = "Verificacion";
            this.Load += new System.EventHandler(this.Verificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendedEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnCheckVCode;
        private System.Windows.Forms.Button btnReturn;
    }
}