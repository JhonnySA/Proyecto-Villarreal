namespace VillaEdu.controles_usuario
{
    partial class cuEstudiante
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuEstudiante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescarControlUsuario = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFiltroEstudiante = new System.Windows.Forms.TextBox();
            this.gbxGrid = new System.Windows.Forms.GroupBox();
            this.gvEstudiante = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.chxMatriculado = new System.Windows.Forms.CheckBox();
            this.cbxServicio = new System.Windows.Forms.ComboBox();
            this.lblMatriculadosActuales = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDetalleDeuda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblRecord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxContenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).BeginInit();
            this.gbxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiante)).BeginInit();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.BackColor = System.Drawing.Color.White;
            this.gbxContenedor.Controls.Add(this.groupBox1);
            this.gbxContenedor.Controls.Add(this.gbxFiltro);
            this.gbxContenedor.Location = new System.Drawing.Point(19, 45);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(1072, 504);
            this.gbxContenedor.TabIndex = 0;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "LISTADO DE ESTUDIANTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescarControlUsuario);
            this.groupBox1.Controls.Add(this.txtFiltroEstudiante);
            this.groupBox1.Controls.Add(this.gbxGrid);
            this.groupBox1.Location = new System.Drawing.Point(32, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "....";
            // 
            // btnRefrescarControlUsuario
            // 
            this.btnRefrescarControlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarControlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescarControlUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescarControlUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescarControlUsuario.Image")));
            this.btnRefrescarControlUsuario.ImageActive = null;
            this.btnRefrescarControlUsuario.Location = new System.Drawing.Point(9, 16);
            this.btnRefrescarControlUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarControlUsuario.Name = "btnRefrescarControlUsuario";
            this.btnRefrescarControlUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnRefrescarControlUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefrescarControlUsuario.TabIndex = 7;
            this.btnRefrescarControlUsuario.TabStop = false;
            this.btnRefrescarControlUsuario.Zoom = 10;
            this.btnRefrescarControlUsuario.Click += new System.EventHandler(this.btnRefrescarControlUsuario_Click);
            // 
            // txtFiltroEstudiante
            // 
            this.txtFiltroEstudiante.Location = new System.Drawing.Point(722, 20);
            this.txtFiltroEstudiante.Name = "txtFiltroEstudiante";
            this.txtFiltroEstudiante.Size = new System.Drawing.Size(295, 21);
            this.txtFiltroEstudiante.TabIndex = 1;
            this.txtFiltroEstudiante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroEstudiante_KeyUp);
            // 
            // gbxGrid
            // 
            this.gbxGrid.Controls.Add(this.gvEstudiante);
            this.gbxGrid.Location = new System.Drawing.Point(6, 46);
            this.gbxGrid.Name = "gbxGrid";
            this.gbxGrid.Size = new System.Drawing.Size(1014, 224);
            this.gbxGrid.TabIndex = 6;
            this.gbxGrid.TabStop = false;
            this.gbxGrid.Text = "Coincidencias encontradas ...";
            // 
            // gvEstudiante
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gvEstudiante.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEstudiante.DoubleBuffered = true;
            this.gvEstudiante.EnableHeadersVisualStyles = false;
            this.gvEstudiante.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvEstudiante.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvEstudiante.Location = new System.Drawing.Point(3, 17);
            this.gvEstudiante.Name = "gvEstudiante";
            this.gvEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvEstudiante.Size = new System.Drawing.Size(1008, 204);
            this.gvEstudiante.TabIndex = 0;
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.BackColor = System.Drawing.Color.LightGray;
            this.gbxFiltro.Controls.Add(this.chxMatriculado);
            this.gbxFiltro.Controls.Add(this.cbxServicio);
            this.gbxFiltro.Controls.Add(this.lblMatriculadosActuales);
            this.gbxFiltro.Controls.Add(this.bunifuCustomLabel1);
            this.gbxFiltro.Location = new System.Drawing.Point(32, 40);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(1020, 138);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Opciones de filtro:";
            // 
            // chxMatriculado
            // 
            this.chxMatriculado.AutoSize = true;
            this.chxMatriculado.Location = new System.Drawing.Point(811, 72);
            this.chxMatriculado.Name = "chxMatriculado";
            this.chxMatriculado.Size = new System.Drawing.Size(148, 20);
            this.chxMatriculado.TabIndex = 9;
            this.chxMatriculado.Text = "Matriculados actuales";
            this.chxMatriculado.UseVisualStyleBackColor = true;
            this.chxMatriculado.Visible = false;
            this.chxMatriculado.CheckedChanged += new System.EventHandler(this.chxMatriculado_CheckedChanged);
            // 
            // cbxServicio
            // 
            this.cbxServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxServicio.FormattingEnabled = true;
            this.cbxServicio.Location = new System.Drawing.Point(36, 70);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Size = new System.Drawing.Size(181, 24);
            this.cbxServicio.TabIndex = 8;
            // 
            // lblMatriculadosActuales
            // 
            this.lblMatriculadosActuales.AutoSize = true;
            this.lblMatriculadosActuales.Location = new System.Drawing.Point(808, 40);
            this.lblMatriculadosActuales.Name = "lblMatriculadosActuales";
            this.lblMatriculadosActuales.Size = new System.Drawing.Size(129, 16);
            this.lblMatriculadosActuales.TabIndex = 4;
            this.lblMatriculadosActuales.Text = "Matriculados actuales";
            this.lblMatriculadosActuales.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Servicio:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(773, 651);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 29);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDetalleDeuda
            // 
            this.btnDetalleDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalleDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnDetalleDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleDeuda.FlatAppearance.BorderSize = 0;
            this.btnDetalleDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleDeuda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleDeuda.ForeColor = System.Drawing.Color.White;
            this.btnDetalleDeuda.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleDeuda.Image")));
            this.btnDetalleDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleDeuda.Location = new System.Drawing.Point(895, 651);
            this.btnDetalleDeuda.Name = "btnDetalleDeuda";
            this.btnDetalleDeuda.Size = new System.Drawing.Size(152, 29);
            this.btnDetalleDeuda.TabIndex = 2;
            this.btnDetalleDeuda.Text = "Ver detalle de deuda";
            this.btnDetalleDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleDeuda.UseVisualStyleBackColor = false;
            this.btnDetalleDeuda.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(664, 651);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(552, 651);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 29);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "  Nuevo   ";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.Green;
            this.lblRecord.Location = new System.Drawing.Point(568, 566);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(500, 16);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = " ";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(1053, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 27);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(0, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 27);
            this.panel1.TabIndex = 10;
            // 
            // cuEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalleDeuda);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbxContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cuEstudiante";
            this.Size = new System.Drawing.Size(1150, 683);
            this.Load += new System.EventHandler(this.cuEstudiante_Load);
            this.gbxContenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).EndInit();
            this.gbxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiante)).EndInit();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContenedor;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDetalleDeuda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRecord;
        private System.Windows.Forms.TextBox txtFiltroEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvEstudiante;
        private System.Windows.Forms.ComboBox cbxServicio;
        private System.Windows.Forms.CheckBox chxMatriculado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMatriculadosActuales;
        private Bunifu.Framework.UI.BunifuImageButton btnRefrescarControlUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
