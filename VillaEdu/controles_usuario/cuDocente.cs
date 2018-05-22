using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VillaEdu.controles_usuario
{
    public partial class cuDocente : UserControl
    {

        #region
        string consulta;
        string[] encabezados;

        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        #endregion

        public cuDocente()
        {
            InitializeComponent();
        }

        private void cuDocente_Load(object sender, EventArgs e)
        {
            txtFiltroApoderado.Focus();

            consulta = "Select *from Docente";

            encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES", "SEXO", "CELULAR", "TELEFONO", "DNI", "DIRECCION", "ESPECIALIZAD", "GRADO", "FOTO" };

            cargarGrid(consulta, encabezados);
            refrescarRecord("Nùmero de Docentes: " + record().ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar el Valor de la accion 0 - Creacion y 1 - Actualizacion
                // Pasar como parametro el id del estudiante seleccionado 

                forms.frmDocente doc = new forms.frmDocente(1);
                doc.cod = Convert.ToInt16(valorCelda("codDocente"));

                doc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarGrid(string consulta, string[] encabezados)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvDocente.DataSource = data.Tables["DATA"];
                estiloGrid(encabezados);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void cargarGrid(string consulta, string[] encabezados, string p1)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);
                adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50).Value = p1;
                adapter.SelectCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50).Value = p1;
                adapter.SelectCommand.Parameters.Add("@p3", SqlDbType.VarChar, 50).Value = p1;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvDocente.DataSource = data.Tables["DATA"];

                //estiloGrid(encabezados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estiloGrid(string[] encabezados)
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < gvDocente.Columns.Count; i++)
            {
                gvDocente.Columns[i].HeaderText = encabezados[i];
                gvDocente.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvDocente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvDocente.HeaderBgColor = Color.Black;
            gvDocente.HeaderForeColor = Color.White;

            // Fuente
            gvDocente.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvDocente.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvDocente.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvDocente.RowHeadersVisible = false;

            if (gvDocente.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvDocente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvDocente.MultiSelect = false;
                gvDocente.ReadOnly = true;
                gvDocente.AllowUserToResizeRows = false;                

                // Seleccionar por defecto la primera fila del gridView
                gvDocente.Rows[0].Selected = true;
            }
        }

        private string valorCelda(string column)
        {
            string celda = "";
            try
            {
                celda = gvDocente.CurrentRow.Cells[column].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        public int record()
        {
            return gvDocente.Rows.Count;
        }

        private void refrescarRecord(string mensaje)
        {
            lblRecord.Text = mensaje;
        }

        private void txtFiltroApoderado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFiltroApoderado.Text != "")
                {
                    consulta = "Select *from Docente where apPaterno like '%' + @p1 + '%' or apMaterno like '%' + @p2 + '%' or nombre like '%' + @p3 + '%'";

                    encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES", "SEXO", "CELULAR", "TELEFONO", "DNI", "DIRECCION", "ESPECIALIZAD", "GRADO", "FOTO" };

                    cargarGrid(consulta, encabezados, txtFiltroApoderado.Text);
                }
                else if (txtFiltroApoderado.Text == "")
                {
                    consulta = "Select *from Docente";

                    encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES", "SEXO", "CELULAR", "TELEFONO", "DNI", "DIRECCION", "ESPECIALIZAD", "GRADO", "FOTO" };

                    cargarGrid(consulta, encabezados);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar el Valor de la accion 0 - Creacion y 1 - Actualizacion
                // Pasar como parametro el id del docente seleccionado 

                forms.frmDocente doc = new forms.frmDocente(1);
                doc.cod = Convert.ToInt16(valorCelda("codDocente"));

                doc.ShowDialog();
                cargarGrid(consulta, encabezados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            forms.frmDocente doc = new forms.frmDocente(0);

            doc.ShowDialog();
            cargarGrid(consulta, encabezados);
            refrescarRecord("Nùmero de Docentes: " + record());
        }

        private void chxDocenteActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDocenteActivo.Checked)
            {
                txtFiltroApoderado.Focus();

                consulta = "Select codDocente, apPaterno, apMaterno, nombre from Docente";

                encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES" };

                cargarGrid(consulta, encabezados);
                refrescarRecord("Nùmero de Docentes:" + record().ToString());
            }
            else
            {
                txtFiltroApoderado.Focus();

                consulta = "Select codDocente, apPaterno, apMaterno, nombre, sexo, celular, telefono from Docente";

                encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES", "SEXO", "CELULAR", "TELEFONO" };

                cargarGrid(consulta, encabezados);
                refrescarRecord("Nùmero de Docentes:" + record().ToString());
            }
        }

        private void btnRefrescarControlUsuario_Click(object sender, EventArgs e)
        {
            txtFiltroApoderado.Focus();
            chxDocenteActivo.Checked = false;

            consulta = "Select *from Docente";

            encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRES", "SEXO", "CELULAR", "TELEFONO", "DNI", "DIRECCION", "ESPECIALIZAD", "GRADO", "FOTO" };

            cargarGrid(consulta, encabezados);
            refrescarRecord("Nùmero de Docentes: " + record().ToString());
        }
    }
}
