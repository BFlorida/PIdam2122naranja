namespace PiNaranja
{
    partial class FrmReemplazarCasa
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
            this.lbl = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.txtNewHome = new System.Windows.Forms.TextBox();
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
            this.btnCancelarBorrado = new System.Windows.Forms.Button();
            this.btnActualizarCasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(132, 178);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
<<<<<<< HEAD
            // txtNewHome
            // 
            this.txtNewHome.Location = new System.Drawing.Point(135, 194);
            this.txtNewHome.Name = "txtNewHome";
            this.txtNewHome.Size = new System.Drawing.Size(260, 20);
            this.txtNewHome.TabIndex = 1;
=======
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
            // 
            // btnCancelarBorrado
            // 
            this.btnCancelarBorrado.Location = new System.Drawing.Point(135, 220);
            this.btnCancelarBorrado.Name = "btnCancelarBorrado";
            this.btnCancelarBorrado.Size = new System.Drawing.Size(123, 23);
            this.btnCancelarBorrado.TabIndex = 2;
            this.btnCancelarBorrado.Text = "Cancelar Borrado";
            this.btnCancelarBorrado.UseVisualStyleBackColor = true;
            this.btnCancelarBorrado.Click += new System.EventHandler(this.btnCancelarBorrado_Click);
            // 
            // btnActualizarCasa
            // 
            this.btnActualizarCasa.Location = new System.Drawing.Point(264, 220);
            this.btnActualizarCasa.Name = "btnActualizarCasa";
            this.btnActualizarCasa.Size = new System.Drawing.Size(131, 23);
            this.btnActualizarCasa.TabIndex = 3;
            this.btnActualizarCasa.Text = "btnActualizarCasa";
            this.btnActualizarCasa.UseVisualStyleBackColor = true;
            this.btnActualizarCasa.Click += new System.EventHandler(this.btnActualizarCasa_Click);
            // 
            // FrmReemplazarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarCasa);
            this.Controls.Add(this.btnCancelarBorrado);
<<<<<<< HEAD
            this.Controls.Add(this.txtNewHome);
            this.Controls.Add(this.lbl);
            this.Name = "FrmReemplazarCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl);
            this.Name = "FrmReemplazarCasa";
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
            this.Text = "FrmReemplazarCasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtNewHome;
=======
        private System.Windows.Forms.TextBox textBox1;
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
        private System.Windows.Forms.Button btnCancelarBorrado;
        private System.Windows.Forms.Button btnActualizarCasa;
    }
}