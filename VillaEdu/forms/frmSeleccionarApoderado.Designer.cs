namespace VillaEdu.forms
{
    partial class frmSeleccionarApoderado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarApoderado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panFiltroApoderado = new System.Windows.Forms.Panel();
            this.txtFiltroApoderado = new System.Windows.Forms.TextBox();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.gvSeleccionarApoderado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panFiltroApoderado.SuspendLayout();
            this.gbxContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarApoderado)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panLineaDetalle
            // 
            this.panLineaDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.panLineaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLineaDetalle.Location = new System.Drawing.Point(0, 0);
            this.panLineaDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(817, 6);
            this.panLineaDetalle.TabIndex = 1;
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
            this.panTop.TabIndex = 2;
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
            // panFiltroApoderado
            // 
            this.panFiltroApoderado.Controls.Add(this.txtFiltroApoderado);
            this.panFiltroApoderado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFiltroApoderado.Location = new System.Drawing.Point(0, 43);
            this.panFiltroApoderado.Name = "panFiltroApoderado";
            this.panFiltroApoderado.Size = new System.Drawing.Size(817, 50);
            this.panFiltroApoderado.TabIndex = 3;
            // 
            // txtFiltroApoderado
            // 
            this.txtFiltroApoderado.Location = new System.Drawing.Point(480, 15);
            this.txtFiltroApoderado.Name = "txtFiltroApoderado";
            this.txtFiltroApoderado.Size = new System.Drawing.Size(295, 21);
            this.txtFiltroApoderado.TabIndex = 0;
            this.txtFiltroApoderado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroApoderado_KeyUp);
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.gvSeleccionarApoderado);
            this.gbxContenedor.Location = new System.Drawing.Point(35, 93);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(743, 233);
            this.gbxContenedor.TabIndex = 4;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Lista de apoderados registrados actualmente ...";
            // 
            // gvSeleccionarApoderado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvSeleccionarApoderado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSeleccionarApoderado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvSeleccionarApoderado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSeleccionarApoderado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSeleccionarApoderado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSeleccionarApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSeleccionarApoderado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSeleccionarApoderado.DoubleBuffered = true;
            this.gvSeleccionarApoderado.EnableHeadersVisualStyles = false;
            this.gvSeleccionarApoderado.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarApoderado.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvSeleccionarApoderado.Location = new System.Drawing.Point(3, 17);
            this.gvSeleccionarApoderado.Name = "gvSeleccionarApoderado";
            this.gvSeleccionarApoderado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSeleccionarApoderado.Size = new System.Drawing.Size(737, 213);
            this.gvSeleccionarApoderado.TabIndex = 0;
            this.gvSeleccionarApoderado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSeleccionarApoderado_CellMouseDoubleClick);
            // 
            // lblRecord
            // 
            this.lblRecord.Location = new System.Drawing.Point(480, 338);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(295, 25);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro de esudios personalizado \"VILLARREAL\"";
            // 
            // frmSeleccionarApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 396);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.panFiltroApoderado);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSeleccionarApoderado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionarApoderado";
            this.Load += new System.EventHandler(this.frmSeleccionarApoderado_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panFiltroApoderado.ResumeLayout(false);
            this.panFiltroApoderado.PerformLayout();
            this.gbxContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSeleccionarApoderado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panFiltroApoderado;
        private System.Windows.Forms.TextBox txtFiltroApoderado;
        private System.Windows.Forms.GroupBox gbxContenedor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvSeleccionarApoderado;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label1;
    }
}