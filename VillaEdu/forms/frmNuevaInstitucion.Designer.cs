namespace VillaEdu.forms
{
    partial class frmNuevaInstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaInstitucion));
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panLineaDetalle = new System.Windows.Forms.Panel();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.txtDireccionInstitucion = new System.Windows.Forms.TextBox();
            this.txtNombreInstitucion = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevaInstitucion = new System.Windows.Forms.Button();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbxContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 7);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(566, 46);
            this.panTop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 14);
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
            this.btnCerrar.Location = new System.Drawing.Point(526, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 31);
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
            this.panLineaDetalle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panLineaDetalle.Name = "panLineaDetalle";
            this.panLineaDetalle.Size = new System.Drawing.Size(566, 7);
            this.panLineaDetalle.TabIndex = 11;
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.txtDireccionInstitucion);
            this.gbxContenedor.Controls.Add(this.txtNombreInstitucion);
            this.gbxContenedor.Controls.Add(this.bunifuCustomLabel2);
            this.gbxContenedor.Controls.Add(this.bunifuCustomLabel1);
            this.gbxContenedor.Location = new System.Drawing.Point(24, 72);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(512, 102);
            this.gbxContenedor.TabIndex = 13;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Nueva Institucion Educativa";
            // 
            // txtDireccionInstitucion
            // 
            this.txtDireccionInstitucion.Location = new System.Drawing.Point(180, 62);
            this.txtDireccionInstitucion.Name = "txtDireccionInstitucion";
            this.txtDireccionInstitucion.Size = new System.Drawing.Size(249, 21);
            this.txtDireccionInstitucion.TabIndex = 3;
            // 
            // txtNombreInstitucion
            // 
            this.txtNombreInstitucion.Location = new System.Drawing.Point(180, 29);
            this.txtNombreInstitucion.Name = "txtNombreInstitucion";
            this.txtNombreInstitucion.Size = new System.Drawing.Size(249, 21);
            this.txtNombreInstitucion.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(29, 65);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 16);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Direccion institucion:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nombre institucion:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnNuevaInstitucion
            // 
            this.btnNuevaInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaInstitucion.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevaInstitucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaInstitucion.FlatAppearance.BorderSize = 0;
            this.btnNuevaInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaInstitucion.Location = new System.Drawing.Point(325, 191);
            this.btnNuevaInstitucion.Name = "btnNuevaInstitucion";
            this.btnNuevaInstitucion.Size = new System.Drawing.Size(211, 23);
            this.btnNuevaInstitucion.TabIndex = 19;
            this.btnNuevaInstitucion.Text = "Crear";
            this.btnNuevaInstitucion.UseVisualStyleBackColor = false;
            this.btnNuevaInstitucion.Click += new System.EventHandler(this.btnNuevaInstitucion_Click);
            // 
            // frmNuevaInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 232);
            this.Controls.Add(this.btnNuevaInstitucion);
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panLineaDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNuevaInstitucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaInstitucion";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbxContenedor.ResumeLayout(false);
            this.gbxContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panLineaDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxContenedor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNombreInstitucion;
        private System.Windows.Forms.TextBox txtDireccionInstitucion;
        private System.Windows.Forms.Button btnNuevaInstitucion;
    }
}