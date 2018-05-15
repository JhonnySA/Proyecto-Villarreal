using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VillaEdu.forms
{
    public partial class frmSeleccionarApoderado : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string id);
        public event PasarID pasado;

        #region
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        string consulta = "Select *from Apoderado";
        string[] encabezados = { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "CELULAR", "TELEFONO", "CORREO", "DNI", "DIRECCION" };

        // Valor celda
        string celda;
        #endregion

        public frmSeleccionarApoderado()
        {
            InitializeComponent();
        }

        private void frmSeleccionarApoderado_Load(object sender, EventArgs e)
        {
            cargarGrid();
            lblRecord.Text = "Numero de Apoderados registrados: ... " + record();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no escoger un apoderado existente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtFiltroApoderado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFiltroApoderado.Text != "")
                {
                    consulta = "Select *from Apoderado where apPaterno like '%' + @p1 + '%' or apMaterno like '%' + @p2 + '%' or nombre like '%' + @p3 + '%'";

                    cargarGrid(txtFiltroApoderado.Text, txtFiltroApoderado.Text, txtFiltroApoderado.Text);
                }
                else if (txtFiltroApoderado.Text == "")
                {
                    consulta = "Select *from Apoderado";
                    encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "CELULAR", "TELEFONO", "CORREO", "DNI", "DIRECCION" };

                    cargarGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void cargarGrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvSeleccionarApoderado.DataSource = data.Tables["DATA"];
                estiloGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void cargarGrid(string p1, string p2, string p3)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);
                adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50).Value = txtFiltroApoderado.Text;
                adapter.SelectCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50).Value = txtFiltroApoderado.Text;
                adapter.SelectCommand.Parameters.Add("@p3", SqlDbType.VarChar, 50).Value = txtFiltroApoderado.Text;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvSeleccionarApoderado.DataSource = data.Tables["DATA"];

                estiloGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estiloGrid()
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < gvSeleccionarApoderado.Columns.Count; i++)
            {
                gvSeleccionarApoderado.Columns[i].HeaderText = encabezados[i];
                gvSeleccionarApoderado.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvSeleccionarApoderado.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvSeleccionarApoderado.HeaderBgColor = Color.Black;
            gvSeleccionarApoderado.HeaderForeColor = Color.White;

            // Fuente
            gvSeleccionarApoderado.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvSeleccionarApoderado.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvSeleccionarApoderado.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvSeleccionarApoderado.RowHeadersVisible = false;

            if (gvSeleccionarApoderado.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvSeleccionarApoderado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvSeleccionarApoderado.MultiSelect = false;
                gvSeleccionarApoderado.ReadOnly = true;
                gvSeleccionarApoderado.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvSeleccionarApoderado.Rows[0].Selected = true;
            }
        }

        public int record()
        {
            return gvSeleccionarApoderado.Rows.Count;
        }

        public string valorCelda(string column)
        {
            try
            {
                celda = gvSeleccionarApoderado.CurrentRow.Cells[column].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        public string ID()
        {
            try
            {
                celda = gvSeleccionarApoderado.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void gvSeleccionarApoderado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pasado(ID());
                this.Close();
            }
        }
    }
}
