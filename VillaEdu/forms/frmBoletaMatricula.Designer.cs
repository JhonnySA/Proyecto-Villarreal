namespace VillaEdu.forms
{
    partial class frmBoletaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoletaMatricula));
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.rvBoletaMatricula = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(950, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
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
            this.panTop.Size = new System.Drawing.Size(985, 37);
            this.panTop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(604, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro de Esudios Personalizado \"VILLARREAL\"";
            // 
            // panLineaDetalle
            // 
            this.panLineaDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.panLineaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLineaDetalle.Location = new System.Drawing.Point(0, 0);
            this.panLineaDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(985, 6);
            this.panLineaDetalle.TabIndex = 5;
            // 
            // rvBoletaMatricula
            // 
            this.rvBoletaMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvBoletaMatricula.LocalReport.ReportEmbeddedResource = "VillaEdu.reportes.rptBoletaMatricula.rdlc";
            this.rvBoletaMatricula.Location = new System.Drawing.Point(0, 43);
            this.rvBoletaMatricula.Name = "rvBoletaMatricula";
            this.rvBoletaMatricula.Size = new System.Drawing.Size(985, 433);
            this.rvBoletaMatricula.TabIndex = 7;
            // 
            // frmBoletaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 476);
            this.Controls.Add(this.rvBoletaMatricula);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBoletaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBoletaMatricula";
            this.Load += new System.EventHandler(this.frmBoletaMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panLineaDetalle;
        private Microsoft.Reporting.WinForms.ReportViewer rvBoletaMatricula;
    }
}