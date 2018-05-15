namespace VillaEdu.forms
{
    partial class frmSeleccionarInstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarInstitucion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panFiltroApoderado = new System.Windows.Forms.Panel();
            this.txtFiltroInstitucion = new System.Windows.Forms.TextBox();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.btnNuevaInstitucion = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.gvSeleccionarInstitucion = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblIDInstitucionCreada = new System.Windows.Forms.Label();
            this.lblNombreInstitucionCreada = new System.Windows.Forms.Label();
            this.panFiltroApoderado.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbxContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarInstitucion)).BeginInit();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // panFiltroApoderado
            // 
            this.panFiltroApoderado.Controls.Add(this.txtFiltroInstitucion);
            this.panFiltroApoderado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFiltroApoderado.Location = new System.Drawing.Point(0, 43);
            this.panFiltroApoderado.Name = "panFiltroApoderado";
            this.panFiltroApoderado.Size = new System.Drawing.Size(817, 50);
            this.panFiltroApoderado.TabIndex = 8;
            // 
            // txtFiltroInstitucion
            // 
            this.txtFiltroInstitucion.Location = new System.Drawing.Point(480, 15);
            this.txtFiltroInstitucion.Name = "txtFiltroInstitucion";
            this.txtFiltroInstitucion.Size = new System.Drawing.Size(295, 21);
            this.txtFiltroInstitucion.TabIndex = 0;
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
            this.panTop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 13);
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
            this.panLineaDetalle.TabIndex = 6;
            // 
            // btnNuevaInstitucion
            // 
            this.btnNuevaInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaInstitucion.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevaInstitucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaInstitucion.FlatAppearance.BorderSize = 0;
            this.btnNuevaInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaInstitucion.Location = new System.Drawing.Point(564, 343);
            this.btnNuevaInstitucion.Name = "btnNuevaInstitucion";
            this.btnNuevaInstitucion.Size = new System.Drawing.Size(211, 23);
            this.btnNuevaInstitucion.TabIndex = 21;
            this.btnNuevaInstitucion.Text = "Nuevo";
            this.btnNuevaInstitucion.UseVisualStyleBackColor = false;
            this.btnNuevaInstitucion.Click += new System.EventHandler(this.btnNuevaInstitucion_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Location = new System.Drawing.Point(29, 342);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(295, 25);
            this.lblRecord.TabIndex = 20;
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.gvSeleccionarInstitucion);
            this.gbxContenedor.Location = new System.Drawing.Point(32, 95);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(743, 233);
            this.gbxContenedor.TabIndex = 19;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Lista de instituciones registrados actualmente ...";
            // 
            // gvSeleccionarInstitucion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvSeleccionarInstitucion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSeleccionarInstitucion.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvSeleccionarInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSeleccionarInstitucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSeleccionarInstitucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSeleccionarInstitucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSeleccionarInstitucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSeleccionarInstitucion.DoubleBuffered = true;
            this.gvSeleccionarInstitucion.EnableHeadersVisualStyles = false;
            this.gvSeleccionarInstitucion.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarInstitucion.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarInstitucion.Location = new System.Drawing.Point(3, 17);
            this.gvSeleccionarInstitucion.Name = "gvSeleccionarInstitucion";
            this.gvSeleccionarInstitucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSeleccionarInstitucion.Size = new System.Drawing.Size(737, 213);
            this.gvSeleccionarInstitucion.TabIndex = 0;
            this.gvSeleccionarInstitucion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSeleccionarInstitucion_CellMouseDoubleClick);
            // 
            // lblIDInstitucionCreada
            // 
            this.lblIDInstitucionCreada.Location = new System.Drawing.Point(302, 342);
            this.lblIDInstitucionCreada.Name = "lblIDInstitucionCreada";
            this.lblIDInstitucionCreada.Size = new System.Drawing.Size(101, 25);
            this.lblIDInstitucionCreada.TabIndex = 22;
            this.lblIDInstitucionCreada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreInstitucionCreada
            // 
            this.lblNombreInstitucionCreada.Location = new System.Drawing.Point(428, 342);
            this.lblNombreInstitucionCreada.Name = "lblNombreInstitucionCreada";
            this.lblNombreInstitucionCreada.Size = new System.Drawing.Size(101, 25);
            this.lblNombreInstitucionCreada.TabIndex = 23;
            this.lblNombreInstitucionCreada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSeleccionarInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 396);
            this.Controls.Add(this.lblNombreInstitucionCreada);
            this.Controls.Add(this.lblIDInstitucionCreada);
            this.Controls.Add(this.btnNuevaInstitucion);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.panFiltroApoderado);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSeleccionarInstitucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionarInstitucion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeleccionarInstitucion_FormClosed);
            this.Load += new System.EventHandler(this.frmSeleccionarInstitucion_Load);
            this.panFiltroApoderado.ResumeLayout(false);
            this.panFiltroApoderado.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbxContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarInstitucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panFiltroApoderado;
        private System.Windows.Forms.TextBox txtFiltroInstitucion;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Button btnNuevaInstitucion;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.GroupBox gbxContenedor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvSeleccionarInstitucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDInstitucionCreada;
        private System.Windows.Forms.Label lblNombreInstitucionCreada;
    }
}