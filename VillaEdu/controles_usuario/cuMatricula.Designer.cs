namespace VillaEdu.controles_usuario
{
    partial class cuMatricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuMatricula));
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.chxDeudaMatricula = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRecord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDetalleDeudaMatricula = new System.Windows.Forms.Button();
            this.btnNuevaMatricula = new System.Windows.Forms.Button();
            this.cbxServicioMatricula = new System.Windows.Forms.ComboBox();
            this.cbxMesMatricula = new System.Windows.Forms.ComboBox();
            this.gbxContenedorGridView = new System.Windows.Forms.GroupBox();
            this.gvMatricula = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRefrescarControlUsuario = new Bunifu.Framework.UI.BunifuImageButton();
            this.gbxContenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxFiltro.SuspendLayout();
            this.gbxContenedorGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.groupBox1);
            this.gbxContenedor.Controls.Add(this.gbxFiltro);
            this.gbxContenedor.Location = new System.Drawing.Point(25, 36);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(1072, 504);
            this.gbxContenedor.TabIndex = 8;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Listado de matriculas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescarControlUsuario);
            this.groupBox1.Controls.Add(this.gbxContenedorGridView);
            this.groupBox1.Location = new System.Drawing.Point(32, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coincidencias encontradas ...";
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.BackColor = System.Drawing.Color.LightGray;
            this.gbxFiltro.Controls.Add(this.cbxMesMatricula);
            this.gbxFiltro.Controls.Add(this.cbxServicioMatricula);
            this.gbxFiltro.Controls.Add(this.chxDeudaMatricula);
            this.gbxFiltro.Controls.Add(this.bunifuCustomLabel3);
            this.gbxFiltro.Controls.Add(this.bunifuCustomLabel2);
            this.gbxFiltro.Controls.Add(this.bunifuCustomLabel1);
            this.gbxFiltro.Location = new System.Drawing.Point(32, 40);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(1020, 138);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Opciones de filtro:";
            // 
            // chxDeudaMatricula
            // 
            this.chxDeudaMatricula.AutoSize = true;
            this.chxDeudaMatricula.Location = new System.Drawing.Point(846, 74);
            this.chxDeudaMatricula.Name = "chxDeudaMatricula";
            this.chxDeudaMatricula.Size = new System.Drawing.Size(65, 20);
            this.chxDeudaMatricula.TabIndex = 7;
            this.chxDeudaMatricula.Text = "Deuda";
            this.chxDeudaMatricula.UseVisualStyleBackColor = true;
            this.chxDeudaMatricula.CheckedChanged += new System.EventHandler(this.chxDeudaMatricula_CheckedChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(843, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 16);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Estado deuda:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(407, 40);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 16);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Mes:";
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
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Location = new System.Drawing.Point(577, 543);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(500, 16);
            this.lblRecord.TabIndex = 13;
            this.lblRecord.Text = " ";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDetalleDeudaMatricula
            // 
            this.btnDetalleDeudaMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalleDeudaMatricula.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDetalleDeudaMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleDeudaMatricula.FlatAppearance.BorderSize = 0;
            this.btnDetalleDeudaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleDeudaMatricula.Location = new System.Drawing.Point(929, 584);
            this.btnDetalleDeudaMatricula.Name = "btnDetalleDeudaMatricula";
            this.btnDetalleDeudaMatricula.Size = new System.Drawing.Size(145, 23);
            this.btnDetalleDeudaMatricula.TabIndex = 10;
            this.btnDetalleDeudaMatricula.Text = "Ver detalle de deuda";
            this.btnDetalleDeudaMatricula.UseVisualStyleBackColor = false;
            this.btnDetalleDeudaMatricula.Visible = false;
            // 
            // btnNuevaMatricula
            // 
            this.btnNuevaMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaMatricula.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevaMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaMatricula.FlatAppearance.BorderSize = 0;
            this.btnNuevaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMatricula.Location = new System.Drawing.Point(715, 584);
            this.btnNuevaMatricula.Name = "btnNuevaMatricula";
            this.btnNuevaMatricula.Size = new System.Drawing.Size(145, 23);
            this.btnNuevaMatricula.TabIndex = 9;
            this.btnNuevaMatricula.Text = "Nueva matricula";
            this.btnNuevaMatricula.UseVisualStyleBackColor = false;
            this.btnNuevaMatricula.Click += new System.EventHandler(this.btnNuevaMatricula_Click);
            // 
            // cbxServicioMatricula
            // 
            this.cbxServicioMatricula.FormattingEnabled = true;
            this.cbxServicioMatricula.Location = new System.Drawing.Point(36, 72);
            this.cbxServicioMatricula.Name = "cbxServicioMatricula";
            this.cbxServicioMatricula.Size = new System.Drawing.Size(181, 24);
            this.cbxServicioMatricula.TabIndex = 8;
            //this.cbxServicioMatricula.SelectedIndexChanged += new System.EventHandler(this.cbxServicioMatricula_SelectedIndexChanged);
            // 
            // cbxMesMatricula
            // 
            this.cbxMesMatricula.FormattingEnabled = true;
            this.cbxMesMatricula.Location = new System.Drawing.Point(410, 72);
            this.cbxMesMatricula.Name = "cbxMesMatricula";
            this.cbxMesMatricula.Size = new System.Drawing.Size(181, 24);
            this.cbxMesMatricula.TabIndex = 9;
            this.cbxMesMatricula.SelectedIndexChanged += new System.EventHandler(this.cbxMesMatricula_SelectedIndexChanged);
            // 
            // gbxContenedorGridView
            // 
            this.gbxContenedorGridView.Controls.Add(this.gvMatricula);
            this.gbxContenedorGridView.Location = new System.Drawing.Point(6, 53);
            this.gbxContenedorGridView.Name = "gbxContenedorGridView";
            this.gbxContenedorGridView.Size = new System.Drawing.Size(1008, 217);
            this.gbxContenedorGridView.TabIndex = 0;
            this.gbxContenedorGridView.TabStop = false;
            this.gbxContenedorGridView.Text = "????";
            // 
            // gvMatricula
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMatricula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvMatricula.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMatricula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMatricula.DoubleBuffered = true;
            this.gvMatricula.EnableHeadersVisualStyles = false;
            this.gvMatricula.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvMatricula.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvMatricula.Location = new System.Drawing.Point(3, 17);
            this.gvMatricula.Name = "gvMatricula";
            this.gvMatricula.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvMatricula.Size = new System.Drawing.Size(1002, 197);
            this.gvMatricula.TabIndex = 2;
            // 
            // btnRefrescarControlUsuario
            // 
            this.btnRefrescarControlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarControlUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRefrescarControlUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescarControlUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescarControlUsuario.Image")));
            this.btnRefrescarControlUsuario.ImageActive = null;
            this.btnRefrescarControlUsuario.Location = new System.Drawing.Point(9, 21);
            this.btnRefrescarControlUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarControlUsuario.Name = "btnRefrescarControlUsuario";
            this.btnRefrescarControlUsuario.Size = new System.Drawing.Size(23, 25);
            this.btnRefrescarControlUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefrescarControlUsuario.TabIndex = 8;
            this.btnRefrescarControlUsuario.TabStop = false;
            this.btnRefrescarControlUsuario.Zoom = 10;
            this.btnRefrescarControlUsuario.Click += new System.EventHandler(this.btnRefrescarControlUsuario_Click);
            // 
            // cuMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnDetalleDeudaMatricula);
            this.Controls.Add(this.btnNuevaMatricula);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cuMatricula";
            this.Size = new System.Drawing.Size(1123, 643);
            this.Load += new System.EventHandler(this.cuMatricula_Load);
            this.gbxContenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.gbxContenedorGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRecord;
        private System.Windows.Forms.Button btnDetalleDeudaMatricula;
        private System.Windows.Forms.Button btnNuevaMatricula;
        private System.Windows.Forms.CheckBox chxDeudaMatricula;
        private System.Windows.Forms.ComboBox cbxServicioMatricula;
        private System.Windows.Forms.ComboBox cbxMesMatricula;
        private System.Windows.Forms.GroupBox gbxContenedorGridView;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvMatricula;
        private Bunifu.Framework.UI.BunifuImageButton btnRefrescarControlUsuario;
    }
}
