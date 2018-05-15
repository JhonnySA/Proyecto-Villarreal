namespace VillaEdu.controles_usuario
{
    partial class ComplexDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvComplex = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gvComplex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvComplex
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvComplex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvComplex.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvComplex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvComplex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvComplex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvComplex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvComplex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvComplex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvComplex.DoubleBuffered = true;
            this.gvComplex.EnableHeadersVisualStyles = false;
            this.gvComplex.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvComplex.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gvComplex.Location = new System.Drawing.Point(0, 0);
            this.gvComplex.Name = "gvComplex";
            this.gvComplex.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvComplex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvComplex.Size = new System.Drawing.Size(865, 271);
            this.gvComplex.TabIndex = 1;
            this.gvComplex.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvComplex_CellMouseDoubleClick);
            // 
            // ComplexDataGridView
            // 
            this.Controls.Add(this.gvComplex);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.Size = new System.Drawing.Size(865, 271);            
            ((System.ComponentModel.ISupportInitialize)(this.gvComplex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gvComplex;
    }
}
