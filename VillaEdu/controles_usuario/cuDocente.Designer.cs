namespace VillaEdu.controles_usuario
{
    partial class cuDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAsignarGrupo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefrescarControlUsuario = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFiltroApoderado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvDocente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chxDocenteActivo = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRecord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnAsignarDocente = new System.Windows.Forms.Button();
            this.btnActualizarDocente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAsignarGrupo);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1072, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTADO DE DOCENTES";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(159, 540);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(169, 28);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(397, 540);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 28);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAsignarGrupo
            // 
            this.btnAsignarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarGrupo.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAsignarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarGrupo.FlatAppearance.BorderSize = 0;
            this.btnAsignarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarGrupo.Location = new System.Drawing.Point(635, 540);
            this.btnAsignarGrupo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsignarGrupo.Name = "btnAsignarGrupo";
            this.btnAsignarGrupo.Size = new System.Drawing.Size(169, 28);
            this.btnAsignarGrupo.TabIndex = 8;
            this.btnAsignarGrupo.Text = "Asginar grupo";
            this.btnAsignarGrupo.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(873, 540);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(169, 28);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefrescarControlUsuario);
            this.groupBox3.Controls.Add(this.txtFiltroApoderado);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(32, 204);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1020, 276);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "....";
            // 
            // btnRefrescarControlUsuario
            // 
            this.btnRefrescarControlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarControlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescarControlUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescarControlUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescarControlUsuario.Image")));
            this.btnRefrescarControlUsuario.ImageActive = null;
            this.btnRefrescarControlUsuario.Location = new System.Drawing.Point(9, 25);
            this.btnRefrescarControlUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarControlUsuario.Name = "btnRefrescarControlUsuario";
            this.btnRefrescarControlUsuario.Size = new System.Drawing.Size(23, 25);
            this.btnRefrescarControlUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefrescarControlUsuario.TabIndex = 8;
            this.btnRefrescarControlUsuario.TabStop = false;
            this.btnRefrescarControlUsuario.Zoom = 10;
            this.btnRefrescarControlUsuario.Click += new System.EventHandler(this.btnRefrescarControlUsuario_Click);
            // 
            // txtFiltroApoderado
            // 
            this.txtFiltroApoderado.Location = new System.Drawing.Point(722, 29);
            this.txtFiltroApoderado.Name = "txtFiltroApoderado";
            this.txtFiltroApoderado.Size = new System.Drawing.Size(295, 21);
            this.txtFiltroApoderado.TabIndex = 2;
            this.txtFiltroApoderado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroApoderado_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gvDocente);
            this.groupBox4.Location = new System.Drawing.Point(6, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1014, 224);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Concidencias encontradas";
            // 
            // gvDocente
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvDocente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDocente.DoubleBuffered = true;
            this.gvDocente.EnableHeadersVisualStyles = false;
            this.gvDocente.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvDocente.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvDocente.Location = new System.Drawing.Point(3, 18);
            this.gvDocente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvDocente.Name = "gvDocente";
            this.gvDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvDocente.Size = new System.Drawing.Size(1008, 202);
            this.gvDocente.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.chxDocenteActivo);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Location = new System.Drawing.Point(24, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1020, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de filtro:";
            // 
            // chxDocenteActivo
            // 
            this.chxDocenteActivo.AutoSize = true;
            this.chxDocenteActivo.Location = new System.Drawing.Point(43, 76);
            this.chxDocenteActivo.Name = "chxDocenteActivo";
            this.chxDocenteActivo.Size = new System.Drawing.Size(120, 20);
            this.chxDocenteActivo.TabIndex = 4;
            this.chxDocenteActivo.Text = "Docentes Activos";
            this.chxDocenteActivo.UseVisualStyleBackColor = true;
            this.chxDocenteActivo.CheckedChanged += new System.EventHandler(this.chxDocenteActivo_CheckedChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 39);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 16);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Estado:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecord.ForeColor = System.Drawing.Color.Green;
            this.lblRecord.Location = new System.Drawing.Point(371, 534);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(583, 20);
            this.lblRecord.TabIndex = 6;
            this.lblRecord.Text = " ";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnNuevoDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDocente.FlatAppearance.BorderSize = 0;
            this.btnNuevoDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDocente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDocente.Image")));
            this.btnNuevoDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDocente.Location = new System.Drawing.Point(484, 652);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(99, 29);
            this.btnNuevoDocente.TabIndex = 8;
            this.btnNuevoDocente.Text = "     Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = false;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnEliminarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDocente.FlatAppearance.BorderSize = 0;
            this.btnEliminarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDocente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDocente.Image")));
            this.btnEliminarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDocente.Location = new System.Drawing.Point(726, 652);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(103, 29);
            this.btnEliminarDocente.TabIndex = 7;
            this.btnEliminarDocente.Text = "     Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = false;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnAsignarDocente
            // 
            this.btnAsignarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnAsignarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarDocente.FlatAppearance.BorderSize = 0;
            this.btnAsignarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarDocente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarDocente.ForeColor = System.Drawing.Color.White;
            this.btnAsignarDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarDocente.Image")));
            this.btnAsignarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarDocente.Location = new System.Drawing.Point(848, 652);
            this.btnAsignarDocente.Name = "btnAsignarDocente";
            this.btnAsignarDocente.Size = new System.Drawing.Size(172, 29);
            this.btnAsignarDocente.TabIndex = 6;
            this.btnAsignarDocente.Text = "   Ver Detalle de Deuda";
            this.btnAsignarDocente.UseVisualStyleBackColor = false;
            // 
            // btnActualizarDocente
            // 
            this.btnActualizarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnActualizarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarDocente.FlatAppearance.BorderSize = 0;
            this.btnActualizarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDocente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDocente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDocente.Image")));
            this.btnActualizarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarDocente.Location = new System.Drawing.Point(601, 652);
            this.btnActualizarDocente.Name = "btnActualizarDocente";
            this.btnActualizarDocente.Size = new System.Drawing.Size(110, 29);
            this.btnActualizarDocente.TabIndex = 5;
            this.btnActualizarDocente.Text = "     Actualizar";
            this.btnActualizarDocente.UseVisualStyleBackColor = false;
            this.btnActualizarDocente.Click += new System.EventHandler(this.btnActualizarDocente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(1026, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 27);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(-27, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 27);
            this.panel1.TabIndex = 12;
            // 
            // cuDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevoDocente);
            this.Controls.Add(this.btnEliminarDocente);
            this.Controls.Add(this.btnAsignarDocente);
            this.Controls.Add(this.btnActualizarDocente);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cuDocente";
            this.Size = new System.Drawing.Size(1123, 684);
            this.Load += new System.EventHandler(this.cuDocente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescarControlUsuario)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDocente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRecord;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAsignarGrupo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvDocente;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnAsignarDocente;
        private System.Windows.Forms.Button btnActualizarDocente;
        private System.Windows.Forms.TextBox txtFiltroApoderado;
        private Bunifu.Framework.UI.BunifuImageButton btnRefrescarControlUsuario;
        private System.Windows.Forms.CheckBox chxDocenteActivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
