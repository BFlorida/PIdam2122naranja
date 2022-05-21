namespace PiNaranja
{
    partial class FrmRegistro
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
            this.lblRegisto = new System.Windows.Forms.Label();
            this.dtgRegistro = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisto
            // 
            this.lblRegisto.AutoSize = true;
            this.lblRegisto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisto.Location = new System.Drawing.Point(37, 24);
            this.lblRegisto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(188, 22);
            this.lblRegisto.TabIndex = 0;
            this.lblRegisto.Text = "REGISTROS myHomy";
            // 
            // dtgRegistro
            // 
            this.dtgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistro.Location = new System.Drawing.Point(37, 49);
            this.dtgRegistro.Name = "dtgRegistro";
            this.dtgRegistro.Size = new System.Drawing.Size(778, 351);
            this.dtgRegistro.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.BackgroundImage = global::PiNaranja.Properties.Resources.door_5_xxl;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(11, 405);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 59);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(846, 469);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgRegistro);
            this.Controls.Add(this.lblRegisto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.DataGridView dtgRegistro;
        private System.Windows.Forms.Button btnSalir;
    }
}