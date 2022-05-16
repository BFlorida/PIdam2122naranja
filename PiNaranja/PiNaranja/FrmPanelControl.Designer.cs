namespace PiNaranja
{
    partial class FrmPanelControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelControl));
            this.dtv = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblEstanciasRegistradas = new System.Windows.Forms.Label();
            this.lblDispositivosRegistrados = new System.Windows.Forms.Label();
            this.lblTotalConsumo = new System.Windows.Forms.Label();
            this.lblTotalConsumo1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.grbCrearHogar = new System.Windows.Forms.GroupBox();
            this.btnAgregarHogar = new System.Windows.Forms.Button();
            this.txtDireccionHogar = new System.Windows.Forms.TextBox();
            this.btnEliminarHogar = new System.Windows.Forms.Button();
            this.txtNombreHogar = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreHogar = new System.Windows.Forms.Label();
            this.grbCreaEstancia = new System.Windows.Forms.GroupBox();
            this.btnAgregarEstancia = new System.Windows.Forms.Button();
            this.cmbSelecHogar = new System.Windows.Forms.ComboBox();
            this.btnEliminarEstancia = new System.Windows.Forms.Button();
            this.txtEstancia = new System.Windows.Forms.TextBox();
            this.lblHogar = new System.Windows.Forms.Label();
            this.lblEstancia = new System.Windows.Forms.Label();
            this.grbAnyadirDispositivo = new System.Windows.Forms.GroupBox();
            this.btnAgregarDispositivo = new System.Windows.Forms.Button();
            this.btnEliminaDispositivo = new System.Windows.Forms.Button();
            this.cmbSelecEstancia = new System.Windows.Forms.ComboBox();
            this.lblEstanciaDispo = new System.Windows.Forms.Label();
            this.cmbHogar = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblNombreDis = new System.Windows.Forms.Label();
            this.lblSelecHogar = new System.Windows.Forms.Label();
            this.lblConsumoBase = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblPanelControl = new System.Windows.Forms.Label();
            this.ptbSalida = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.grbCrearHogar.SuspendLayout();
            this.grbCreaEstancia.SuspendLayout();
            this.grbAnyadirDispositivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv
            // 
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(49, 551);
            this.dtv.Margin = new System.Windows.Forms.Padding(4);
            this.dtv.Name = "dtv";
            this.dtv.RowHeadersWidth = 51;
            this.dtv.Size = new System.Drawing.Size(624, 178);
            this.dtv.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(713, 551);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(624, 178);
            this.dataGridView2.TabIndex = 1;
            // 
            // lblEstanciasRegistradas
            // 
            this.lblEstanciasRegistradas.AutoSize = true;
            this.lblEstanciasRegistradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstanciasRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstanciasRegistradas.Location = new System.Drawing.Point(49, 521);
            this.lblEstanciasRegistradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstanciasRegistradas.Name = "lblEstanciasRegistradas";
            this.lblEstanciasRegistradas.Size = new System.Drawing.Size(207, 27);
            this.lblEstanciasRegistradas.TabIndex = 2;
            this.lblEstanciasRegistradas.Text = "Estancias Registradas";
            // 
            // lblDispositivosRegistrados
            // 
            this.lblDispositivosRegistrados.AutoSize = true;
            this.lblDispositivosRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDispositivosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivosRegistrados.Location = new System.Drawing.Point(713, 521);
            this.lblDispositivosRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispositivosRegistrados.Name = "lblDispositivosRegistrados";
            this.lblDispositivosRegistrados.Size = new System.Drawing.Size(226, 27);
            this.lblDispositivosRegistrados.TabIndex = 3;
            this.lblDispositivosRegistrados.Text = "Dispositivos Registrados";
            // 
            // lblTotalConsumo
            // 
            this.lblTotalConsumo.AutoSize = true;
            this.lblTotalConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsumo.Location = new System.Drawing.Point(708, 734);
            this.lblTotalConsumo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalConsumo.Name = "lblTotalConsumo";
            this.lblTotalConsumo.Size = new System.Drawing.Size(152, 25);
            this.lblTotalConsumo.TabIndex = 4;
            this.lblTotalConsumo.Text = "Total Consumo:";
            // 
            // lblTotalConsumo1
            // 
            this.lblTotalConsumo1.AutoSize = true;
            this.lblTotalConsumo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsumo1.Location = new System.Drawing.Point(876, 734);
            this.lblTotalConsumo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalConsumo1.Name = "lblTotalConsumo1";
            this.lblTotalConsumo1.Size = new System.Drawing.Size(54, 25);
            this.lblTotalConsumo1.TabIndex = 5;
            this.lblTotalConsumo1.Text = "0.00";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(1070, 320);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(267, 42);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "ACCESO A REGISTROS";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(45, 734);
            this.lblClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(395, 15);
            this.lblClick.TabIndex = 7;
            this.lblClick.Text = "Realiza click sobre la linea para seleccionar la Estancia o el Dispositivo";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(1175, 49);
            this.lblReloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(154, 29);
            this.lblReloj.TabIndex = 18;
            this.lblReloj.Text = "Reloj digital";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(49, 14);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(279, 73);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 19;
            this.ptbLogo.TabStop = false;
            // 
            // grbCrearHogar
            // 
            this.grbCrearHogar.Controls.Add(this.btnAgregarHogar);
            this.grbCrearHogar.Controls.Add(this.txtDireccionHogar);
            this.grbCrearHogar.Controls.Add(this.btnEliminarHogar);
            this.grbCrearHogar.Controls.Add(this.txtNombreHogar);
            this.grbCrearHogar.Controls.Add(this.lblDireccion);
            this.grbCrearHogar.Controls.Add(this.lblNombreHogar);
            this.grbCrearHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrearHogar.Location = new System.Drawing.Point(49, 114);
            this.grbCrearHogar.Margin = new System.Windows.Forms.Padding(4);
            this.grbCrearHogar.Name = "grbCrearHogar";
            this.grbCrearHogar.Padding = new System.Windows.Forms.Padding(4);
            this.grbCrearHogar.Size = new System.Drawing.Size(624, 189);
            this.grbCrearHogar.TabIndex = 20;
            this.grbCrearHogar.TabStop = false;
            this.grbCrearHogar.Text = "Crear Hogar";
            // 
            // btnAgregarHogar
            // 
            this.btnAgregarHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHogar.Location = new System.Drawing.Point(8, 137);
            this.btnAgregarHogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarHogar.Name = "btnAgregarHogar";
            this.btnAgregarHogar.Size = new System.Drawing.Size(193, 44);
            this.btnAgregarHogar.TabIndex = 32;
            this.btnAgregarHogar.Text = "Agregar Hogar";
            this.btnAgregarHogar.UseVisualStyleBackColor = true;
            this.btnAgregarHogar.Click += new System.EventHandler(this.btnAgregarHogar_Click);
            // 
            // txtDireccionHogar
            // 
            this.txtDireccionHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionHogar.Location = new System.Drawing.Point(141, 73);
            this.txtDireccionHogar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionHogar.Name = "txtDireccionHogar";
            this.txtDireccionHogar.Size = new System.Drawing.Size(448, 26);
            this.txtDireccionHogar.TabIndex = 5;
            // 
            // btnEliminarHogar
            // 
            this.btnEliminarHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHogar.Location = new System.Drawing.Point(435, 137);
            this.btnEliminarHogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarHogar.Name = "btnEliminarHogar";
            this.btnEliminarHogar.Size = new System.Drawing.Size(181, 44);
            this.btnEliminarHogar.TabIndex = 31;
            this.btnEliminarHogar.Text = "Elimina Hogar";
            this.btnEliminarHogar.UseVisualStyleBackColor = true;
            // 
            // txtNombreHogar
            // 
            this.txtNombreHogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHogar.Location = new System.Drawing.Point(200, 42);
            this.txtNombreHogar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreHogar.Name = "txtNombreHogar";
            this.txtNombreHogar.Size = new System.Drawing.Size(236, 26);
            this.txtNombreHogar.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 76);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 25);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombreHogar
            // 
            this.lblNombreHogar.AutoSize = true;
            this.lblNombreHogar.Location = new System.Drawing.Point(25, 40);
            this.lblNombreHogar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHogar.Name = "lblNombreHogar";
            this.lblNombreHogar.Size = new System.Drawing.Size(176, 25);
            this.lblNombreHogar.TabIndex = 1;
            this.lblNombreHogar.Text = "Nombre del Hogar:";
            // 
            // grbCreaEstancia
            // 
            this.grbCreaEstancia.Controls.Add(this.btnAgregarEstancia);
            this.grbCreaEstancia.Controls.Add(this.cmbSelecHogar);
            this.grbCreaEstancia.Controls.Add(this.btnEliminarEstancia);
            this.grbCreaEstancia.Controls.Add(this.txtEstancia);
            this.grbCreaEstancia.Controls.Add(this.lblHogar);
            this.grbCreaEstancia.Controls.Add(this.lblEstancia);
            this.grbCreaEstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCreaEstancia.Location = new System.Drawing.Point(49, 311);
            this.grbCreaEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.grbCreaEstancia.Name = "grbCreaEstancia";
            this.grbCreaEstancia.Padding = new System.Windows.Forms.Padding(4);
            this.grbCreaEstancia.Size = new System.Drawing.Size(624, 165);
            this.grbCreaEstancia.TabIndex = 21;
            this.grbCreaEstancia.TabStop = false;
            this.grbCreaEstancia.Text = "Añade una Estancia";
            // 
            // btnAgregarEstancia
            // 
            this.btnAgregarEstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstancia.Location = new System.Drawing.Point(8, 113);
            this.btnAgregarEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEstancia.Name = "btnAgregarEstancia";
            this.btnAgregarEstancia.Size = new System.Drawing.Size(193, 44);
            this.btnAgregarEstancia.TabIndex = 30;
            this.btnAgregarEstancia.Text = "Agregar Estancia";
            this.btnAgregarEstancia.UseVisualStyleBackColor = true;
            // 
            // cmbSelecHogar
            // 
            this.cmbSelecHogar.FormattingEnabled = true;
            this.cmbSelecHogar.Location = new System.Drawing.Point(104, 39);
            this.cmbSelecHogar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelecHogar.Name = "cmbSelecHogar";
            this.cmbSelecHogar.Size = new System.Drawing.Size(160, 33);
            this.cmbSelecHogar.TabIndex = 29;
            // 
            // btnEliminarEstancia
            // 
            this.btnEliminarEstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstancia.Location = new System.Drawing.Point(435, 113);
            this.btnEliminarEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEstancia.Name = "btnEliminarEstancia";
            this.btnEliminarEstancia.Size = new System.Drawing.Size(181, 44);
            this.btnEliminarEstancia.TabIndex = 23;
            this.btnEliminarEstancia.Text = "Eliminar Estancia";
            this.btnEliminarEstancia.UseVisualStyleBackColor = true;
            // 
            // txtEstancia
            // 
            this.txtEstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstancia.Location = new System.Drawing.Point(399, 42);
            this.txtEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstancia.Name = "txtEstancia";
            this.txtEstancia.Size = new System.Drawing.Size(129, 26);
            this.txtEstancia.TabIndex = 4;
            // 
            // lblHogar
            // 
            this.lblHogar.AutoSize = true;
            this.lblHogar.Location = new System.Drawing.Point(25, 42);
            this.lblHogar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHogar.Name = "lblHogar";
            this.lblHogar.Size = new System.Drawing.Size(71, 25);
            this.lblHogar.TabIndex = 28;
            this.lblHogar.Text = "Hogar:";
            // 
            // lblEstancia
            // 
            this.lblEstancia.AutoSize = true;
            this.lblEstancia.Location = new System.Drawing.Point(298, 41);
            this.lblEstancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstancia.Name = "lblEstancia";
            this.lblEstancia.Size = new System.Drawing.Size(93, 25);
            this.lblEstancia.TabIndex = 1;
            this.lblEstancia.Text = "Estancia:";
            // 
            // grbAnyadirDispositivo
            // 
            this.grbAnyadirDispositivo.Controls.Add(this.btnAgregarDispositivo);
            this.grbAnyadirDispositivo.Controls.Add(this.btnEliminaDispositivo);
            this.grbAnyadirDispositivo.Controls.Add(this.cmbSelecEstancia);
            this.grbAnyadirDispositivo.Controls.Add(this.lblEstanciaDispo);
            this.grbAnyadirDispositivo.Controls.Add(this.cmbHogar);
            this.grbAnyadirDispositivo.Controls.Add(this.txtNombre);
            this.grbAnyadirDispositivo.Controls.Add(this.textBox6);
            this.grbAnyadirDispositivo.Controls.Add(this.lblNombreDis);
            this.grbAnyadirDispositivo.Controls.Add(this.lblSelecHogar);
            this.grbAnyadirDispositivo.Controls.Add(this.lblConsumoBase);
            this.grbAnyadirDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnyadirDispositivo.Location = new System.Drawing.Point(713, 114);
            this.grbAnyadirDispositivo.Margin = new System.Windows.Forms.Padding(4);
            this.grbAnyadirDispositivo.Name = "grbAnyadirDispositivo";
            this.grbAnyadirDispositivo.Padding = new System.Windows.Forms.Padding(4);
            this.grbAnyadirDispositivo.Size = new System.Drawing.Size(624, 189);
            this.grbAnyadirDispositivo.TabIndex = 21;
            this.grbAnyadirDispositivo.TabStop = false;
            this.grbAnyadirDispositivo.Text = "Dispositivos";
            // 
            // btnAgregarDispositivo
            // 
            this.btnAgregarDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDispositivo.Location = new System.Drawing.Point(9, 137);
            this.btnAgregarDispositivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDispositivo.Name = "btnAgregarDispositivo";
            this.btnAgregarDispositivo.Size = new System.Drawing.Size(217, 44);
            this.btnAgregarDispositivo.TabIndex = 28;
            this.btnAgregarDispositivo.Text = "Agregar Dispositivo";
            this.btnAgregarDispositivo.UseVisualStyleBackColor = true;
            // 
            // btnEliminaDispositivo
            // 
            this.btnEliminaDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaDispositivo.Location = new System.Drawing.Point(399, 137);
            this.btnEliminaDispositivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminaDispositivo.Name = "btnEliminaDispositivo";
            this.btnEliminaDispositivo.Size = new System.Drawing.Size(217, 44);
            this.btnEliminaDispositivo.TabIndex = 24;
            this.btnEliminaDispositivo.Text = "Elimina Dispositivo";
            this.btnEliminaDispositivo.UseVisualStyleBackColor = true;
            // 
            // cmbSelecEstancia
            // 
            this.cmbSelecEstancia.FormattingEnabled = true;
            this.cmbSelecEstancia.Location = new System.Drawing.Point(116, 84);
            this.cmbSelecEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelecEstancia.Name = "cmbSelecEstancia";
            this.cmbSelecEstancia.Size = new System.Drawing.Size(165, 33);
            this.cmbSelecEstancia.TabIndex = 27;
            // 
            // lblEstanciaDispo
            // 
            this.lblEstanciaDispo.AutoSize = true;
            this.lblEstanciaDispo.Location = new System.Drawing.Point(13, 92);
            this.lblEstanciaDispo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstanciaDispo.Name = "lblEstanciaDispo";
            this.lblEstanciaDispo.Size = new System.Drawing.Size(93, 25);
            this.lblEstanciaDispo.TabIndex = 26;
            this.lblEstanciaDispo.Text = "Estancia:";
            // 
            // cmbHogar
            // 
            this.cmbHogar.FormattingEnabled = true;
            this.cmbHogar.Location = new System.Drawing.Point(427, 40);
            this.cmbHogar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHogar.Name = "cmbHogar";
            this.cmbHogar.Size = new System.Drawing.Size(165, 33);
            this.cmbHogar.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(115, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(485, 87);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(107, 26);
            this.textBox6.TabIndex = 3;
            // 
            // lblNombreDis
            // 
            this.lblNombreDis.AutoSize = true;
            this.lblNombreDis.Location = new System.Drawing.Point(20, 43);
            this.lblNombreDis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDis.Name = "lblNombreDis";
            this.lblNombreDis.Size = new System.Drawing.Size(87, 25);
            this.lblNombreDis.TabIndex = 2;
            this.lblNombreDis.Text = "Nombre:";
            // 
            // lblSelecHogar
            // 
            this.lblSelecHogar.AutoSize = true;
            this.lblSelecHogar.Location = new System.Drawing.Point(348, 43);
            this.lblSelecHogar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecHogar.Name = "lblSelecHogar";
            this.lblSelecHogar.Size = new System.Drawing.Size(71, 25);
            this.lblSelecHogar.TabIndex = 1;
            this.lblSelecHogar.Text = "Hogar:";
            // 
            // lblConsumoBase
            // 
            this.lblConsumoBase.AutoSize = true;
            this.lblConsumoBase.Location = new System.Drawing.Point(319, 91);
            this.lblConsumoBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsumoBase.Name = "lblConsumoBase";
            this.lblConsumoBase.Size = new System.Drawing.Size(153, 25);
            this.lblConsumoBase.TabIndex = 0;
            this.lblConsumoBase.Text = "Consumo Base:";
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(716, 453);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(89, 25);
            this.lblCalculo.TabIndex = 36;
            this.lblCalculo.Text = "Cálculo: ";
            // 
            // lblPanelControl
            // 
            this.lblPanelControl.AutoSize = true;
            this.lblPanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPanelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelControl.Location = new System.Drawing.Point(519, 16);
            this.lblPanelControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanelControl.Name = "lblPanelControl";
            this.lblPanelControl.Size = new System.Drawing.Size(335, 31);
            this.lblPanelControl.TabIndex = 22;
            this.lblPanelControl.Text = "Panel de Control myHomy";
            // 
            // ptbSalida
            // 
            this.ptbSalida.Image = ((System.Drawing.Image)(resources.GetObject("ptbSalida.Image")));
            this.ptbSalida.Location = new System.Drawing.Point(1313, 737);
            this.ptbSalida.Margin = new System.Windows.Forms.Padding(4);
            this.ptbSalida.Name = "ptbSalida";
            this.ptbSalida.Size = new System.Drawing.Size(61, 57);
            this.ptbSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalida.TabIndex = 23;
            this.ptbSalida.TabStop = false;
            this.ptbSalida.Click += new System.EventHandler(this.ptbSalida_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1175, 14);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 29);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(713, 320);
            this.btnCalculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(225, 42);
            this.btnCalculo.TabIndex = 37;
            this.btnCalculo.Text = "CONSUMO/HORA";
            this.btnCalculo.UseVisualStyleBackColor = true;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(876, 18);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(99, 29);
            this.lblIdioma.TabIndex = 38;
            this.lblIdioma.Text = "Idioma:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(1011, 21);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 24);
            this.cmbIdioma.TabIndex = 39;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1391, 804);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.ptbSalida);
            this.Controls.Add(this.lblPanelControl);
            this.Controls.Add(this.grbAnyadirDispositivo);
            this.Controls.Add(this.grbCreaEstancia);
            this.Controls.Add(this.grbCrearHogar);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblTotalConsumo1);
            this.Controls.Add(this.lblTotalConsumo);
            this.Controls.Add(this.lblDispositivosRegistrados);
            this.Controls.Add(this.lblEstanciasRegistradas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPanelControl";
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.grbCrearHogar.ResumeLayout(false);
            this.grbCrearHogar.PerformLayout();
            this.grbCreaEstancia.ResumeLayout(false);
            this.grbCreaEstancia.PerformLayout();
            this.grbAnyadirDispositivo.ResumeLayout(false);
            this.grbAnyadirDispositivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblEstanciasRegistradas;
        private System.Windows.Forms.Label lblDispositivosRegistrados;
        private System.Windows.Forms.Label lblTotalConsumo;
        private System.Windows.Forms.Label lblTotalConsumo1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.GroupBox grbCrearHogar;
        private System.Windows.Forms.TextBox txtDireccionHogar;
        private System.Windows.Forms.TextBox txtNombreHogar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreHogar;
        private System.Windows.Forms.GroupBox grbCreaEstancia;
        private System.Windows.Forms.TextBox txtEstancia;
        private System.Windows.Forms.Label lblEstancia;
        private System.Windows.Forms.GroupBox grbAnyadirDispositivo;
        private System.Windows.Forms.Label lblNombreDis;
        private System.Windows.Forms.Label lblSelecHogar;
        private System.Windows.Forms.Label lblConsumoBase;
        private System.Windows.Forms.Label lblPanelControl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmbSelecEstancia;
        private System.Windows.Forms.Label lblEstanciaDispo;
        private System.Windows.Forms.ComboBox cmbHogar;
        private System.Windows.Forms.Button btnEliminarEstancia;
        private System.Windows.Forms.Button btnEliminaDispositivo;
        private System.Windows.Forms.Button btnAgregarHogar;
        private System.Windows.Forms.Button btnEliminarHogar;
        private System.Windows.Forms.Button btnAgregarEstancia;
        private System.Windows.Forms.ComboBox cmbSelecHogar;
        private System.Windows.Forms.Label lblHogar;
        private System.Windows.Forms.Button btnAgregarDispositivo;
        private System.Windows.Forms.PictureBox ptbSalida;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Timer timer1;
    }
}