namespace VillaEdu.forms
{
    partial class frmBase
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunMoverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panLineaTopDetalle = new System.Windows.Forms.Panel();
            this.panMenuSlider = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxLogoMenuSlider = new System.Windows.Forms.PictureBox();
            this.panSMPago = new System.Windows.Forms.Panel();
            this.btnSMPagoDocente = new System.Windows.Forms.Button();
            this.btnSMPagoCuotaMatricula = new System.Windows.Forms.Button();
            this.panSMGrupo = new System.Windows.Forms.Panel();
            this.btnSMAsignarDocente = new System.Windows.Forms.Button();
            this.btnSMCrearGrupo = new System.Windows.Forms.Button();
            this.panSMServicio = new System.Windows.Forms.Panel();
            this.btnSMMatricula = new System.Windows.Forms.Button();
            this.btnSMClasesPracticas = new System.Windows.Forms.Button();
            this.bunAnimLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMiximixar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSlider = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panContenedor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunAnimSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panMenuSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMenuSlider)).BeginInit();
            this.panSMPago.SuspendLayout();
            this.panSMGrupo.SuspendLayout();
            this.panSMServicio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiximixar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // bunMoverForm
            // 
            this.bunMoverForm.Fixed = true;
            this.bunMoverForm.Horizontal = true;
            this.bunMoverForm.TargetControl = null;
            this.bunMoverForm.Vertical = true;
            // 
            // panLineaTopDetalle
            // 
            this.panLineaTopDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.bunAnimSlider.SetDecoration(this.panLineaTopDetalle, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panLineaTopDetalle, BunifuAnimatorNS.DecorationType.None);
            this.panLineaTopDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLineaTopDetalle.Location = new System.Drawing.Point(0, 0);
            this.panLineaTopDetalle.Name = "panLineaTopDetalle";
            this.panLineaTopDetalle.Size = new System.Drawing.Size(1280, 5);
            this.panLineaTopDetalle.TabIndex = 0;
            // 
            // panMenuSlider
            // 
            this.panMenuSlider.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panMenuSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panMenuSlider.BackgroundImage")));
            this.panMenuSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMenuSlider.Controls.Add(this.btnCalendario);
            this.panMenuSlider.Controls.Add(this.btnReporte);
            this.panMenuSlider.Controls.Add(this.btnPago);
            this.panMenuSlider.Controls.Add(this.btnUsuario);
            this.panMenuSlider.Controls.Add(this.btnServicio);
            this.panMenuSlider.Controls.Add(this.btnGrupo);
            this.panMenuSlider.Controls.Add(this.btnInicio);
            this.panMenuSlider.Controls.Add(this.btnDocente);
            this.panMenuSlider.Controls.Add(this.btnEstudiante);
            this.panMenuSlider.Controls.Add(this.pbxLogo);
            this.panMenuSlider.Controls.Add(this.pbxLogoMenuSlider);
            this.panMenuSlider.Controls.Add(this.panSMGrupo);
            this.panMenuSlider.Controls.Add(this.panSMServicio);
            this.panMenuSlider.Controls.Add(this.panSMPago);
            this.bunAnimSlider.SetDecoration(this.panMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.panMenuSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuSlider.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panMenuSlider.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panMenuSlider.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panMenuSlider.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panMenuSlider.Location = new System.Drawing.Point(0, 5);
            this.panMenuSlider.Name = "panMenuSlider";
            this.panMenuSlider.Quality = 10;
            this.panMenuSlider.Size = new System.Drawing.Size(240, 744);
            this.panMenuSlider.TabIndex = 2;
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnCalendario, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnCalendario, BunifuAnimatorNS.DecorationType.None);
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(22, 539);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(177, 47);
            this.btnCalendario.TabIndex = 12;
            this.btnCalendario.Text = "             Calendario";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnReporte, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnReporte, BunifuAnimatorNS.DecorationType.None);
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(22, 592);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(177, 47);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "             Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnPago, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnPago, BunifuAnimatorNS.DecorationType.None);
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.Color.White;
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(22, 415);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(177, 47);
            this.btnPago.TabIndex = 6;
            this.btnPago.Text = "             Pagos";
            this.btnPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnUsuario, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnUsuario, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(22, 645);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(177, 47);
            this.btnUsuario.TabIndex = 8;
            this.btnUsuario.Text = "             Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnServicio
            // 
            this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.btnServicio.FlatAppearance.BorderSize = 0;
            this.btnServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnServicio.Image")));
            this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Location = new System.Drawing.Point(22, 362);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(177, 47);
            this.btnServicio.TabIndex = 5;
            this.btnServicio.Text = "             Servicios";
            this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnGrupo, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnGrupo, BunifuAnimatorNS.DecorationType.None);
            this.btnGrupo.FlatAppearance.BorderSize = 0;
            this.btnGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupo.ForeColor = System.Drawing.Color.White;
            this.btnGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupo.Image")));
            this.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupo.Location = new System.Drawing.Point(22, 309);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(177, 47);
            this.btnGrupo.TabIndex = 3;
            this.btnGrupo.Text = "             Grupos";
            this.btnGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupo.UseVisualStyleBackColor = false;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Silver;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(22, 155);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(44, 42);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDocente
            // 
            this.btnDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnDocente, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnDocente, BunifuAnimatorNS.DecorationType.None);
            this.btnDocente.FlatAppearance.BorderSize = 0;
            this.btnDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocente.ForeColor = System.Drawing.Color.White;
            this.btnDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnDocente.Image")));
            this.btnDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocente.Location = new System.Drawing.Point(22, 256);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(177, 47);
            this.btnDocente.TabIndex = 1;
            this.btnDocente.Text = "             Docentes";
            this.btnDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocente.UseVisualStyleBackColor = false;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.btnEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnEstudiante, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnEstudiante, BunifuAnimatorNS.DecorationType.None);
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiante.Image")));
            this.btnEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.Location = new System.Drawing.Point(22, 203);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(177, 47);
            this.btnEstudiante.TabIndex = 0;
            this.btnEstudiante.Text = "             Estudiantes";
            this.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.bunAnimLogo.SetDecoration(this.pbxLogo, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.pbxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(16, 73);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(50, 50);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Visible = false;
            // 
            // pbxLogoMenuSlider
            // 
            this.pbxLogoMenuSlider.BackColor = System.Drawing.Color.Transparent;
            this.bunAnimLogo.SetDecoration(this.pbxLogoMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.pbxLogoMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.pbxLogoMenuSlider.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoMenuSlider.Image")));
            this.pbxLogoMenuSlider.Location = new System.Drawing.Point(22, 45);
            this.pbxLogoMenuSlider.Name = "pbxLogoMenuSlider";
            this.pbxLogoMenuSlider.Size = new System.Drawing.Size(177, 101);
            this.pbxLogoMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoMenuSlider.TabIndex = 10;
            this.pbxLogoMenuSlider.TabStop = false;
            // 
            // panSMPago
            // 
            this.panSMPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panSMPago.Controls.Add(this.btnSMPagoDocente);
            this.panSMPago.Controls.Add(this.btnSMPagoCuotaMatricula);
            this.bunAnimSlider.SetDecoration(this.panSMPago, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panSMPago, BunifuAnimatorNS.DecorationType.None);
            this.panSMPago.Location = new System.Drawing.Point(22, 463);
            this.panSMPago.Name = "panSMPago";
            this.panSMPago.Size = new System.Drawing.Size(210, 75);
            this.panSMPago.TabIndex = 14;
            this.panSMPago.Visible = false;
            // 
            // btnSMPagoDocente
            // 
            this.btnSMPagoDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMPagoDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMPagoDocente, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMPagoDocente, BunifuAnimatorNS.DecorationType.None);
            this.btnSMPagoDocente.FlatAppearance.BorderSize = 0;
            this.btnSMPagoDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMPagoDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMPagoDocente.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMPagoDocente.ForeColor = System.Drawing.Color.White;
            this.btnSMPagoDocente.Location = new System.Drawing.Point(3, 40);
            this.btnSMPagoDocente.Name = "btnSMPagoDocente";
            this.btnSMPagoDocente.Size = new System.Drawing.Size(204, 30);
            this.btnSMPagoDocente.TabIndex = 13;
            this.btnSMPagoDocente.Text = "          ° Docentes";
            this.btnSMPagoDocente.UseVisualStyleBackColor = false;
            // 
            // btnSMPagoCuotaMatricula
            // 
            this.btnSMPagoCuotaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMPagoCuotaMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMPagoCuotaMatricula, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMPagoCuotaMatricula, BunifuAnimatorNS.DecorationType.None);
            this.btnSMPagoCuotaMatricula.FlatAppearance.BorderSize = 0;
            this.btnSMPagoCuotaMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMPagoCuotaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMPagoCuotaMatricula.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMPagoCuotaMatricula.ForeColor = System.Drawing.Color.White;
            this.btnSMPagoCuotaMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMPagoCuotaMatricula.Location = new System.Drawing.Point(3, 3);
            this.btnSMPagoCuotaMatricula.Name = "btnSMPagoCuotaMatricula";
            this.btnSMPagoCuotaMatricula.Size = new System.Drawing.Size(204, 31);
            this.btnSMPagoCuotaMatricula.TabIndex = 12;
            this.btnSMPagoCuotaMatricula.Text = " ° Cuota matricula";
            this.btnSMPagoCuotaMatricula.UseVisualStyleBackColor = false;
            this.btnSMPagoCuotaMatricula.Click += new System.EventHandler(this.btnSMPagoCuotaMatricula_Click);
            // 
            // panSMGrupo
            // 
            this.panSMGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panSMGrupo.Controls.Add(this.btnSMAsignarDocente);
            this.panSMGrupo.Controls.Add(this.btnSMCrearGrupo);
            this.bunAnimSlider.SetDecoration(this.panSMGrupo, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panSMGrupo, BunifuAnimatorNS.DecorationType.None);
            this.panSMGrupo.Location = new System.Drawing.Point(22, 463);
            this.panSMGrupo.Name = "panSMGrupo";
            this.panSMGrupo.Size = new System.Drawing.Size(210, 75);
            this.panSMGrupo.TabIndex = 12;
            this.panSMGrupo.Visible = false;
            // 
            // btnSMAsignarDocente
            // 
            this.btnSMAsignarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMAsignarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMAsignarDocente, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMAsignarDocente, BunifuAnimatorNS.DecorationType.None);
            this.btnSMAsignarDocente.FlatAppearance.BorderSize = 0;
            this.btnSMAsignarDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMAsignarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAsignarDocente.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMAsignarDocente.ForeColor = System.Drawing.Color.White;
            this.btnSMAsignarDocente.Location = new System.Drawing.Point(3, 40);
            this.btnSMAsignarDocente.Name = "btnSMAsignarDocente";
            this.btnSMAsignarDocente.Size = new System.Drawing.Size(204, 30);
            this.btnSMAsignarDocente.TabIndex = 13;
            this.btnSMAsignarDocente.Text = "          ° Asignar docente";
            this.btnSMAsignarDocente.UseVisualStyleBackColor = false;
            // 
            // btnSMCrearGrupo
            // 
            this.btnSMCrearGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMCrearGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMCrearGrupo, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMCrearGrupo, BunifuAnimatorNS.DecorationType.None);
            this.btnSMCrearGrupo.FlatAppearance.BorderSize = 0;
            this.btnSMCrearGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMCrearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCrearGrupo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMCrearGrupo.ForeColor = System.Drawing.Color.White;
            this.btnSMCrearGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCrearGrupo.Location = new System.Drawing.Point(3, 3);
            this.btnSMCrearGrupo.Name = "btnSMCrearGrupo";
            this.btnSMCrearGrupo.Size = new System.Drawing.Size(204, 31);
            this.btnSMCrearGrupo.TabIndex = 12;
            this.btnSMCrearGrupo.Text = " ° Crear grupo";
            this.btnSMCrearGrupo.UseVisualStyleBackColor = false;
            // 
            // panSMServicio
            // 
            this.panSMServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panSMServicio.Controls.Add(this.btnSMMatricula);
            this.panSMServicio.Controls.Add(this.btnSMClasesPracticas);
            this.bunAnimSlider.SetDecoration(this.panSMServicio, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panSMServicio, BunifuAnimatorNS.DecorationType.None);
            this.panSMServicio.Location = new System.Drawing.Point(22, 463);
            this.panSMServicio.Name = "panSMServicio";
            this.panSMServicio.Size = new System.Drawing.Size(210, 75);
            this.panSMServicio.TabIndex = 13;
            this.panSMServicio.Visible = false;
            // 
            // btnSMMatricula
            // 
            this.btnSMMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMMatricula, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMMatricula, BunifuAnimatorNS.DecorationType.None);
            this.btnSMMatricula.FlatAppearance.BorderSize = 0;
            this.btnSMMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMMatricula.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMMatricula.ForeColor = System.Drawing.Color.White;
            this.btnSMMatricula.Location = new System.Drawing.Point(3, 40);
            this.btnSMMatricula.Name = "btnSMMatricula";
            this.btnSMMatricula.Size = new System.Drawing.Size(204, 30);
            this.btnSMMatricula.TabIndex = 13;
            this.btnSMMatricula.Text = "          ° Matriculas";
            this.btnSMMatricula.UseVisualStyleBackColor = false;
            this.btnSMMatricula.Click += new System.EventHandler(this.btnSMMatricula_Click);
            // 
            // btnSMClasesPracticas
            // 
            this.btnSMClasesPracticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSMClasesPracticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimLogo.SetDecoration(this.btnSMClasesPracticas, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.btnSMClasesPracticas, BunifuAnimatorNS.DecorationType.None);
            this.btnSMClasesPracticas.FlatAppearance.BorderSize = 0;
            this.btnSMClasesPracticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSMClasesPracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMClasesPracticas.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMClasesPracticas.ForeColor = System.Drawing.Color.White;
            this.btnSMClasesPracticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMClasesPracticas.Location = new System.Drawing.Point(3, 3);
            this.btnSMClasesPracticas.Name = "btnSMClasesPracticas";
            this.btnSMClasesPracticas.Size = new System.Drawing.Size(204, 31);
            this.btnSMClasesPracticas.TabIndex = 12;
            this.btnSMClasesPracticas.Text = " ° Clases y/o Practicas";
            this.btnSMClasesPracticas.UseVisualStyleBackColor = false;
            // 
            // bunAnimLogo
            // 
            this.bunAnimLogo.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunAnimLogo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.bunAnimLogo.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMiximixar);
            this.panel1.Controls.Add(this.btnSlider);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunAnimSlider.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(240, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 45);
            this.panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.bunAnimLogo.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitulo.Image")));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(44, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 31);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = " Villarreal v.1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimSlider.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1008, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMiximixar
            // 
            this.btnMiximixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiximixar.BackColor = System.Drawing.Color.Transparent;
            this.btnMiximixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimSlider.SetDecoration(this.btnMiximixar, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.btnMiximixar, BunifuAnimatorNS.DecorationType.None);
            this.btnMiximixar.Image = ((System.Drawing.Image)(resources.GetObject("btnMiximixar.Image")));
            this.btnMiximixar.ImageActive = null;
            this.btnMiximixar.Location = new System.Drawing.Point(982, 8);
            this.btnMiximixar.Name = "btnMiximixar";
            this.btnMiximixar.Size = new System.Drawing.Size(20, 20);
            this.btnMiximixar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMiximixar.TabIndex = 17;
            this.btnMiximixar.TabStop = false;
            this.btnMiximixar.Zoom = 10;
            this.btnMiximixar.Click += new System.EventHandler(this.btnMiximixar_Click);
            // 
            // btnSlider
            // 
            this.btnSlider.BackColor = System.Drawing.Color.Transparent;
            this.btnSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunAnimSlider.SetDecoration(this.btnSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.btnSlider, BunifuAnimatorNS.DecorationType.None);
            this.btnSlider.Image = ((System.Drawing.Image)(resources.GetObject("btnSlider.Image")));
            this.btnSlider.ImageActive = null;
            this.btnSlider.Location = new System.Drawing.Point(7, 8);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(31, 30);
            this.btnSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlider.TabIndex = 19;
            this.btnSlider.TabStop = false;
            this.btnSlider.Zoom = 10;
            this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunAnimLogo.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panContenedor
            // 
            this.panContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panContenedor.BackgroundImage")));
            this.panContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunAnimSlider.SetDecoration(this.panContenedor, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.GradientBottomLeft = System.Drawing.Color.Silver;
            this.panContenedor.GradientBottomRight = System.Drawing.Color.Silver;
            this.panContenedor.GradientTopLeft = System.Drawing.Color.Silver;
            this.panContenedor.GradientTopRight = System.Drawing.Color.Silver;
            this.panContenedor.Location = new System.Drawing.Point(240, 50);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Quality = 10;
            this.panContenedor.Size = new System.Drawing.Size(1040, 699);
            this.panContenedor.TabIndex = 7;
            // 
            // panFooter
            // 
            this.panFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panFooter.BackgroundImage")));
            this.panFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panFooter.Controls.Add(this.bunifuCustomLabel1);
            this.bunAnimSlider.SetDecoration(this.panFooter, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimLogo.SetDecoration(this.panFooter, BunifuAnimatorNS.DecorationType.None);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panFooter.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panFooter.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panFooter.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panFooter.Location = new System.Drawing.Point(240, 703);
            this.panFooter.Name = "panFooter";
            this.panFooter.Quality = 10;
            this.panFooter.Size = new System.Drawing.Size(1040, 46);
            this.panFooter.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunAnimLogo.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(923, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 15);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "USUARIO: xxxxxxx";
            // 
            // bunAnimSlider
            // 
            this.bunAnimSlider.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunAnimSlider.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunAnimSlider.DefaultAnimation = animation2;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 749);
            this.Controls.Add(this.panFooter);
            this.Controls.Add(this.panContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panMenuSlider);
            this.Controls.Add(this.panLineaTopDetalle);
            this.bunAnimLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunAnimSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.panMenuSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMenuSlider)).EndInit();
            this.panSMPago.ResumeLayout(false);
            this.panSMGrupo.ResumeLayout(false);
            this.panSMServicio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiximixar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private Bunifu.Framework.UI.BunifuDragControl bunMoverForm;
        private System.Windows.Forms.Panel panLineaTopDetalle;
        private Bunifu.Framework.UI.BunifuGradientPanel panMenuSlider;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.PictureBox pbxLogoMenuSlider;
        private BunifuAnimatorNS.BunifuTransition bunAnimLogo;
        private BunifuAnimatorNS.BunifuTransition bunAnimSlider;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMiximixar;
        private Bunifu.Framework.UI.BunifuImageButton btnSlider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel panContenedor;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panSMGrupo;
        private System.Windows.Forms.Button btnSMAsignarDocente;
        private System.Windows.Forms.Button btnSMCrearGrupo;
        private System.Windows.Forms.Panel panSMServicio;
        private System.Windows.Forms.Button btnSMMatricula;
        private System.Windows.Forms.Button btnSMClasesPracticas;
        private System.Windows.Forms.Panel panSMPago;
        private System.Windows.Forms.Button btnSMPagoDocente;
        private System.Windows.Forms.Button btnSMPagoCuotaMatricula;
        private System.Windows.Forms.Button btnCalendario;
        private Bunifu.Framework.UI.BunifuGradientPanel panFooter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}