namespace VillaEdu.forms
{
    partial class frmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabDocente = new MetroFramework.Controls.MetroTabControl();
            this.PageDocente = new MetroFramework.Controls.MetroTabPage();
            this.btnRestaurarDocente = new System.Windows.Forms.Button();
            this.btnActualizarDocente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGradoAcademico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelularDocente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccionDocente = new System.Windows.Forms.MaskedTextBox();
            this.txtProfesionDocente = new System.Windows.Forms.TextBox();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDNIDocente = new System.Windows.Forms.MaskedTextBox();
            this.rbtnFemeninoEst = new System.Windows.Forms.RadioButton();
            this.rbtnMasculinoEst = new System.Windows.Forms.RadioButton();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtMaternoDocente = new System.Windows.Forms.TextBox();
            this.txtPaternoDocente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearDocente = new System.Windows.Forms.Button();
            this.PageContratosAnteriores = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvContratosAnterioresDocente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.eprCamposDocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tabDocente.SuspendLayout();
            this.PageDocente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PageContratosAnteriores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratosAnterioresDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprCamposDocente)).BeginInit();
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
            this.panLineaDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(955, 6);
            this.panLineaDetalle.TabIndex = 0;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 6);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(955, 40);
            this.panTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(611, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro de Esudios Personalizado \"VILLARREAL\"";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(918, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabDocente
            // 
            this.tabDocente.Controls.Add(this.PageDocente);
            this.tabDocente.Controls.Add(this.PageContratosAnteriores);
            this.tabDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDocente.Location = new System.Drawing.Point(12, 73);
            this.tabDocente.Name = "tabDocente";
            this.tabDocente.SelectedIndex = 0;
            this.tabDocente.Size = new System.Drawing.Size(929, 394);
            this.tabDocente.TabIndex = 3;
            this.tabDocente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabDocente.UseSelectable = true;
            this.tabDocente.SelectedIndexChanged += new System.EventHandler(this.tabDocente_SelectedIndexChanged);
            // 
            // PageDocente
            // 
            this.PageDocente.Controls.Add(this.btnRestaurarDocente);
            this.PageDocente.Controls.Add(this.btnActualizarDocente);
            this.PageDocente.Controls.Add(this.groupBox1);
            this.PageDocente.Controls.Add(this.btnCrearDocente);
            this.PageDocente.HorizontalScrollbarBarColor = true;
            this.PageDocente.HorizontalScrollbarHighlightOnWheel = false;
            this.PageDocente.HorizontalScrollbarSize = 2;
            this.PageDocente.Location = new System.Drawing.Point(4, 38);
            this.PageDocente.Name = "PageDocente";
            this.PageDocente.Size = new System.Drawing.Size(921, 352);
            this.PageDocente.TabIndex = 0;
            this.PageDocente.Text = "Informacion general de docente";
            this.PageDocente.VerticalScrollbarBarColor = true;
            this.PageDocente.VerticalScrollbarHighlightOnWheel = false;
            this.PageDocente.VerticalScrollbarSize = 3;
            // 
            // btnRestaurarDocente
            // 
            this.btnRestaurarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarDocente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRestaurarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarDocente.FlatAppearance.BorderSize = 0;
            this.btnRestaurarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarDocente.Location = new System.Drawing.Point(392, 310);
            this.btnRestaurarDocente.Name = "btnRestaurarDocente";
            this.btnRestaurarDocente.Size = new System.Drawing.Size(200, 23);
            this.btnRestaurarDocente.TabIndex = 15;
            this.btnRestaurarDocente.Text = "Restaurar datos";
            this.btnRestaurarDocente.UseVisualStyleBackColor = false;
            this.btnRestaurarDocente.Visible = false;
            this.btnRestaurarDocente.Click += new System.EventHandler(this.btnRestaurarDocente_Click);
            // 
            // btnActualizarDocente
            // 
            this.btnActualizarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarDocente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnActualizarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarDocente.FlatAppearance.BorderSize = 0;
            this.btnActualizarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDocente.Location = new System.Drawing.Point(662, 310);
            this.btnActualizarDocente.Name = "btnActualizarDocente";
            this.btnActualizarDocente.Size = new System.Drawing.Size(200, 23);
            this.btnActualizarDocente.TabIndex = 13;
            this.btnActualizarDocente.Text = "Actualizar";
            this.btnActualizarDocente.UseVisualStyleBackColor = false;
            this.btnActualizarDocente.Visible = false;
            this.btnActualizarDocente.Click += new System.EventHandler(this.btnActualizarDocente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDDocente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtGradoAcademico);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCelularDocente);
            this.groupBox1.Controls.Add(this.txtDireccionDocente);
            this.groupBox1.Controls.Add(this.txtProfesionDocente);
            this.groupBox1.Controls.Add(this.txtTelefonoDocente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDNIDocente);
            this.groupBox1.Controls.Add(this.rbtnFemeninoEst);
            this.groupBox1.Controls.Add(this.rbtnMasculinoEst);
            this.groupBox1.Controls.Add(this.txtNombreDocente);
            this.groupBox1.Controls.Add(this.txtMaternoDocente);
            this.groupBox1.Controls.Add(this.txtPaternoDocente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.ForeColor = System.Drawing.Color.Blue;
            this.lblIDDocente.Location = new System.Drawing.Point(159, 23);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(72, 16);
            this.lblIDDocente.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "ID Docente:";
            // 
            // txtGradoAcademico
            // 
            this.txtGradoAcademico.Location = new System.Drawing.Point(603, 213);
            this.txtGradoAcademico.Name = "txtGradoAcademico";
            this.txtGradoAcademico.Size = new System.Drawing.Size(211, 21);
            this.txtGradoAcademico.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Grado academico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Profesion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Direccion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Telefono:";
            // 
            // txtCelularDocente
            // 
            this.txtCelularDocente.Location = new System.Drawing.Point(603, 102);
            this.txtCelularDocente.Mask = "999-999-999";
            this.txtCelularDocente.Name = "txtCelularDocente";
            this.txtCelularDocente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCelularDocente.Size = new System.Drawing.Size(211, 21);
            this.txtCelularDocente.TabIndex = 31;
            this.txtCelularDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCelularDocente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelularDocente_Validating);
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(603, 140);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(211, 21);
            this.txtDireccionDocente.TabIndex = 30;
            // 
            // txtProfesionDocente
            // 
            this.txtProfesionDocente.Location = new System.Drawing.Point(603, 178);
            this.txtProfesionDocente.Name = "txtProfesionDocente";
            this.txtProfesionDocente.Size = new System.Drawing.Size(211, 21);
            this.txtProfesionDocente.TabIndex = 29;
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefonoDocente.Location = new System.Drawing.Point(603, 64);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(211, 21);
            this.txtTelefonoDocente.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "DNI:";
            // 
            // txtDNIDocente
            // 
            this.txtDNIDocente.Location = new System.Drawing.Point(162, 64);
            this.txtDNIDocente.Mask = "99999999";
            this.txtDNIDocente.Name = "txtDNIDocente";
            this.txtDNIDocente.PromptChar = '*';
            this.txtDNIDocente.Size = new System.Drawing.Size(211, 21);
            this.txtDNIDocente.TabIndex = 26;
            this.txtDNIDocente.ValidatingType = typeof(int);
            // 
            // rbtnFemeninoEst
            // 
            this.rbtnFemeninoEst.AutoSize = true;
            this.rbtnFemeninoEst.Location = new System.Drawing.Point(295, 214);
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
            this.rbtnMasculinoEst.Location = new System.Drawing.Point(162, 216);
            this.rbtnMasculinoEst.Name = "rbtnMasculinoEst";
            this.rbtnMasculinoEst.Size = new System.Drawing.Size(81, 20);
            this.rbtnMasculinoEst.TabIndex = 15;
            this.rbtnMasculinoEst.TabStop = true;
            this.rbtnMasculinoEst.Text = "Masculino";
            this.rbtnMasculinoEst.UseVisualStyleBackColor = true;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(162, 178);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(211, 21);
            this.txtNombreDocente.TabIndex = 7;
            this.txtNombreDocente.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreDocente_Validating);
            // 
            // txtMaternoDocente
            // 
            this.txtMaternoDocente.Location = new System.Drawing.Point(162, 140);
            this.txtMaternoDocente.Name = "txtMaternoDocente";
            this.txtMaternoDocente.Size = new System.Drawing.Size(211, 21);
            this.txtMaternoDocente.TabIndex = 6;
            this.txtMaternoDocente.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaternoDocente_Validating);
            // 
            // txtPaternoDocente
            // 
            this.txtPaternoDocente.Location = new System.Drawing.Point(162, 102);
            this.txtPaternoDocente.Name = "txtPaternoDocente";
            this.txtPaternoDocente.Size = new System.Drawing.Size(211, 21);
            this.txtPaternoDocente.TabIndex = 5;
            this.txtPaternoDocente.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaternoDocente_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apoderado materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apoderado paterno:";
            // 
            // btnCrearDocente
            // 
            this.btnCrearDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearDocente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCrearDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearDocente.FlatAppearance.BorderSize = 0;
            this.btnCrearDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDocente.Location = new System.Drawing.Point(662, 310);
            this.btnCrearDocente.Name = "btnCrearDocente";
            this.btnCrearDocente.Size = new System.Drawing.Size(200, 23);
            this.btnCrearDocente.TabIndex = 14;
            this.btnCrearDocente.Text = "Crear";
            this.btnCrearDocente.UseVisualStyleBackColor = false;
            this.btnCrearDocente.Visible = false;
            this.btnCrearDocente.Click += new System.EventHandler(this.btnCrearDocente_Click);
            // 
            // PageContratosAnteriores
            // 
            this.PageContratosAnteriores.Controls.Add(this.groupBox2);
            this.PageContratosAnteriores.HorizontalScrollbarBarColor = true;
            this.PageContratosAnteriores.HorizontalScrollbarHighlightOnWheel = false;
            this.PageContratosAnteriores.HorizontalScrollbarSize = 2;
            this.PageContratosAnteriores.Location = new System.Drawing.Point(4, 38);
            this.PageContratosAnteriores.Name = "PageContratosAnteriores";
            this.PageContratosAnteriores.Size = new System.Drawing.Size(921, 352);
            this.PageContratosAnteriores.TabIndex = 1;
            this.PageContratosAnteriores.Text = "Contratos anteriores";
            this.PageContratosAnteriores.VerticalScrollbarBarColor = true;
            this.PageContratosAnteriores.VerticalScrollbarHighlightOnWheel = false;
            this.PageContratosAnteriores.VerticalScrollbarSize = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvContratosAnterioresDocente);
            this.groupBox2.Location = new System.Drawing.Point(24, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 300);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de contratos anteriores: ...";
            // 
            // gvContratosAnterioresDocente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvContratosAnterioresDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvContratosAnterioresDocente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvContratosAnterioresDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvContratosAnterioresDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvContratosAnterioresDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvContratosAnterioresDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContratosAnterioresDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvContratosAnterioresDocente.DoubleBuffered = true;
            this.gvContratosAnterioresDocente.EnableHeadersVisualStyles = false;
            this.gvContratosAnterioresDocente.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvContratosAnterioresDocente.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvContratosAnterioresDocente.Location = new System.Drawing.Point(3, 17);
            this.gvContratosAnterioresDocente.Name = "gvContratosAnterioresDocente";
            this.gvContratosAnterioresDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvContratosAnterioresDocente.Size = new System.Drawing.Size(865, 280);
            this.gvContratosAnterioresDocente.TabIndex = 0;
            // 
            // eprCamposDocente
            // 
            this.eprCamposDocente.ContainerControl = this;
            this.eprCamposDocente.Icon = ((System.Drawing.Icon)(resources.GetObject("eprCamposDocente.Icon")));
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 479);
            this.Controls.Add(this.tabDocente);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocente";
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tabDocente.ResumeLayout(false);
            this.PageDocente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PageContratosAnteriores.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvContratosAnterioresDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprCamposDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabDocente;
        private MetroFramework.Controls.MetroTabPage PageDocente;
        private System.Windows.Forms.Button btnRestaurarDocente;
        private System.Windows.Forms.Button btnActualizarDocente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFemeninoEst;
        private System.Windows.Forms.RadioButton rbtnMasculinoEst;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtMaternoDocente;
        private System.Windows.Forms.TextBox txtPaternoDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearDocente;
        private MetroFramework.Controls.MetroTabPage PageContratosAnteriores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDNIDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCelularDocente;
        private System.Windows.Forms.MaskedTextBox txtDireccionDocente;
        private System.Windows.Forms.TextBox txtProfesionDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvContratosAnterioresDocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGradoAcademico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.ErrorProvider eprCamposDocente;
    }
}