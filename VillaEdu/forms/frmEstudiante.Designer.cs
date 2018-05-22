namespace VillaEdu.forms
{
    partial class frmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PageApoderado = new MetroFramework.Controls.MetroTabPage();
            this.btnRestaurarApoderado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoApoderado = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularApoderado = new System.Windows.Forms.MaskedTextBox();
            this.txtDNIApoderado = new System.Windows.Forms.MaskedTextBox();
            this.btnSeleccionarApoderado = new System.Windows.Forms.Button();
            this.txtCorreoApoderado = new System.Windows.Forms.MaskedTextBox();
            this.lblIDApoderado = new System.Windows.Forms.Label();
            this.lblApoderado = new System.Windows.Forms.Label();
            this.txtDireccionApoderado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreApoderado = new System.Windows.Forms.TextBox();
            this.txtMaternoApoderado = new System.Windows.Forms.TextBox();
            this.txtPaternoApoderado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNuevoApoderado = new System.Windows.Forms.Button();
            this.btnActualizarApoderado = new System.Windows.Forms.Button();
            this.PageEstudiante = new MetroFramework.Controls.MetroTabPage();
            this.btnRestaurarEstudiante = new System.Windows.Forms.Button();
            this.btnActualizarEstudiante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemeninoEst = new System.Windows.Forms.RadioButton();
            this.rbtnMasculinoEst = new System.Windows.Forms.RadioButton();
            this.lblIDEstudiante = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.btnRegistroAcademico = new System.Windows.Forms.Button();
            this.gbxFotoEstudiante = new System.Windows.Forms.GroupBox();
            this.txtNombrestudiante = new System.Windows.Forms.TextBox();
            this.txtMaternoEstudiante = new System.Windows.Forms.TextBox();
            this.txtPaternoEstudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearEstudiante = new System.Windows.Forms.Button();
            this.tabEstudiante = new MetroFramework.Controls.MetroTabControl();
            this.eprCamposObligatorios = new System.Windows.Forms.ErrorProvider(this.components);
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PageApoderado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PageEstudiante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprCamposObligatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // panLineaDetalle
            // 
            this.panLineaDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.panLineaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLineaDetalle.Location = new System.Drawing.Point(0, 0);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(1034, 5);
            this.panLineaDetalle.TabIndex = 0;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.LemonChiffon;
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 5);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1034, 40);
            this.panTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Centro de esudios personalizado \"VILLARREAL\"";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1002, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PageApoderado
            // 
            this.PageApoderado.Controls.Add(this.btnRestaurarApoderado);
            this.PageApoderado.Controls.Add(this.groupBox2);
            this.PageApoderado.Controls.Add(this.btnActualizarApoderado);
            this.PageApoderado.Controls.Add(this.btnNuevoApoderado);
            this.PageApoderado.HorizontalScrollbarBarColor = true;
            this.PageApoderado.HorizontalScrollbarHighlightOnWheel = false;
            this.PageApoderado.HorizontalScrollbarSize = 2;
            this.PageApoderado.Location = new System.Drawing.Point(4, 38);
            this.PageApoderado.Name = "PageApoderado";
            this.PageApoderado.Size = new System.Drawing.Size(984, 352);
            this.PageApoderado.TabIndex = 1;
            this.PageApoderado.Text = "Informacion de tutor y/o apoderado";
            this.PageApoderado.VerticalScrollbarBarColor = true;
            this.PageApoderado.VerticalScrollbarHighlightOnWheel = false;
            this.PageApoderado.VerticalScrollbarSize = 3;
            // 
            // btnRestaurarApoderado
            // 
            this.btnRestaurarApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarApoderado.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRestaurarApoderado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarApoderado.FlatAppearance.BorderSize = 0;
            this.btnRestaurarApoderado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarApoderado.Location = new System.Drawing.Point(419, 316);
            this.btnRestaurarApoderado.Name = "btnRestaurarApoderado";
            this.btnRestaurarApoderado.Size = new System.Drawing.Size(211, 23);
            this.btnRestaurarApoderado.TabIndex = 19;
            this.btnRestaurarApoderado.Text = "Restaurar";
            this.btnRestaurarApoderado.UseVisualStyleBackColor = false;
            this.btnRestaurarApoderado.Visible = false;
            this.btnRestaurarApoderado.Click += new System.EventHandler(this.btnRestaurarApoderado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefonoApoderado);
            this.groupBox2.Controls.Add(this.txtCelularApoderado);
            this.groupBox2.Controls.Add(this.txtDNIApoderado);
            this.groupBox2.Controls.Add(this.btnSeleccionarApoderado);
            this.groupBox2.Controls.Add(this.txtCorreoApoderado);
            this.groupBox2.Controls.Add(this.lblIDApoderado);
            this.groupBox2.Controls.Add(this.lblApoderado);
            this.groupBox2.Controls.Add(this.txtDireccionApoderado);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNombreApoderado);
            this.groupBox2.Controls.Add(this.txtMaternoApoderado);
            this.groupBox2.Controls.Add(this.txtPaternoApoderado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 268);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtTelefonoApoderado
            // 
            this.txtTelefonoApoderado.Enabled = false;
            this.txtTelefonoApoderado.Location = new System.Drawing.Point(685, 63);
            this.txtTelefonoApoderado.Mask = "999999999";
            this.txtTelefonoApoderado.Name = "txtTelefonoApoderado";
            this.txtTelefonoApoderado.PromptChar = '*';
            this.txtTelefonoApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtTelefonoApoderado.TabIndex = 27;
            // 
            // txtCelularApoderado
            // 
            this.txtCelularApoderado.Enabled = false;
            this.txtCelularApoderado.Location = new System.Drawing.Point(685, 100);
            this.txtCelularApoderado.Mask = "999 999 999";
            this.txtCelularApoderado.Name = "txtCelularApoderado";
            this.txtCelularApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtCelularApoderado.TabIndex = 26;
            this.txtCelularApoderado.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelularApoderado_Validating);
            // 
            // txtDNIApoderado
            // 
            this.txtDNIApoderado.Enabled = false;
            this.txtDNIApoderado.Location = new System.Drawing.Point(195, 63);
            this.txtDNIApoderado.Mask = "99999999";
            this.txtDNIApoderado.Name = "txtDNIApoderado";
            this.txtDNIApoderado.PromptChar = '*';
            this.txtDNIApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtDNIApoderado.TabIndex = 25;
            this.txtDNIApoderado.ValidatingType = typeof(int);
            // 
            // btnSeleccionarApoderado
            // 
            this.btnSeleccionarApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarApoderado.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSeleccionarApoderado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarApoderado.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarApoderado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarApoderado.Location = new System.Drawing.Point(685, 217);
            this.btnSeleccionarApoderado.Name = "btnSeleccionarApoderado";
            this.btnSeleccionarApoderado.Size = new System.Drawing.Size(211, 23);
            this.btnSeleccionarApoderado.TabIndex = 19;
            this.btnSeleccionarApoderado.Text = "Seleccionar Apoderado";
            this.btnSeleccionarApoderado.UseVisualStyleBackColor = false;
            this.btnSeleccionarApoderado.Visible = false;
            this.btnSeleccionarApoderado.Click += new System.EventHandler(this.btnSeleccionarApoderado_Click);
            // 
            // txtCorreoApoderado
            // 
            this.txtCorreoApoderado.Enabled = false;
            this.txtCorreoApoderado.Location = new System.Drawing.Point(685, 137);
            this.txtCorreoApoderado.Name = "txtCorreoApoderado";
            this.txtCorreoApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtCorreoApoderado.TabIndex = 24;
            // 
            // lblIDApoderado
            // 
            this.lblIDApoderado.BackColor = System.Drawing.Color.Transparent;
            this.lblIDApoderado.ForeColor = System.Drawing.Color.Blue;
            this.lblIDApoderado.Location = new System.Drawing.Point(192, 29);
            this.lblIDApoderado.Name = "lblIDApoderado";
            this.lblIDApoderado.Size = new System.Drawing.Size(88, 16);
            this.lblIDApoderado.TabIndex = 23;
            // 
            // lblApoderado
            // 
            this.lblApoderado.AutoSize = true;
            this.lblApoderado.Location = new System.Drawing.Point(39, 29);
            this.lblApoderado.Name = "lblApoderado";
            this.lblApoderado.Size = new System.Drawing.Size(88, 16);
            this.lblApoderado.TabIndex = 22;
            this.lblApoderado.Text = "ID Apoderado:";
            // 
            // txtDireccionApoderado
            // 
            this.txtDireccionApoderado.Enabled = false;
            this.txtDireccionApoderado.Location = new System.Drawing.Point(685, 177);
            this.txtDireccionApoderado.Name = "txtDireccionApoderado";
            this.txtDireccionApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtDireccionApoderado.TabIndex = 21;
            this.txtDireccionApoderado.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccionApoderado_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(553, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Direccion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Correo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Celular:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "DNI:";
            // 
            // txtNombreApoderado
            // 
            this.txtNombreApoderado.Enabled = false;
            this.txtNombreApoderado.Location = new System.Drawing.Point(195, 174);
            this.txtNombreApoderado.Name = "txtNombreApoderado";
            this.txtNombreApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtNombreApoderado.TabIndex = 7;
            this.txtNombreApoderado.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreApoderado_Validating);
            // 
            // txtMaternoApoderado
            // 
            this.txtMaternoApoderado.Enabled = false;
            this.txtMaternoApoderado.Location = new System.Drawing.Point(195, 140);
            this.txtMaternoApoderado.Name = "txtMaternoApoderado";
            this.txtMaternoApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtMaternoApoderado.TabIndex = 6;
            this.txtMaternoApoderado.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaternoApoderado_Validating);
            // 
            // txtPaternoApoderado
            // 
            this.txtPaternoApoderado.Enabled = false;
            this.txtPaternoApoderado.Location = new System.Drawing.Point(195, 100);
            this.txtPaternoApoderado.Name = "txtPaternoApoderado";
            this.txtPaternoApoderado.Size = new System.Drawing.Size(211, 21);
            this.txtPaternoApoderado.TabIndex = 5;
            this.txtPaternoApoderado.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaternoApoderado_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Apoderado materno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Apoderado paterno:";
            // 
            // btnNuevoApoderado
            // 
            this.btnNuevoApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoApoderado.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevoApoderado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoApoderado.FlatAppearance.BorderSize = 0;
            this.btnNuevoApoderado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoApoderado.Location = new System.Drawing.Point(701, 316);
            this.btnNuevoApoderado.Name = "btnNuevoApoderado";
            this.btnNuevoApoderado.Size = new System.Drawing.Size(211, 23);
            this.btnNuevoApoderado.TabIndex = 17;
            this.btnNuevoApoderado.Text = "Nuevo";
            this.btnNuevoApoderado.UseVisualStyleBackColor = false;
            this.btnNuevoApoderado.Visible = false;
            this.btnNuevoApoderado.Click += new System.EventHandler(this.btnNuevoApoderado_Click);
            // 
            // btnActualizarApoderado
            // 
            this.btnActualizarApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarApoderado.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnActualizarApoderado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarApoderado.FlatAppearance.BorderSize = 0;
            this.btnActualizarApoderado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarApoderado.Location = new System.Drawing.Point(701, 316);
            this.btnActualizarApoderado.Name = "btnActualizarApoderado";
            this.btnActualizarApoderado.Size = new System.Drawing.Size(211, 23);
            this.btnActualizarApoderado.TabIndex = 16;
            this.btnActualizarApoderado.Text = "Actualizar";
            this.btnActualizarApoderado.UseVisualStyleBackColor = false;
            this.btnActualizarApoderado.Visible = false;
            this.btnActualizarApoderado.Click += new System.EventHandler(this.btnActualizarApoderado_Click);
            // 
            // PageEstudiante
            // 
            this.PageEstudiante.Controls.Add(this.btnRestaurarEstudiante);
            this.PageEstudiante.Controls.Add(this.btnActualizarEstudiante);
            this.PageEstudiante.Controls.Add(this.groupBox1);
            this.PageEstudiante.Controls.Add(this.btnCrearEstudiante);
            this.PageEstudiante.HorizontalScrollbarBarColor = true;
            this.PageEstudiante.HorizontalScrollbarHighlightOnWheel = false;
            this.PageEstudiante.HorizontalScrollbarSize = 2;
            this.PageEstudiante.Location = new System.Drawing.Point(4, 38);
            this.PageEstudiante.Name = "PageEstudiante";
            this.PageEstudiante.Size = new System.Drawing.Size(984, 352);
            this.PageEstudiante.TabIndex = 0;
            this.PageEstudiante.Text = "Informacion general de estudiante";
            this.PageEstudiante.VerticalScrollbarBarColor = true;
            this.PageEstudiante.VerticalScrollbarHighlightOnWheel = false;
            this.PageEstudiante.VerticalScrollbarSize = 3;
            // 
            // btnRestaurarEstudiante
            // 
            this.btnRestaurarEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarEstudiante.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRestaurarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnRestaurarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarEstudiante.Location = new System.Drawing.Point(462, 313);
            this.btnRestaurarEstudiante.Name = "btnRestaurarEstudiante";
            this.btnRestaurarEstudiante.Size = new System.Drawing.Size(200, 23);
            this.btnRestaurarEstudiante.TabIndex = 15;
            this.btnRestaurarEstudiante.Text = "Restaurar datos";
            this.btnRestaurarEstudiante.UseVisualStyleBackColor = false;
            this.btnRestaurarEstudiante.Visible = false;
            this.btnRestaurarEstudiante.Click += new System.EventHandler(this.btnRestaurarEstudiante_Click);
            // 
            // btnActualizarEstudiante
            // 
            this.btnActualizarEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEstudiante.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnActualizarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnActualizarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstudiante.Location = new System.Drawing.Point(725, 313);
            this.btnActualizarEstudiante.Name = "btnActualizarEstudiante";
            this.btnActualizarEstudiante.Size = new System.Drawing.Size(200, 23);
            this.btnActualizarEstudiante.TabIndex = 13;
            this.btnActualizarEstudiante.Text = "Actualizar";
            this.btnActualizarEstudiante.UseVisualStyleBackColor = false;
            this.btnActualizarEstudiante.Visible = false;
            this.btnActualizarEstudiante.Click += new System.EventHandler(this.btnActualizarEstudiante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFechaNac);
            this.groupBox1.Controls.Add(this.rbtnFemeninoEst);
            this.groupBox1.Controls.Add(this.rbtnMasculinoEst);
            this.groupBox1.Controls.Add(this.lblIDEstudiante);
            this.groupBox1.Controls.Add(this.lblEstudiante);
            this.groupBox1.Controls.Add(this.btnRegistroAcademico);
            this.groupBox1.Controls.Add(this.gbxFotoEstudiante);
            this.groupBox1.Controls.Add(this.txtNombrestudiante);
            this.groupBox1.Controls.Add(this.txtMaternoEstudiante);
            this.groupBox1.Controls.Add(this.txtPaternoEstudiante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.Location = new System.Drawing.Point(198, 215);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(300, 21);
            this.dateFechaNac.TabIndex = 17;
            // 
            // rbtnFemeninoEst
            // 
            this.rbtnFemeninoEst.AutoSize = true;
            this.rbtnFemeninoEst.Location = new System.Drawing.Point(417, 179);
            this.rbtnFemeninoEst.Name = "rbtnFemeninoEst";
            this.rbtnFemeninoEst.Size = new System.Drawing.Size(78, 20);
            this.rbtnFemeninoEst.TabIndex = 16;
            this.rbtnFemeninoEst.TabStop = true;
            this.rbtnFemeninoEst.Text = "Femenino";
            this.rbtnFemeninoEst.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculinoEst
            // 
            this.rbtnMasculinoEst.AutoSize = true;
            this.rbtnMasculinoEst.Checked = true;
            this.rbtnMasculinoEst.Location = new System.Drawing.Point(198, 179);
            this.rbtnMasculinoEst.Name = "rbtnMasculinoEst";
            this.rbtnMasculinoEst.Size = new System.Drawing.Size(81, 20);
            this.rbtnMasculinoEst.TabIndex = 15;
            this.rbtnMasculinoEst.TabStop = true;
            this.rbtnMasculinoEst.Text = "Masculino";
            this.rbtnMasculinoEst.UseVisualStyleBackColor = true;
            // 
            // lblIDEstudiante
            // 
            this.lblIDEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lblIDEstudiante.ForeColor = System.Drawing.Color.Blue;
            this.lblIDEstudiante.Location = new System.Drawing.Point(195, 29);
            this.lblIDEstudiante.Name = "lblIDEstudiante";
            this.lblIDEstudiante.Size = new System.Drawing.Size(82, 16);
            this.lblIDEstudiante.TabIndex = 14;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(43, 29);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(82, 16);
            this.lblEstudiante.TabIndex = 13;
            this.lblEstudiante.Text = "ID Estudiante:";
            // 
            // btnRegistroAcademico
            // 
            this.btnRegistroAcademico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistroAcademico.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRegistroAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroAcademico.FlatAppearance.BorderSize = 0;
            this.btnRegistroAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroAcademico.Location = new System.Drawing.Point(702, 224);
            this.btnRegistroAcademico.Name = "btnRegistroAcademico";
            this.btnRegistroAcademico.Size = new System.Drawing.Size(200, 23);
            this.btnRegistroAcademico.TabIndex = 12;
            this.btnRegistroAcademico.Text = "Registro académico";
            this.btnRegistroAcademico.UseVisualStyleBackColor = false;
            this.btnRegistroAcademico.Visible = false;
            this.btnRegistroAcademico.Click += new System.EventHandler(this.btnRegistroAcademico_Click);
            // 
            // gbxFotoEstudiante
            // 
            this.gbxFotoEstudiante.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxFotoEstudiante.Location = new System.Drawing.Point(702, 29);
            this.gbxFotoEstudiante.Name = "gbxFotoEstudiante";
            this.gbxFotoEstudiante.Size = new System.Drawing.Size(200, 172);
            this.gbxFotoEstudiante.TabIndex = 11;
            this.gbxFotoEstudiante.TabStop = false;
            this.gbxFotoEstudiante.Text = "Foto Estudiante:";
            // 
            // txtNombrestudiante
            // 
            this.txtNombrestudiante.Location = new System.Drawing.Point(198, 140);
            this.txtNombrestudiante.Name = "txtNombrestudiante";
            this.txtNombrestudiante.Size = new System.Drawing.Size(300, 21);
            this.txtNombrestudiante.TabIndex = 7;
            this.txtNombrestudiante.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombrestudiante_Validating);
            // 
            // txtMaternoEstudiante
            // 
            this.txtMaternoEstudiante.Location = new System.Drawing.Point(198, 102);
            this.txtMaternoEstudiante.Name = "txtMaternoEstudiante";
            this.txtMaternoEstudiante.Size = new System.Drawing.Size(300, 21);
            this.txtMaternoEstudiante.TabIndex = 6;
            this.txtMaternoEstudiante.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaternoEstudiante_Validating);
            // 
            // txtPaternoEstudiante
            // 
            this.txtPaternoEstudiante.Location = new System.Drawing.Point(198, 64);
            this.txtPaternoEstudiante.Name = "txtPaternoEstudiante";
            this.txtPaternoEstudiante.Size = new System.Drawing.Size(300, 21);
            this.txtPaternoEstudiante.TabIndex = 5;
            this.txtPaternoEstudiante.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaternoEstudiante_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apoderado materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apoderado paterno:";
            // 
            // btnCrearEstudiante
            // 
            this.btnCrearEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEstudiante.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCrearEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearEstudiante.FlatAppearance.BorderSize = 0;
            this.btnCrearEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEstudiante.Location = new System.Drawing.Point(725, 313);
            this.btnCrearEstudiante.Name = "btnCrearEstudiante";
            this.btnCrearEstudiante.Size = new System.Drawing.Size(200, 23);
            this.btnCrearEstudiante.TabIndex = 14;
            this.btnCrearEstudiante.Text = "Crear";
            this.btnCrearEstudiante.UseVisualStyleBackColor = false;
            this.btnCrearEstudiante.Visible = false;
            this.btnCrearEstudiante.Click += new System.EventHandler(this.btnCrearEstudiante_Click);
            // 
            // tabEstudiante
            // 
            this.tabEstudiante.Controls.Add(this.PageEstudiante);
            this.tabEstudiante.Controls.Add(this.PageApoderado);
            this.tabEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabEstudiante.Location = new System.Drawing.Point(21, 67);
            this.tabEstudiante.Name = "tabEstudiante";
            this.tabEstudiante.SelectedIndex = 1;
            this.tabEstudiante.Size = new System.Drawing.Size(992, 394);
            this.tabEstudiante.TabIndex = 2;
            this.tabEstudiante.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabEstudiante.UseSelectable = true;
            this.tabEstudiante.SelectedIndexChanged += new System.EventHandler(this.tabEstudiante_SelectedIndexChanged);
            // 
            // eprCamposObligatorios
            // 
            this.eprCamposObligatorios.ContainerControl = this;
            this.eprCamposObligatorios.Icon = ((System.Drawing.Icon)(resources.GetObject("eprCamposObligatorios.Icon")));
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 483);
            this.Controls.Add(this.tabEstudiante);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstudiante";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PageApoderado.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PageEstudiante.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEstudiante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eprCamposObligatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabEstudiante;
        private MetroFramework.Controls.MetroTabPage PageEstudiante;
        private MetroFramework.Controls.MetroTabPage PageApoderado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaternoEstudiante;
        private System.Windows.Forms.TextBox txtPaternoEstudiante;
        private System.Windows.Forms.TextBox txtNombrestudiante;
        private System.Windows.Forms.GroupBox gbxFotoEstudiante;
        private System.Windows.Forms.Button btnRegistroAcademico;
        private System.Windows.Forms.Button btnActualizarEstudiante;
        private System.Windows.Forms.Button btnCrearEstudiante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreApoderado;
        private System.Windows.Forms.TextBox txtMaternoApoderado;
        private System.Windows.Forms.TextBox txtPaternoApoderado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNuevoApoderado;
        private System.Windows.Forms.Button btnActualizarApoderado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccionApoderado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIDEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.RadioButton rbtnFemeninoEst;
        private System.Windows.Forms.RadioButton rbtnMasculinoEst;
        private System.Windows.Forms.DateTimePicker dateFechaNac;
        private System.Windows.Forms.Button btnRestaurarEstudiante;
        private System.Windows.Forms.Label lblIDApoderado;
        private System.Windows.Forms.Label lblApoderado;
        private System.Windows.Forms.MaskedTextBox txtCorreoApoderado;
        private System.Windows.Forms.Button btnSeleccionarApoderado;
        private System.Windows.Forms.Button btnRestaurarApoderado;
        private System.Windows.Forms.MaskedTextBox txtDNIApoderado;
        private System.Windows.Forms.MaskedTextBox txtCelularApoderado;
        private System.Windows.Forms.MaskedTextBox txtTelefonoApoderado;
        private System.Windows.Forms.ErrorProvider eprCamposObligatorios;
    }
}