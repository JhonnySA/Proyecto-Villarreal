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
    public partial class frmSeleccionarEstudiante : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string idEstudiante, string nombreEstudiante, string nombreApoderado);
        public event PasarID pasado;

        #region
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        string consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";
        string[] encabezados = { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

        string celda;
        #endregion

        public frmSeleccionarEstudiante()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no escoger un estudiante existente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmSeleccionarEstudiante_Load(object sender, EventArgs e)
        {
            txtFiltroEstudiante.Focus();

            consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

            encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

            cargarGrid(consulta, encabezados);

            refrescarRecord("NUMERO DE ESTUDIANTES: " + record().ToString());
        }

        private void refrescarRecord(string mensaje)
        {
            lblRecord.Text = mensaje;
        }

        private void cargarGrid(string consulta, string[] encabezados)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvSeleccionarEstudiante.DataSource = data.Tables["DATA"];
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

                gvSeleccionarEstudiante.DataSource = data.Tables["DATA"];

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
            for (int i = 0; i < gvSeleccionarEstudiante.Columns.Count; i++)
            {
                gvSeleccionarEstudiante.Columns[i].HeaderText = encabezados[i];
                gvSeleccionarEstudiante.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvSeleccionarEstudiante.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvSeleccionarEstudiante.HeaderBgColor = Color.Black;
            gvSeleccionarEstudiante.HeaderForeColor = Color.White;

            // Fuente
            gvSeleccionarEstudiante.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvSeleccionarEstudiante.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvSeleccionarEstudiante.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvSeleccionarEstudiante.RowHeadersVisible = false;

            if (gvSeleccionarEstudiante.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvSeleccionarEstudiante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvSeleccionarEstudiante.MultiSelect = false;
                gvSeleccionarEstudiante.ReadOnly = true;
                gvSeleccionarEstudiante.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvSeleccionarEstudiante.Rows[0].Selected = true;
            }
        }

        public int record()
        {
            return gvSeleccionarEstudiante.Rows.Count;
        }

        public string valorCelda(string column)
        {
            try
            {
                celda = gvSeleccionarEstudiante.CurrentRow.Cells[column].Value.ToString();
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
                celda = gvSeleccionarEstudiante.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void txtFiltroEstudiante_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFiltroEstudiante.Text != "")
                {
                    consulta = "Select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado where e.apPaterno like '%' + @p1 + '%' or e.apMaterno like '%' + @p2 + '%' or e.nombre like '%' + @p3 + '%'";

                    encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

                    cargarGrid(consulta, encabezados, txtFiltroEstudiante.Text);
                }
                else if (txtFiltroEstudiante.Text == "")
                {
                    consulta = "Select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apMaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

                    encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

                    cargarGrid(consulta, encabezados);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gvSeleccionarEstudiante_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombreEstudiante = "";
            if (e.RowIndex >= 0)
            {                
                nombreEstudiante = valorCelda("apPaterno") + " " + valorCelda("apMaterno") + "; " + valorCelda("nombre");
                pasado(ID(), nombreEstudiante, valorCelda("apo"));
                this.Close();
            }
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar el Valor de la accion 0 - Creacion y 1 - Actualizacion
                // Pasar como parametro el id del estudiante seleccionado 

                forms.frmEstudiante est = new forms.frmEstudiante(0);
                est.pasado += new forms.frmEstudiante.PasarID(capturarInformacionEstudiante);
                est.ShowDialog();

                validarEstudianteCreado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validarEstudianteCreado()
        {
            if (lblIDEstudianteCreado.Text != "" && lblNombreEstudianteCreado.Text != "" && lblNombreApoderado.Text != "")
            {
                this.Close();
            }
        }

        private void capturarInformacionEstudiante(string idEstudiante, string nombreEstudiante, string nombreApoderado)
        {
            lblIDEstudianteCreado.Text = idEstudiante;
            lblNombreEstudianteCreado.Text = nombreEstudiante;
            lblNombreApoderado.Text = nombreApoderado;
        }

        private void frmSeleccionarEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lblIDEstudianteCreado.Text != "" && lblNombreEstudianteCreado.Text != "" && lblNombreApoderado.Text != "")
            {
                pasado(lblIDEstudianteCreado.Text, lblNombreEstudianteCreado.Text, lblNombreApoderado.Text);
            }
        }
    }
}
