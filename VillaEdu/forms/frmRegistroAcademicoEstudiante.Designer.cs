namespace VillaEdu.forms
{
    partial class frmRegistroAcademicoEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroAcademicoEstudiante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunSinBorde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxRegistroAcademico = new System.Windows.Forms.GroupBox();
            this.lblServicioSolicitado = new System.Windows.Forms.Label();
            this.lblNumVecesMatriculado = new System.Windows.Forms.Label();
            this.lblEstudianteDesde = new System.Windows.Forms.Label();
            this.lblIdEstudiante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRecordMatricula = new System.Windows.Forms.Label();
            this.gvMatriculasAnteriores = new VillaEdu.controles_usuario.ComplexDataGridView();
            this.gbxRegistroAcademico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatriculasAnteriores)).BeginInit();
            this.SuspendLayout();
            // 
            // bunSinBorde
            // 
            this.bunSinBorde.ElipseRadius = 5;
            this.bunSinBorde.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 6);
            this.panel1.TabIndex = 0;
            // 
            // gbxRegistroAcademico
            // 
            this.gbxRegistroAcademico.Controls.Add(this.lblServicioSolicitado);
            this.gbxRegistroAcademico.Controls.Add(this.lblNumVecesMatriculado);
            this.gbxRegistroAcademico.Controls.Add(this.lblEstudianteDesde);
            this.gbxRegistroAcademico.Controls.Add(this.lblIdEstudiante);
            this.gbxRegistroAcademico.Controls.Add(this.label4);
            this.gbxRegistroAcademico.Controls.Add(this.label3);
            this.gbxRegistroAcademico.Controls.Add(this.label2);
            this.gbxRegistroAcademico.Controls.Add(this.label1);
            this.gbxRegistroAcademico.Location = new System.Drawing.Point(39, 34);
            this.gbxRegistroAcademico.Name = "gbxRegistroAcademico";
            this.gbxRegistroAcademico.Size = new System.Drawing.Size(663, 185);
            this.gbxRegistroAcademico.TabIndex = 1;
            this.gbxRegistroAcademico.TabStop = false;
            this.gbxRegistroAcademico.Text = "RegistroAcademico";
            // 
            // lblServicioSolicitado
            // 
            this.lblServicioSolicitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblServicioSolicitado.ForeColor = System.Drawing.Color.Blue;
            this.lblServicioSolicitado.Location = new System.Drawing.Point(353, 145);
            this.lblServicioSolicitado.Name = "lblServicioSolicitado";
            this.lblServicioSolicitado.Size = new System.Drawing.Size(236, 16);
            this.lblServicioSolicitado.TabIndex = 7;
            // 
            // lblNumVecesMatriculado
            // 
            this.lblNumVecesMatriculado.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblNumVecesMatriculado.ForeColor = System.Drawing.Color.Blue;
            this.lblNumVecesMatriculado.Location = new System.Drawing.Point(353, 109);
            this.lblNumVecesMatriculado.Name = "lblNumVecesMatriculado";
            this.lblNumVecesMatriculado.Size = new System.Drawing.Size(236, 16);
            this.lblNumVecesMatriculado.TabIndex = 6;
            // 
            // lblEstudianteDesde
            // 
            this.lblEstudianteDesde.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblEstudianteDesde.ForeColor = System.Drawing.Color.Blue;
            this.lblEstudianteDesde.Location = new System.Drawing.Point(353, 73);
            this.lblEstudianteDesde.Name = "lblEstudianteDesde";
            this.lblEstudianteDesde.Size = new System.Drawing.Size(236, 16);
            this.lblEstudianteDesde.TabIndex = 5;
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblIdEstudiante.ForeColor = System.Drawing.Color.Blue;
            this.lblIdEstudiante.Location = new System.Drawing.Point(353, 37);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(236, 16);
            this.lblIdEstudiante.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(31, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servicio + solicitado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de veces matriculado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante dede: ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Estudiante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvMatriculasAnteriores);
            this.groupBox1.Location = new System.Drawing.Point(39, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriculas anteriores:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(897, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRecordMatricula
            // 
            this.lblRecordMatricula.Location = new System.Drawing.Point(582, 423);
            this.lblRecordMatricula.Name = "lblRecordMatricula";
            this.lblRecordMatricula.Size = new System.Drawing.Size(302, 13);
            this.lblRecordMatricula.TabIndex = 5;
            this.lblRecordMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gvMatriculasAnteriores
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMatriculasAnteriores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMatriculasAnteriores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvMatriculasAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMatriculasAnteriores.cadenaConsulta = null;
            this.gvMatriculasAnteriores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMatriculasAnteriores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMatriculasAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMatriculasAnteriores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMatriculasAnteriores.DoubleBuffered = true;
            this.gvMatriculasAnteriores.EnableHeadersVisualStyles = false;
            this.gvMatriculasAnteriores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMatriculasAnteriores.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvMatriculasAnteriores.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvMatriculasAnteriores.listaEncabezados = null;
            this.gvMatriculasAnteriores.Location = new System.Drawing.Point(3, 17);
            this.gvMatriculasAnteriores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvMatriculasAnteriores.MultiSelect = false;
            this.gvMatriculasAnteriores.Name = "gvMatriculasAnteriores";
            this.gvMatriculasAnteriores.ReadOnly = true;
            this.gvMatriculasAnteriores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvMatriculasAnteriores.Size = new System.Drawing.Size(842, 161);
            this.gvMatriculasAnteriores.TabIndex = 0;
            // 
            // frmRegistroAcademicoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 463);
            this.Controls.Add(this.lblRecordMatricula);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxRegistroAcademico);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegistroAcademicoEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroAcademicoEstudiante";
            this.Load += new System.EventHandler(this.frmRegistroAcademicoEstudiante_Load);
            this.gbxRegistroAcademico.ResumeLayout(false);
            this.gbxRegistroAcademico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatriculasAnteriores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunSinBorde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxRegistroAcademico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdEstudiante;
        private System.Windows.Forms.Label lblServicioSolicitado;
        private System.Windows.Forms.Label lblNumVecesMatriculado;
        private System.Windows.Forms.Label lblEstudianteDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private controles_usuario.ComplexDataGridView gvMatriculasAnteriores;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblRecordMatricula;
    }
}