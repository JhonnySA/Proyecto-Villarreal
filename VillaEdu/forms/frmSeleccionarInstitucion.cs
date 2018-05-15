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
    public partial class frmSeleccionarInstitucion : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string id, string nombre);
        public event PasarID pasado;

        #region
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        // Variables
        string consulta = "Select *From Institucion";
        string[] encabezados = { "ID", "NOMBRE", "DIRECCION" };

        // Valor celda
        string celda;
        #endregion

        public frmSeleccionarInstitucion()
        {
            InitializeComponent();
        }

        private void frmSeleccionarInstitucion_Load(object sender, EventArgs e)
        {
            cargarGrid();
            lblRecord.Text = "Numero de Instituciones registrados: ... " + record();
        }

        public void cargarGrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvSeleccionarInstitucion.DataSource = data.Tables["DATA"];
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
            for (int i = 0; i < gvSeleccionarInstitucion.Columns.Count; i++)
            {
                gvSeleccionarInstitucion.Columns[i].HeaderText = encabezados[i];
                gvSeleccionarInstitucion.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvSeleccionarInstitucion.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvSeleccionarInstitucion.HeaderBgColor = Color.Black;
            gvSeleccionarInstitucion.HeaderForeColor = Color.White;

            // Fuente
            gvSeleccionarInstitucion.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvSeleccionarInstitucion.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvSeleccionarInstitucion.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvSeleccionarInstitucion.RowHeadersVisible = false;

            if (gvSeleccionarInstitucion.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvSeleccionarInstitucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvSeleccionarInstitucion.MultiSelect = false;
                gvSeleccionarInstitucion.ReadOnly = true;
                gvSeleccionarInstitucion.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvSeleccionarInstitucion.Rows[0].Selected = true;
            }
        }

        public int record()
        {
            return gvSeleccionarInstitucion.Rows.Count;
        }

        public string ID()
        {
            try
            {
                celda = gvSeleccionarInstitucion.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        public string valorCelda(string column)
        {
            try
            {
                celda = gvSeleccionarInstitucion.CurrentRow.Cells[column].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void gvSeleccionarInstitucion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pasado(ID(), valorCelda("nombre"));
                this.Close();
            }
        }

        private void btnNuevaInstitucion_Click(object sender, EventArgs e)
        {
            forms.frmNuevaInstitucion frmIns = new frmNuevaInstitucion();
            frmIns.pasado += new forms.frmNuevaInstitucion.PasarID(capturarIDInstitucion);
            frmIns.ShowDialog();

            //cargarGrid();
            //this.Close();

            validarInstitucionCreada();
        }

        private void validarInstitucionCreada()
        {
            if (lblIDInstitucionCreada.Text != "" && lblNombreInstitucionCreada.Text != "")
            {
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no escoger una institucion existente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void capturarIDInstitucion(string id, string nombre)
        {
            lblIDInstitucionCreada.Text = id;
            lblNombreInstitucionCreada.Text = nombre;
        }

        private void frmSeleccionarInstitucion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lblIDInstitucionCreada.Text != "" && lblNombreInstitucionCreada.Text != "")
            {
                pasado(lblIDInstitucionCreada.Text, lblNombreInstitucionCreada.Text);
            }
        }
    }
}
