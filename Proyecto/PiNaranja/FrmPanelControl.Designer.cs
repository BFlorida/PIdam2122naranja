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
            this.lblDispositivosRegistrados = new System.Windows.Forms.Label();
            this.lblClick = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.grbAnyadirDispositivo = new System.Windows.Forms.GroupBox();
            this.txtEstancia1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstancia = new System.Windows.Forms.Label();
            this.lblCerti1 = new System.Windows.Forms.Label();
            this.btnAgregarDispositivo = new System.Windows.Forms.Button();
            this.lblNombreDis = new System.Windows.Forms.Label();
            this.cmbCertificado = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.grbModificar = new System.Windows.Forms.GroupBox();
            this.cmbDispositivos2 = new System.Windows.Forms.TextBox();
            this.txtEuros2 = new System.Windows.Forms.TextBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtW2 = new System.Windows.Forms.TextBox();
            this.cmbCertificado2 = new System.Windows.Forms.ComboBox();
            this.lblW2 = new System.Windows.Forms.Label();
            this.cmbTipo2 = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblCertificado2 = new System.Windows.Forms.Label();
            this.txtEstancia2 = new System.Windows.Forms.TextBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.lblEstancia2 = new System.Windows.Forms.Label();
            this.lblPanelControl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTemporizador = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnDeleteHome = new System.Windows.Forms.Button();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnMostrarModDis = new System.Windows.Forms.Button();
            this.btnMostrarDis = new System.Windows.Forms.Button();
            this.grbtemporizadores = new System.Windows.Forms.GroupBox();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.lblFaltan = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.mtxtTemp = new System.Windows.Forms.MaskedTextBox();
            this.tmrCrono = new System.Windows.Forms.Timer(this.components);
            this.tmrCrono2 = new System.Windows.Forms.Timer(this.components);
            this.lblnamehouse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.grbAnyadirDispositivo.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.grbtemporizadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv
            // 
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(177, 369);
            this.dtv.Name = "dtv";
            this.dtv.RowHeadersWidth = 51;
            this.dtv.Size = new System.Drawing.Size(856, 231);
            this.dtv.TabIndex = 0;
            this.dtv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CellClick);
            this.dtv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CellContentClick);
            this.dtv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CellDoubleClick);
            // 
            // lblDispositivosRegistrados
            // 
            this.lblDispositivosRegistrados.AutoSize = true;
            this.lblDispositivosRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDispositivosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivosRegistrados.Location = new System.Drawing.Point(177, 344);
            this.lblDispositivosRegistrados.Name = "lblDispositivosRegistrados";
            this.lblDispositivosRegistrados.Size = new System.Drawing.Size(181, 22);
            this.lblDispositivosRegistrados.TabIndex = 2;
            this.lblDispositivosRegistrados.Text = "DispositivosRegistrados";
            this.lblDispositivosRegistrados.Visible = false;
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(174, 609);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(335, 13);
            this.lblClick.TabIndex = 7;
            this.lblClick.Text = "Realiza click sobre la linea para seleccionar la Estancia o el Dispositivo";
            this.lblClick.Visible = false;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 41F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReloj.Location = new System.Drawing.Point(492, 17);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(330, 63);
            this.lblReloj.TabIndex = 18;
            this.lblReloj.Text = "Reloj digital";
            this.lblReloj.Click += new System.EventHandler(this.lblReloj_Click);
            // 
            // grbAnyadirDispositivo
            // 
            this.grbAnyadirDispositivo.Controls.Add(this.txtEstancia1);
            this.grbAnyadirDispositivo.Controls.Add(this.txtNombre);
            this.grbAnyadirDispositivo.Controls.Add(this.lblEstancia);
            this.grbAnyadirDispositivo.Controls.Add(this.lblCerti1);
            this.grbAnyadirDispositivo.Controls.Add(this.btnAgregarDispositivo);
            this.grbAnyadirDispositivo.Controls.Add(this.lblNombreDis);
            this.grbAnyadirDispositivo.Controls.Add(this.cmbCertificado);
            this.grbAnyadirDispositivo.Controls.Add(this.lblTipo);
            this.grbAnyadirDispositivo.Controls.Add(this.cmbTipo);
            this.grbAnyadirDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnyadirDispositivo.Location = new System.Drawing.Point(185, 83);
            this.grbAnyadirDispositivo.Name = "grbAnyadirDispositivo";
            this.grbAnyadirDispositivo.Size = new System.Drawing.Size(495, 149);
            this.grbAnyadirDispositivo.TabIndex = 21;
            this.grbAnyadirDispositivo.TabStop = false;
            this.grbAnyadirDispositivo.Text = "Dispositivos";
            this.grbAnyadirDispositivo.Visible = false;
            // 
            // txtEstancia1
            // 
            this.txtEstancia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstancia1.Location = new System.Drawing.Point(354, 74);
            this.txtEstancia1.Name = "txtEstancia1";
            this.txtEstancia1.Size = new System.Drawing.Size(81, 23);
            this.txtEstancia1.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(95, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(81, 23);
            this.txtNombre.TabIndex = 35;
            // 
            // lblEstancia
            // 
            this.lblEstancia.AutoSize = true;
            this.lblEstancia.Location = new System.Drawing.Point(273, 74);
            this.lblEstancia.Name = "lblEstancia";
            this.lblEstancia.Size = new System.Drawing.Size(75, 20);
            this.lblEstancia.TabIndex = 32;
            this.lblEstancia.Text = "Estancia:";
            // 
            // lblCerti1
            // 
            this.lblCerti1.AutoSize = true;
            this.lblCerti1.Location = new System.Drawing.Point(15, 71);
            this.lblCerti1.Name = "lblCerti1";
            this.lblCerti1.Size = new System.Drawing.Size(93, 20);
            this.lblCerti1.TabIndex = 29;
            this.lblCerti1.Text = "Certificado: ";
            // 
            // btnAgregarDispositivo
            // 
            this.btnAgregarDispositivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDispositivo.Location = new System.Drawing.Point(327, 108);
            this.btnAgregarDispositivo.Name = "btnAgregarDispositivo";
            this.btnAgregarDispositivo.Size = new System.Drawing.Size(145, 32);
            this.btnAgregarDispositivo.TabIndex = 28;
            this.btnAgregarDispositivo.Text = "Agregar Dispositivo";
            this.btnAgregarDispositivo.UseVisualStyleBackColor = false;
            this.btnAgregarDispositivo.Click += new System.EventHandler(this.btnAgregarDispositivo_Click);
            // 
            // lblNombreDis
            // 
            this.lblNombreDis.AutoSize = true;
            this.lblNombreDis.Location = new System.Drawing.Point(15, 35);
            this.lblNombreDis.Name = "lblNombreDis";
            this.lblNombreDis.Size = new System.Drawing.Size(69, 20);
            this.lblNombreDis.TabIndex = 2;
            this.lblNombreDis.Text = "Nombre:";
            this.lblNombreDis.Click += new System.EventHandler(this.lblNombreDis_Click);
            // 
            // cmbCertificado
            // 
            this.cmbCertificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCertificado.FormattingEnabled = true;
            this.cmbCertificado.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.cmbCertificado.Location = new System.Drawing.Point(114, 71);
            this.cmbCertificado.Name = "cmbCertificado";
            this.cmbCertificado.Size = new System.Drawing.Size(114, 28);
            this.cmbCertificado.TabIndex = 27;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(273, 34);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Lavadora",
            "Horno",
            "Lavavajillas",
            "TV",
            "Luces",
            "Persianas",
            "Sistema de Riego"});
            this.cmbTipo.Location = new System.Drawing.Point(327, 35);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(155, 28);
            this.cmbTipo.TabIndex = 25;
            // 
            // grbModificar
            // 
            this.grbModificar.Controls.Add(this.cmbDispositivos2);
            this.grbModificar.Controls.Add(this.txtEuros2);
            this.grbModificar.Controls.Add(this.lblPrecio2);
            this.grbModificar.Controls.Add(this.btnEliminar);
            this.grbModificar.Controls.Add(this.txtW2);
            this.grbModificar.Controls.Add(this.cmbCertificado2);
            this.grbModificar.Controls.Add(this.lblW2);
            this.grbModificar.Controls.Add(this.cmbTipo2);
            this.grbModificar.Controls.Add(this.btnModificar);
            this.grbModificar.Controls.Add(this.lblCertificado2);
            this.grbModificar.Controls.Add(this.txtEstancia2);
            this.grbModificar.Controls.Add(this.lblDispositivo);
            this.grbModificar.Controls.Add(this.lblTipo2);
            this.grbModificar.Controls.Add(this.lblEstancia2);
            this.grbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificar.Location = new System.Drawing.Point(182, 83);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(498, 149);
            this.grbModificar.TabIndex = 31;
            this.grbModificar.TabStop = false;
            this.grbModificar.Text = "Modificar Dispositivo";
            this.grbModificar.Visible = false;
            // 
            // cmbDispositivos2
            // 
            this.cmbDispositivos2.Location = new System.Drawing.Point(101, 38);
            this.cmbDispositivos2.Name = "cmbDispositivos2";
            this.cmbDispositivos2.ReadOnly = true;
            this.cmbDispositivos2.Size = new System.Drawing.Size(100, 26);
            this.cmbDispositivos2.TabIndex = 35;
            // 
            // txtEuros2
            // 
            this.txtEuros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuros2.Location = new System.Drawing.Point(173, 110);
            this.txtEuros2.Name = "txtEuros2";
            this.txtEuros2.Size = new System.Drawing.Size(60, 23);
            this.txtEuros2.TabIndex = 34;
            this.txtEuros2.Visible = false;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(154, 110);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(22, 20);
            this.lblPrecio2.TabIndex = 33;
            this.lblPrecio2.Text = "€:";
            this.lblPrecio2.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.BackgroundImage = global::PiNaranja.Properties.Resources._9035535_trash_outline_icon;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(402, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 32);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtW2
            // 
            this.txtW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtW2.Location = new System.Drawing.Point(87, 110);
            this.txtW2.Name = "txtW2";
            this.txtW2.Size = new System.Drawing.Size(62, 23);
            this.txtW2.TabIndex = 30;
            this.txtW2.Visible = false;
            // 
            // cmbCertificado2
            // 
            this.cmbCertificado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCertificado2.FormattingEnabled = true;
            this.cmbCertificado2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.cmbCertificado2.Location = new System.Drawing.Point(101, 77);
            this.cmbCertificado2.Name = "cmbCertificado2";
            this.cmbCertificado2.Size = new System.Drawing.Size(114, 28);
            this.cmbCertificado2.TabIndex = 27;
            // 
            // lblW2
            // 
            this.lblW2.AutoSize = true;
            this.lblW2.Location = new System.Drawing.Point(32, 109);
            this.lblW2.Name = "lblW2";
            this.lblW2.Size = new System.Drawing.Size(58, 20);
            this.lblW2.TabIndex = 29;
            this.lblW2.Text = "Vatios:";
            this.lblW2.Visible = false;
            // 
            // cmbTipo2
            // 
            this.cmbTipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo2.FormattingEnabled = true;
            this.cmbTipo2.Items.AddRange(new object[] {
            "Lavadora",
            "Horno",
            "Lavavajillas",
            "TV",
            "Luces",
            "Persianas",
            "Sistema de Riego"});
            this.cmbTipo2.Location = new System.Drawing.Point(333, 33);
            this.cmbTipo2.Name = "cmbTipo2";
            this.cmbTipo2.Size = new System.Drawing.Size(149, 28);
            this.cmbTipo2.TabIndex = 25;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(295, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 32);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Cambiar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblCertificado2
            // 
            this.lblCertificado2.AutoSize = true;
            this.lblCertificado2.Location = new System.Drawing.Point(3, 75);
            this.lblCertificado2.Name = "lblCertificado2";
            this.lblCertificado2.Size = new System.Drawing.Size(89, 20);
            this.lblCertificado2.TabIndex = 26;
            this.lblCertificado2.Text = "Certificado:";
            // 
            // txtEstancia2
            // 
            this.txtEstancia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstancia2.Location = new System.Drawing.Point(333, 64);
            this.txtEstancia2.Name = "txtEstancia2";
            this.txtEstancia2.Size = new System.Drawing.Size(81, 23);
            this.txtEstancia2.TabIndex = 3;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Location = new System.Drawing.Point(6, 38);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(93, 20);
            this.lblDispositivo.TabIndex = 2;
            this.lblDispositivo.Text = "Dispositivo: ";
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Location = new System.Drawing.Point(273, 33);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(43, 20);
            this.lblTipo2.TabIndex = 1;
            this.lblTipo2.Text = "Tipo:";
            // 
            // lblEstancia2
            // 
            this.lblEstancia2.AutoSize = true;
            this.lblEstancia2.Location = new System.Drawing.Point(251, 67);
            this.lblEstancia2.Name = "lblEstancia2";
            this.lblEstancia2.Size = new System.Drawing.Size(79, 20);
            this.lblEstancia2.TabIndex = 0;
            this.lblEstancia2.Text = "Estancia: ";
            // 
            // lblPanelControl
            // 
            this.lblPanelControl.AutoSize = true;
            this.lblPanelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelControl.Location = new System.Drawing.Point(177, 7);
            this.lblPanelControl.Name = "lblPanelControl";
            this.lblPanelControl.Size = new System.Drawing.Size(262, 25);
            this.lblPanelControl.TabIndex = 22;
            this.lblPanelControl.Text = "Panel de Control myHomy";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(177, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(828, 4);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(78, 24);
            this.lblIdioma.TabIndex = 38;
            this.lblIdioma.Text = "Idioma:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(941, 7);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(92, 21);
            this.cmbIdioma.TabIndex = 39;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(934, 323);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(99, 40);
            this.btnApagar.TabIndex = 45;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.Location = new System.Drawing.Point(824, 323);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(98, 40);
            this.btnEncender.TabIndex = 44;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.btnTemporizador);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.btnDeleteHome);
            this.groupBox1.Controls.Add(this.btnEliminarCuenta);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Controls.Add(this.ptbLogo);
            this.groupBox1.Controls.Add(this.btnMostrarModDis);
            this.groupBox1.Controls.Add(this.btnMostrarDis);
            this.groupBox1.Location = new System.Drawing.Point(-1, -14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 679);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PiNaranja.Properties.Resources.time_13_xxl;
            this.pictureBox3.Location = new System.Drawing.Point(10, 227);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // btnTemporizador
            // 
            this.btnTemporizador.FlatAppearance.BorderSize = 0;
            this.btnTemporizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemporizador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemporizador.Location = new System.Drawing.Point(49, 227);
            this.btnTemporizador.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemporizador.Name = "btnTemporizador";
            this.btnTemporizador.Size = new System.Drawing.Size(106, 41);
            this.btnTemporizador.TabIndex = 25;
            this.btnTemporizador.Text = "Temporizador";
            this.btnTemporizador.UseVisualStyleBackColor = true;
            this.btnTemporizador.Click += new System.EventHandler(this.btnTemporizador_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PiNaranja.Properties.Resources.trash_xxl;
            this.pictureBox7.Location = new System.Drawing.Point(10, 424);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PiNaranja.Properties.Resources.disapprove_xxl;
            this.pictureBox6.Location = new System.Drawing.Point(10, 358);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // btnDeleteHome
            // 
            this.btnDeleteHome.FlatAppearance.BorderSize = 0;
            this.btnDeleteHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteHome.Location = new System.Drawing.Point(49, 424);
            this.btnDeleteHome.Name = "btnDeleteHome";
            this.btnDeleteHome.Size = new System.Drawing.Size(106, 41);
            this.btnDeleteHome.TabIndex = 22;
            this.btnDeleteHome.Text = "Eliminar Casa";
            this.btnDeleteHome.UseVisualStyleBackColor = true;
            this.btnDeleteHome.Click += new System.EventHandler(this.btnDeleteHome_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(49, 358);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(106, 41);
            this.btnEliminarCuenta.TabIndex = 21;
            this.btnEliminarCuenta.Text = "Eliminar Cuenta";
            this.btnEliminarCuenta.UseVisualStyleBackColor = true;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.BackgroundImage = global::PiNaranja.Properties.Resources.door_5_xxl;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(49, 599);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 59);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PiNaranja.Properties.Resources.literature_xxl;
            this.pictureBox4.Location = new System.Drawing.Point(10, 293);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PiNaranja.Properties.Resources.website_design_2_xxl;
            this.pictureBox2.Location = new System.Drawing.Point(10, 158);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PiNaranja.Properties.Resources.box_5_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(10, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistro.Location = new System.Drawing.Point(49, 293);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(106, 41);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registros";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.button3_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(0, 13);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(172, 59);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 19;
            this.ptbLogo.TabStop = false;
            // 
            // btnMostrarModDis
            // 
            this.btnMostrarModDis.FlatAppearance.BorderSize = 0;
            this.btnMostrarModDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarModDis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarModDis.Location = new System.Drawing.Point(53, 157);
            this.btnMostrarModDis.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarModDis.Name = "btnMostrarModDis";
            this.btnMostrarModDis.Size = new System.Drawing.Size(114, 41);
            this.btnMostrarModDis.TabIndex = 1;
            this.btnMostrarModDis.Text = "Modificar Dispositivo";
            this.btnMostrarModDis.UseVisualStyleBackColor = true;
            this.btnMostrarModDis.Click += new System.EventHandler(this.btnMostrarModDis_Click);
            // 
            // btnMostrarDis
            // 
            this.btnMostrarDis.FlatAppearance.BorderSize = 0;
            this.btnMostrarDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarDis.Location = new System.Drawing.Point(49, 89);
            this.btnMostrarDis.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarDis.Name = "btnMostrarDis";
            this.btnMostrarDis.Size = new System.Drawing.Size(118, 41);
            this.btnMostrarDis.TabIndex = 0;
            this.btnMostrarDis.Text = "Nuevo DIspositivo";
            this.btnMostrarDis.UseVisualStyleBackColor = true;
            this.btnMostrarDis.Click += new System.EventHandler(this.btnMostrarDis_Click);
            // 
            // grbtemporizadores
            // 
            this.grbtemporizadores.Controls.Add(this.txtTemp1);
            this.grbtemporizadores.Controls.Add(this.lblFaltan);
            this.grbtemporizadores.Controls.Add(this.btnParar);
            this.grbtemporizadores.Controls.Add(this.btnConfigurar);
            this.grbtemporizadores.Controls.Add(this.mtxtTemp);
            this.grbtemporizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtemporizadores.Location = new System.Drawing.Point(824, 82);
            this.grbtemporizadores.Margin = new System.Windows.Forms.Padding(2);
            this.grbtemporizadores.Name = "grbtemporizadores";
            this.grbtemporizadores.Padding = new System.Windows.Forms.Padding(2);
            this.grbtemporizadores.Size = new System.Drawing.Size(209, 172);
            this.grbtemporizadores.TabIndex = 42;
            this.grbtemporizadores.TabStop = false;
            this.grbtemporizadores.Text = "Temporizadores ";
            this.grbtemporizadores.Visible = false;
            // 
            // txtTemp1
            // 
            this.txtTemp1.Enabled = false;
            this.txtTemp1.Location = new System.Drawing.Point(17, 36);
            this.txtTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.ReadOnly = true;
            this.txtTemp1.Size = new System.Drawing.Size(182, 26);
            this.txtTemp1.TabIndex = 33;
            this.txtTemp1.TextChanged += new System.EventHandler(this.txtTemp1_TextChanged);
            // 
            // lblFaltan
            // 
            this.lblFaltan.AutoSize = true;
            this.lblFaltan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltan.Location = new System.Drawing.Point(12, 145);
            this.lblFaltan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaltan.Name = "lblFaltan";
            this.lblFaltan.Size = new System.Drawing.Size(0, 25);
            this.lblFaltan.TabIndex = 6;
            this.lblFaltan.Click += new System.EventHandler(this.lblFaltan_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(115, 63);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(84, 28);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Detener";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Location = new System.Drawing.Point(17, 99);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(182, 33);
            this.btnConfigurar.TabIndex = 2;
            this.btnConfigurar.Text = "Configurar/Reanudar";
            this.btnConfigurar.UseVisualStyleBackColor = false;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // mtxtTemp
            // 
            this.mtxtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTemp.Location = new System.Drawing.Point(17, 63);
            this.mtxtTemp.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTemp.Mask = "00:00:00";
            this.mtxtTemp.Name = "mtxtTemp";
            this.mtxtTemp.Size = new System.Drawing.Size(94, 29);
            this.mtxtTemp.TabIndex = 0;
            this.mtxtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtTemp.ValidatingType = typeof(System.DateTime);
            // 
            // tmrCrono
            // 
            this.tmrCrono.Interval = 1000;
            this.tmrCrono.Tick += new System.EventHandler(this.tmrCrono_Tick);
            // 
            // tmrCrono2
            // 
            this.tmrCrono2.Interval = 1000;
            // 
            // lblnamehouse
            // 
            this.lblnamehouse.AutoSize = true;
            this.lblnamehouse.Location = new System.Drawing.Point(182, 57);
            this.lblnamehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnamehouse.Name = "lblnamehouse";
            this.lblnamehouse.Size = new System.Drawing.Size(72, 13);
            this.lblnamehouse.TabIndex = 43;
            this.lblnamehouse.Text = "lblnamehouse";
            // 
            // FrmPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1058, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblnamehouse);
            this.Controls.Add(this.grbtemporizadores);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbModificar);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPanelControl);
            this.Controls.Add(this.grbAnyadirDispositivo);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.lblDispositivosRegistrados);
            this.Controls.Add(this.dtv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPanelControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.grbAnyadirDispositivo.ResumeLayout(false);
            this.grbAnyadirDispositivo.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.grbtemporizadores.ResumeLayout(false);
            this.grbtemporizadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.Label lblDispositivosRegistrados;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.GroupBox grbAnyadirDispositivo;
        private System.Windows.Forms.Label lblNombreDis;
        private System.Windows.Forms.Label lblPanelControl;
        private System.Windows.Forms.ComboBox cmbCertificado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregarDispositivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grbModificar;
        private System.Windows.Forms.TextBox txtEuros2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtW2;
        private System.Windows.Forms.Label lblW2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbCertificado2;
        private System.Windows.Forms.Label lblCertificado2;
        private System.Windows.Forms.ComboBox cmbTipo2;
        private System.Windows.Forms.TextBox txtEstancia2;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.Label lblEstancia2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnMostrarModDis;
        private System.Windows.Forms.Button btnMostrarDis;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbtemporizadores;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.MaskedTextBox mtxtTemp;
        private System.Windows.Forms.Label lblFaltan;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer tmrCrono;
        private System.Windows.Forms.Timer tmrCrono2;
        private System.Windows.Forms.Label lblnamehouse;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.Button btnDeleteHome;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnTemporizador;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCerti1;
        private System.Windows.Forms.Label lblEstancia;
        private System.Windows.Forms.TextBox txtEstancia1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox cmbDispositivos2;
    }
}