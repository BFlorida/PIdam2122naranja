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
            this.btnCancelarBorrado = new System.Windows.Forms.Button();
            this.btnActualizarCasa = new System.Windows.Forms.Button();
            this.txtNewHome = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl.Location = new System.Drawing.Point(118, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(129, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Nombre de la nueva casa";
            // 
            // btnCancelarBorrado
            // 
            this.btnCancelarBorrado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelarBorrado.CausesValidation = false;
            this.btnCancelarBorrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBorrado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarBorrado.Location = new System.Drawing.Point(154, 121);
            this.btnCancelarBorrado.Name = "btnCancelarBorrado";
            this.btnCancelarBorrado.Size = new System.Drawing.Size(56, 23);
            this.btnCancelarBorrado.TabIndex = 2;
            this.btnCancelarBorrado.Text = "Cancelar";
            this.btnCancelarBorrado.UseVisualStyleBackColor = false;
            this.btnCancelarBorrado.Click += new System.EventHandler(this.btnCancelarBorrado_Click);
            // 
            // btnActualizarCasa
            // 
            this.btnActualizarCasa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCasa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCasa.Location = new System.Drawing.Point(135, 92);
            this.btnActualizarCasa.Name = "btnActualizarCasa";
            this.btnActualizarCasa.Size = new System.Drawing.Size(92, 23);
            this.btnActualizarCasa.TabIndex = 3;
            this.btnActualizarCasa.Text = "btnActualizarCasa";
            this.btnActualizarCasa.UseVisualStyleBackColor = false;
            this.btnActualizarCasa.Click += new System.EventHandler(this.btnActualizarCasa_Click);
            // 
            // txtNewHome
            // 
            this.txtNewHome.Location = new System.Drawing.Point(116, 67);
            this.txtNewHome.Name = "txtNewHome";
            this.txtNewHome.Size = new System.Drawing.Size(129, 20);
            this.txtNewHome.TabIndex = 5;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(259, 3);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(92, 21);
            this.cmbIdioma.TabIndex = 16;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(216, 6);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "label1:";
            // 
            // FrmReemplazarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(353, 202);
            this.ControlBox = false;
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.txtNewHome);
            this.Controls.Add(this.btnActualizarCasa);
            this.Controls.Add(this.btnCancelarBorrado);
            this.Controls.Add(this.lbl);
            this.Name = "FrmReemplazarCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReemplazarCasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCancelarBorrado;
        private System.Windows.Forms.Button btnActualizarCasa;
        private System.Windows.Forms.TextBox txtNewHome;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
    }
}