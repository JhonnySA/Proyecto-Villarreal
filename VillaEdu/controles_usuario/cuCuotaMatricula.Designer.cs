namespace VillaEdu.controles_usuario
{
    partial class cuCuotaMatricula
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuCuotaMatricula));
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.gbxInformacionMatricula = new System.Windows.Forms.GroupBox();
            this.lblCuota3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCuota2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCuota1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblInformacionCuota = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRecord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbxDetalleMatricula = new System.Windows.Forms.GroupBox();
            this.gvDetalleMatricula = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gbxMatricula = new System.Windows.Forms.GroupBox();
            this.gvMatricula = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarEstudiante = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblCantidadCuota1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCantidadCuota2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCantidadCuota3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEstadoCuota1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEstadoCuota3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEstadoCuota2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSaldoTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSaldoPendiente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbxContenedor.SuspendLayout();
            this.gbxInformacionMatricula.SuspendLayout();
            this.gbxDetalleMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleMatricula)).BeginInit();
            this.gbxMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatricula)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.gbxInformacionMatricula);
            this.gbxContenedor.Controls.Add(this.lblRecord);
            this.gbxContenedor.Controls.Add(this.gbxDetalleMatricula);
            this.gbxContenedor.Controls.Add(this.gbxMatricula);
            this.gbxContenedor.Controls.Add(this.groupBox1);
            this.gbxContenedor.Location = new System.Drawing.Point(36, 32);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(1071, 619);
            this.gbxContenedor.TabIndex = 8;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Matriculas pendientes de pago";
            // 
            // gbxInformacionMatricula
            // 
            this.gbxInformacionMatricula.BackColor = System.Drawing.Color.Linen;
            this.gbxInformacionMatricula.Controls.Add(this.lblSaldoPendiente);
            this.gbxInformacionMatricula.Controls.Add(this.bunifuCustomLabel4);
            this.gbxInformacionMatricula.Controls.Add(this.lblSaldoTotal);
            this.gbxInformacionMatricula.Controls.Add(this.bunifuCustomLabel2);
            this.gbxInformacionMatricula.Controls.Add(this.lblEstadoCuota2);
            this.gbxInformacionMatricula.Controls.Add(this.lblEstadoCuota3);
            this.gbxInformacionMatricula.Controls.Add(this.lblEstadoCuota1);
            this.gbxInformacionMatricula.Controls.Add(this.lblCantidadCuota3);
            this.gbxInformacionMatricula.Controls.Add(this.lblCantidadCuota2);
            this.gbxInformacionMatricula.Controls.Add(this.lblCantidadCuota1);
            this.gbxInformacionMatricula.Controls.Add(this.lblCuota3);
            this.gbxInformacionMatricula.Controls.Add(this.lblCuota2);
            this.gbxInformacionMatricula.Controls.Add(this.lblCuota1);
            this.gbxInformacionMatricula.Controls.Add(this.lblInformacionCuota);
            this.gbxInformacionMatricula.Location = new System.Drawing.Point(724, 368);
            this.gbxInformacionMatricula.Name = "gbxInformacionMatricula";
            this.gbxInformacionMatricula.Size = new System.Drawing.Size(320, 234);
            this.gbxInformacionMatricula.TabIndex = 31;
            this.gbxInformacionMatricula.TabStop = false;
            this.gbxInformacionMatricula.Text = "Informacion de Matricula ...";
            this.gbxInformacionMatricula.Visible = false;
            // 
            // lblCuota3
            // 
            this.lblCuota3.BackColor = System.Drawing.Color.Moccasin;
            this.lblCuota3.Location = new System.Drawing.Point(27, 127);
            this.lblCuota3.Name = "lblCuota3";
            this.lblCuota3.Size = new System.Drawing.Size(91, 16);
            this.lblCuota3.TabIndex = 3;
            this.lblCuota3.Text = "CUOTA 3:   S/.";
            this.lblCuota3.Visible = false;
            // 
            // lblCuota2
            // 
            this.lblCuota2.BackColor = System.Drawing.Color.Moccasin;
            this.lblCuota2.Location = new System.Drawing.Point(27, 96);
            this.lblCuota2.Name = "lblCuota2";
            this.lblCuota2.Size = new System.Drawing.Size(91, 16);
            this.lblCuota2.TabIndex = 2;
            this.lblCuota2.Text = "CUOTA 2:   S/.";
            this.lblCuota2.Visible = false;
            // 
            // lblCuota1
            // 
            this.lblCuota1.BackColor = System.Drawing.Color.Moccasin;
            this.lblCuota1.Location = new System.Drawing.Point(27, 65);
            this.lblCuota1.Name = "lblCuota1";
            this.lblCuota1.Size = new System.Drawing.Size(91, 16);
            this.lblCuota1.TabIndex = 1;
            this.lblCuota1.Text = "CUOTA 1:   S/.";
            // 
            // lblInformacionCuota
            // 
            this.lblInformacionCuota.BackColor = System.Drawing.Color.Moccasin;
            this.lblInformacionCuota.Location = new System.Drawing.Point(6, 30);
            this.lblInformacionCuota.Name = "lblInformacionCuota";
            this.lblInformacionCuota.Size = new System.Drawing.Size(295, 16);
            this.lblInformacionCuota.TabIndex = 0;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.Linen;
            this.lblRecord.Location = new System.Drawing.Point(25, 315);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(387, 19);
            this.lblRecord.TabIndex = 30;
            // 
            // gbxDetalleMatricula
            // 
            this.gbxDetalleMatricula.Controls.Add(this.gvDetalleMatricula);
            this.gbxDetalleMatricula.Location = new System.Drawing.Point(25, 368);
            this.gbxDetalleMatricula.Name = "gbxDetalleMatricula";
            this.gbxDetalleMatricula.Size = new System.Drawing.Size(686, 234);
            this.gbxDetalleMatricula.TabIndex = 3;
            this.gbxDetalleMatricula.TabStop = false;
            this.gbxDetalleMatricula.Text = "Detalle de matricula seleccionada...";
            // 
            // gvDetalleMatricula
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDetalleMatricula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDetalleMatricula.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvDetalleMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDetalleMatricula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetalleMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDetalleMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetalleMatricula.DoubleBuffered = true;
            this.gvDetalleMatricula.EnableHeadersVisualStyles = false;
            this.gvDetalleMatricula.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvDetalleMatricula.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvDetalleMatricula.Location = new System.Drawing.Point(3, 17);
            this.gvDetalleMatricula.Name = "gvDetalleMatricula";
            this.gvDetalleMatricula.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvDetalleMatricula.Size = new System.Drawing.Size(680, 214);
            this.gvDetalleMatricula.TabIndex = 1;
            // 
            // gbxMatricula
            // 
            this.gbxMatricula.Controls.Add(this.gvMatricula);
            this.gbxMatricula.Location = new System.Drawing.Point(25, 116);
            this.gbxMatricula.Name = "gbxMatricula";
            this.gbxMatricula.Size = new System.Drawing.Size(1003, 179);
            this.gbxMatricula.TabIndex = 2;
            this.gbxMatricula.TabStop = false;
            this.gbxMatricula.Text = "Matriculas...";
            // 
            // gvMatricula
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMatricula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMatricula.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMatricula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMatricula.DoubleBuffered = true;
            this.gvMatricula.EnableHeadersVisualStyles = false;
            this.gvMatricula.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvMatricula.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvMatricula.Location = new System.Drawing.Point(3, 17);
            this.gvMatricula.Name = "gvMatricula";
            this.gvMatricula.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvMatricula.Size = new System.Drawing.Size(997, 159);
            this.gvMatricula.TabIndex = 0;
            this.gvMatricula.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvMatricula_CellMouseDoubleClick);
            this.gvMatricula.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMatricula_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionarEstudiante);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.cbxEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnSeleccionarEstudiante
            // 
            this.btnSeleccionarEstudiante.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSeleccionarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarEstudiante.Image")));
            this.btnSeleccionarEstudiante.ImageActive = null;
            this.btnSeleccionarEstudiante.Location = new System.Drawing.Point(332, 30);
            this.btnSeleccionarEstudiante.Name = "btnSeleccionarEstudiante";
            this.btnSeleccionarEstudiante.Size = new System.Drawing.Size(50, 24);
            this.btnSeleccionarEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarEstudiante.TabIndex = 3;
            this.btnSeleccionarEstudiante.TabStop = false;
            this.btnSeleccionarEstudiante.Zoom = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Estudiante:";
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(101, 30);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(209, 24);
            this.cbxEstudiante.TabIndex = 0;
            this.cbxEstudiante.TextChanged += new System.EventHandler(this.cbxEstudiante_TextChanged);
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // lblCantidadCuota1
            // 
            this.lblCantidadCuota1.BackColor = System.Drawing.Color.Moccasin;
            this.lblCantidadCuota1.Location = new System.Drawing.Point(135, 65);
            this.lblCantidadCuota1.Name = "lblCantidadCuota1";
            this.lblCantidadCuota1.Size = new System.Drawing.Size(63, 16);
            this.lblCantidadCuota1.TabIndex = 4;
            // 
            // lblCantidadCuota2
            // 
            this.lblCantidadCuota2.BackColor = System.Drawing.Color.Moccasin;
            this.lblCantidadCuota2.Location = new System.Drawing.Point(135, 96);
            this.lblCantidadCuota2.Name = "lblCantidadCuota2";
            this.lblCantidadCuota2.Size = new System.Drawing.Size(63, 16);
            this.lblCantidadCuota2.TabIndex = 5;
            this.lblCantidadCuota2.Visible = false;
            // 
            // lblCantidadCuota3
            // 
            this.lblCantidadCuota3.BackColor = System.Drawing.Color.Moccasin;
            this.lblCantidadCuota3.Location = new System.Drawing.Point(135, 127);
            this.lblCantidadCuota3.Name = "lblCantidadCuota3";
            this.lblCantidadCuota3.Size = new System.Drawing.Size(63, 16);
            this.lblCantidadCuota3.TabIndex = 6;
            this.lblCantidadCuota3.Visible = false;
            // 
            // lblEstadoCuota1
            // 
            this.lblEstadoCuota1.BackColor = System.Drawing.Color.Moccasin;
            this.lblEstadoCuota1.Location = new System.Drawing.Point(210, 65);
            this.lblEstadoCuota1.Name = "lblEstadoCuota1";
            this.lblEstadoCuota1.Size = new System.Drawing.Size(91, 16);
            this.lblEstadoCuota1.TabIndex = 7;
            // 
            // lblEstadoCuota3
            // 
            this.lblEstadoCuota3.BackColor = System.Drawing.Color.Moccasin;
            this.lblEstadoCuota3.Location = new System.Drawing.Point(210, 127);
            this.lblEstadoCuota3.Name = "lblEstadoCuota3";
            this.lblEstadoCuota3.Size = new System.Drawing.Size(91, 16);
            this.lblEstadoCuota3.TabIndex = 8;
            this.lblEstadoCuota3.Visible = false;
            // 
            // lblEstadoCuota2
            // 
            this.lblEstadoCuota2.BackColor = System.Drawing.Color.Moccasin;
            this.lblEstadoCuota2.Location = new System.Drawing.Point(210, 96);
            this.lblEstadoCuota2.Name = "lblEstadoCuota2";
            this.lblEstadoCuota2.Size = new System.Drawing.Size(91, 16);
            this.lblEstadoCuota2.TabIndex = 9;
            this.lblEstadoCuota2.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Moccasin;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 170);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(143, 16);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "SALDO TOTAL:            S/.";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.BackColor = System.Drawing.Color.Moccasin;
            this.lblSaldoTotal.Location = new System.Drawing.Point(210, 170);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(63, 16);
            this.lblSaldoTotal.TabIndex = 11;
            // 
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.BackColor = System.Drawing.Color.Moccasin;
            this.lblSaldoPendiente.Location = new System.Drawing.Point(210, 197);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(63, 16);
            this.lblSaldoPendiente.TabIndex = 13;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Moccasin;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 197);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(143, 16);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "SALDO PENDIENTE:    S/.";
            // 
            // cuCuotaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cuCuotaMatricula";
            this.Size = new System.Drawing.Size(1131, 682);
            this.Load += new System.EventHandler(this.cuCuotaMatricula_Load);
            this.gbxContenedor.ResumeLayout(false);
            this.gbxInformacionMatricula.ResumeLayout(false);
            this.gbxDetalleMatricula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleMatricula)).EndInit();
            this.gbxMatricula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMatricula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContenedor;
        private System.Windows.Forms.GroupBox gbxDetalleMatricula;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvDetalleMatricula;
        private System.Windows.Forms.GroupBox gbxMatricula;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnSeleccionarEstudiante;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRecord;
        private System.Windows.Forms.GroupBox gbxInformacionMatricula;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInformacionCuota;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCuota1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCuota3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCuota2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCantidadCuota2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCantidadCuota1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCantidadCuota3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEstadoCuota2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEstadoCuota3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEstadoCuota1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaldoTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaldoPendiente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}
