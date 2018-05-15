namespace VillaEdu.forms
{
    partial class frmSeleccionarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarEstudiante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.panFiltroApoderado = new System.Windows.Forms.Panel();
            this.txtFiltroEstudiante = new System.Windows.Forms.TextBox();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.gvSeleccionarEstudiante = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnNuevoEstudiante = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblNombreEstudianteCreado = new System.Windows.Forms.Label();
            this.lblIDEstudianteCreado = new System.Windows.Forms.Label();
            this.lblNombreApoderado = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panFiltroApoderado.SuspendLayout();
            this.gbxContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.LemonChiffon;
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 6);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(817, 37);
            this.panTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro de esudios personalizado \"VILLARREAL\"";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(782, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panLineaDetalle
            // 
            this.panLineaDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.panLineaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLineaDetalle.Location = new System.Drawing.Point(0, 0);
            this.panLineaDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(817, 6);
            this.panLineaDetalle.TabIndex = 3;
            // 
            // panFiltroApoderado
            // 
            this.panFiltroApoderado.Controls.Add(this.txtFiltroEstudiante);
            this.panFiltroApoderado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFiltroApoderado.Location = new System.Drawing.Point(0, 43);
            this.panFiltroApoderado.Name = "panFiltroApoderado";
            this.panFiltroApoderado.Size = new System.Drawing.Size(817, 50);
            this.panFiltroApoderado.TabIndex = 5;
            // 
            // txtFiltroEstudiante
            // 
            this.txtFiltroEstudiante.Location = new System.Drawing.Point(480, 15);
            this.txtFiltroEstudiante.Name = "txtFiltroEstudiante";
            this.txtFiltroEstudiante.Size = new System.Drawing.Size(295, 21);
            this.txtFiltroEstudiante.TabIndex = 0;
            this.txtFiltroEstudiante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroEstudiante_KeyUp);
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.gvSeleccionarEstudiante);
            this.gbxContenedor.Location = new System.Drawing.Point(32, 95);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(743, 233);
            this.gbxContenedor.TabIndex = 6;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Lista de apoderados registrados actualmente ...";
            // 
            // gvSeleccionarEstudiante
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvSeleccionarEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSeleccionarEstudiante.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvSeleccionarEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSeleccionarEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSeleccionarEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSeleccionarEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSeleccionarEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSeleccionarEstudiante.DoubleBuffered = true;
            this.gvSeleccionarEstudiante.EnableHeadersVisualStyles = false;
            this.gvSeleccionarEstudiante.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarEstudiante.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarEstudiante.Location = new System.Drawing.Point(3, 17);
            this.gvSeleccionarEstudiante.Name = "gvSeleccionarEstudiante";
            this.gvSeleccionarEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSeleccionarEstudiante.Size = new System.Drawing.Size(737, 213);
            this.gvSeleccionarEstudiante.TabIndex = 0;
            this.gvSeleccionarEstudiante.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSeleccionarEstudiante_CellMouseDoubleClick);
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoEstudiante.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevoEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEstudiante.FlatAppearance.BorderSize = 0;
            this.btnNuevoEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(564, 343);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(211, 23);
            this.btnNuevoEstudiante.TabIndex = 18;
            this.btnNuevoEstudiante.Text = "Nuevo";
            this.btnNuevoEstudiante.UseVisualStyleBackColor = false;
            this.btnNuevoEstudiante.Click += new System.EventHandler(this.btnNuevoEstudiante_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Location = new System.Drawing.Point(29, 342);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(295, 25);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEstudianteCreado
            // 
            this.lblNombreEstudianteCreado.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNombreEstudianteCreado.Location = new System.Drawing.Point(330, 362);
            this.lblNombreEstudianteCreado.Name = "lblNombreEstudianteCreado";
            this.lblNombreEstudianteCreado.Size = new System.Drawing.Size(228, 25);
            this.lblNombreEstudianteCreado.TabIndex = 25;
            this.lblNombreEstudianteCreado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDEstudianteCreado
            // 
            this.lblIDEstudianteCreado.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblIDEstudianteCreado.Location = new System.Drawing.Point(330, 328);
            this.lblIDEstudianteCreado.Name = "lblIDEstudianteCreado";
            this.lblIDEstudianteCreado.Size = new System.Drawing.Size(57, 25);
            this.lblIDEstudianteCreado.TabIndex = 24;
            this.lblIDEstudianteCreado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreApoderado
            // 
            this.lblNombreApoderado.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNombreApoderado.Location = new System.Drawing.Point(394, 328);
            this.lblNombreApoderado.Name = "lblNombreApoderado";
            this.lblNombreApoderado.Size = new System.Drawing.Size(164, 25);
            this.lblNombreApoderado.TabIndex = 26;
            this.lblNombreApoderado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSeleccionarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 396);
            this.Controls.Add(this.lblNombreApoderado);
            this.Controls.Add(this.lblNombreEstudianteCreado);
            this.Controls.Add(this.lblIDEstudianteCreado);
            this.Controls.Add(this.btnNuevoEstudiante);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.panFiltroApoderado);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSeleccionarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionarEstudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeleccionarEstudiante_FormClosed);
            this.Load += new System.EventHandler(this.frmSeleccionarEstudiante_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panFiltroApoderado.ResumeLayout(false);
            this.panFiltroApoderado.PerformLayout();
            this.gbxContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Panel panFiltroApoderado;
        private System.Windows.Forms.TextBox txtFiltroEstudiante;
        private System.Windows.Forms.GroupBox gbxContenedor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvSeleccionarEstudiante;
        private System.Windows.Forms.Button btnNuevoEstudiante;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreApoderado;
        private System.Windows.Forms.Label lblNombreEstudianteCreado;
        private System.Windows.Forms.Label lblIDEstudianteCreado;
    }
}