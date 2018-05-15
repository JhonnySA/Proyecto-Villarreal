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
    public partial class frmSeleccionarGrupo : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string id);
        public event PasarID pasado;

        #region
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        // Variables generales
        string consulta = "Select *From Grupo";
        string[] encabezados = { "ID", "AULA", "HORA INICIO", "HORA FIN", "DIAS", "SUB-NIVEL" };
        string celda;
        #endregion

        public frmSeleccionarGrupo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no escoger un grupo existente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmSeleccionarGrupo_Load(object sender, EventArgs e)
        {
            cargarGrid();
            lblRecord.Text = "Numero de Grupos registrados: ... " + record();
        }

        public void cargarGrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvSeleccionarGrupo.DataSource = data.Tables["DATA"];
                estiloGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void estiloGrid()
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < gvSeleccionarGrupo.Columns.Count; i++)
            {
                gvSeleccionarGrupo.Columns[i].HeaderText = encabezados[i];
                gvSeleccionarGrupo.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvSeleccionarGrupo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvSeleccionarGrupo.HeaderBgColor = Color.Black;
            gvSeleccionarGrupo.HeaderForeColor = Color.White;

            // Fuente
            gvSeleccionarGrupo.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvSeleccionarGrupo.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvSeleccionarGrupo.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvSeleccionarGrupo.RowHeadersVisible = false;

            if (gvSeleccionarGrupo.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvSeleccionarGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvSeleccionarGrupo.MultiSelect = false;
                gvSeleccionarGrupo.ReadOnly = true;
                gvSeleccionarGrupo.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvSeleccionarGrupo.Rows[0].Selected = true;
            }
        }

        public int record()
        {
            return gvSeleccionarGrupo.Rows.Count;
        }

        public string ID()
        {
            try
            {
                celda = gvSeleccionarGrupo.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void gvSeleccionarGrupo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pasado(ID());
                this.Close();
            }
        }
    }
}
