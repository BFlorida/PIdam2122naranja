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
            this.lblNuevaCasa = new System.Windows.Forms.Label();
            this.btnCancelarBorrado = new System.Windows.Forms.Button();
            this.btnActualizarCasa = new System.Windows.Forms.Button();
            this.txtNewHome = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCasa
            // 
            this.lblNuevaCasa.AutoSize = true;
            this.lblNuevaCasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNuevaCasa.Location = new System.Drawing.Point(234, 116);
            this.lblNuevaCasa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNuevaCasa.Name = "lblNuevaCasa";
            this.lblNuevaCasa.Size = new System.Drawing.Size(234, 25);
            this.lblNuevaCasa.TabIndex = 0;
            this.lblNuevaCasa.Text = "Nombre de la nueva casa";
            // 
            // btnCancelarBorrado
            // 
            this.btnCancelarBorrado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarBorrado.CausesValidation = false;
            this.btnCancelarBorrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBorrado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarBorrado.Location = new System.Drawing.Point(306, 251);
            this.btnCancelarBorrado.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarBorrado.Name = "btnCancelarBorrado";
            this.btnCancelarBorrado.Size = new System.Drawing.Size(112, 44);
            this.btnCancelarBorrado.TabIndex = 2;
            this.btnCancelarBorrado.Text = "Cancelar";
            this.btnCancelarBorrado.UseVisualStyleBackColor = false;
            this.btnCancelarBorrado.Click += new System.EventHandler(this.btnCancelarBorrado_Click);
            // 
            // btnActualizarCasa
            // 
            this.btnActualizarCasa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizarCasa.Location = new System.Drawing.Point(268, 191);
            this.btnActualizarCasa.Margin = new System.Windows.Forms.Padding(6);
            this.btnActualizarCasa.Name = "btnActualizarCasa";
            this.btnActualizarCasa.Size = new System.Drawing.Size(184, 44);
            this.btnActualizarCasa.TabIndex = 3;
            this.btnActualizarCasa.Text = "btnActualizarCasa";
            this.btnActualizarCasa.UseVisualStyleBackColor = false;
            this.btnActualizarCasa.Click += new System.EventHandler(this.btnActualizarCasa_Click);
            // 
            // txtNewHome
            // 
            this.txtNewHome.Location = new System.Drawing.Point(230, 146);
            this.txtNewHome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewHome.Name = "txtNewHome";
            this.txtNewHome.Size = new System.Drawing.Size(254, 30);
            this.txtNewHome.TabIndex = 5;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(513, 30);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(180, 33);
            this.cmbIdioma.TabIndex = 16;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(416, 33);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(70, 25);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "label1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PiNaranja.Properties.Resources.Logo_MyHomy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReemplazarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(706, 389);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.txtNewHome);
            this.Controls.Add(this.btnActualizarCasa);
            this.Controls.Add(this.btnCancelarBorrado);
            this.Controls.Add(this.lblNuevaCasa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmReemplazarCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReemplazarCasa";
            this.Load += new System.EventHandler(this.FrmReemplazarCasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCasa;
        private System.Windows.Forms.Button btnCancelarBorrado;
        private System.Windows.Forms.Button btnActualizarCasa;
        private System.Windows.Forms.TextBox txtNewHome;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}