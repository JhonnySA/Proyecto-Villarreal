using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace VillaEdu.controles_usuario
{
    public partial class cuEstudiante : UserControl
    {
        #region
        // Conexion general      
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        // Variable globales
        string celda;
        string consulta;
        string[] encabezados;
        #endregion

        public cuEstudiante()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar el Valor de la accion 0 - Creacion y 1 - Actualizacion
                // Pasar como parametro el id del estudiante seleccionado 

                forms.frmEstudiante est = new forms.frmEstudiante(1);
                est.cod = Convert.ToInt16(valorCelda("codEstudiante"));

                est.ShowDialog();

                consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

                cargarGrid(consulta, encabezados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cuEstudiante_Load(object sender, EventArgs e)
        {
            cargarComboServicios();

            txtFiltroEstudiante.Focus();

            consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

            encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

            cargarGrid(consulta, encabezados);
            refrescarRecord("NUMERO DE ESTUDIANTES: " + record().ToString());
        }

        private void cargarComboServicios()
        {
            try
            {
                consulta = "Select codServicio, nombre from Servicio";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                cbxServicio.DataSource = data.Tables["DATA"].DefaultView;
                cbxServicio.DisplayMember = "nombre";
                cbxServicio.ValueMember = "codServicio";

                cbxServicio.Text = "Seleccione un Servicio";

                // PROBLEMA SOLUCIONADO:
                /// Primero se ejecutaba el evento selectedIndexChanged y luego el evento Load del Form
                // Activar Evento handler desactivado en el diseñador
                this.cbxServicio.SelectedIndexChanged += new System.EventHandler(this.cbxServicio_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refrescarRecord(string mensaje)
        {
            lblRecord.Text = mensaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int rpta = 0;
                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea eliminar a este estudiante? ... \n" + valorCelda("nombre") + "; " + valorCelda("apPaterno") + " " + valorCelda("apMaterno") + "\n" + "Con ID de Estudiante: " + valorCelda("codEstudiante"), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // DELETE Estudiante
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete Estudiante where codEstudiante= @cod", conex);
                    cmd.Parameters.Add("@cod", SqlDbType.Int).Value = Convert.ToInt16(valorCelda("codEstudiante"));
                    try
                    {
                        conex.Open();
                        rpta = cmd.ExecuteNonQuery();
                        conex.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("No se puede eliminar el registro ..., Posiblemente este Estudiante contenga matriculas activas ... \n\n\n DETALLES:\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conex.Close();
                    }
                    if (rpta == 1)
                        controles_usuario.CustomDialog.ShowDialog("SE HA ELIMINADO CORRECTAMENTE AL ESTUDIANTE !!!");

                    // Refrescar la tabla de estudiante
                    cargarGrid(consulta, encabezados);
                    refrescarRecord("NUMERO DE ESTUDIANTES: " + record());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar el Valor de la accion 0 - Creacion y 1 - Actualizacion
                // Pasar como parametro el id del estudiante seleccionado 

                forms.frmEstudiante est = new forms.frmEstudiante(0);                
                est.ShowDialog();

                consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

                cargarGrid(consulta, encabezados);
                refrescarRecord("NUMERO DE ESTUDIANTES: " + record());
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

                gvEstudiante.DataSource = data.Tables["DATA"];

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

                gvEstudiante.DataSource = data.Tables["DATA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estiloGrid(string[] encabezados)
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < gvEstudiante.Columns.Count; i++)
            {
                gvEstudiante.Columns[i].HeaderText = encabezados[i];
                gvEstudiante.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvEstudiante.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvEstudiante.HeaderBgColor = Color.Black;
            gvEstudiante.HeaderForeColor = Color.White;

            // Fuente
            gvEstudiante.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvEstudiante.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvEstudiante.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvEstudiante.RowHeadersVisible = false;

            if (gvEstudiante.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvEstudiante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvEstudiante.MultiSelect = false;
                gvEstudiante.ReadOnly = true;
                gvEstudiante.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvEstudiante.Rows[0].Selected = true;
            }
        }

        private string valorCelda(string column)
        {
            string celda = "";
            try
            {
                celda = gvEstudiante.CurrentRow.Cells[column].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        public int record()
        {
            return gvEstudiante.Rows.Count;
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

        private void cbxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServicio.SelectedIndex >= 0)
            {
                // Servicio Reforzamiento
                if (cbxServicio.SelectedIndex == 0)
                {
                    lblMatriculadosActuales.Visible = true;
                    chxMatriculado.Visible = true;

                    if (chxMatriculado.Checked)
                    {
                        // Consulta (Estudiante + Apoderado) -> Servicio Reforzamiento y que sean Estudiantes actuales
                    }
                    else
                    {
                        // Consulta (Estudiante + Apoderado) -> Servicio Reforzamiento

                        consulta = "Select  sc.codEstudiante,e.[apPaterno]+' '+e.[apMaterno]+'; '+e.nombre as Estudiante, e.sexo,CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.[apPaterno] + ' ' + a.[apMaterno] + '; ' + a.nombre as Apoderado,a.telefono,a.celular, sc.f as fechaUltimaMatricula,sc.tP,sc.grado,sc.nivel from Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado right join (select codEstudiante, max(tipoPago) as tP, max(fechaMatricula) as f, max(grado) as grado, n.nombre as nivel from Matricula as m inner join Grupo as g on m.codGrupo = g.codGrupo inner join SubNivel as sn on g.codSubNivel = sn.codSubNivel inner join Nivel as n on sn.codNivel = n.codNivel group by codEstudiante, n.nombre) as sc on e.codEstudiante = sc.codEstudiante order by sc.f desc";

                        encabezados = new string[] { "ID", "NOMBRE ESTUDIANTE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "FECHA ULTIMA MATRICULA", "TIPO PAGO", "GRADO", "NIVEL" };

                        cargarGrid(consulta, encabezados);
                    }
                }

                // Servicio Resolucion Practicas
                else if (cbxServicio.SelectedIndex == 1)
                {
                    lblMatriculadosActuales.Visible = false;
                    chxMatriculado.Visible = false;
                    chxMatriculado.Checked = false;

                    // Consulta (Estudiante + Apoderado) -> Resolucion Practicas

                    consulta = "Select *from PagoPractica";
                    encabezados = new string[] { "ID PRACTICA", "SERVICIO", "ESTUDIANTE", "CANTIDAD DE EJERCICIOS", "FECHA SOLICITADA", "COSTO PAGAR", "FECHA ENTREGA", "NUMERO CONTACTO", "SUB-NIVEL", "DOCENTE" };

                    cargarGrid(consulta, encabezados);
                }
            }
        }

        private void chxMatriculado_CheckedChanged(object sender, EventArgs e)
        {
            if (chxMatriculado.Checked)
            {
                btnDetalleDeuda.Visible = true;
            }
            else
            {
                btnDetalleDeuda.Visible = false;
            }
        }

        private void btnRefrescarControlUsuario_Click(object sender, EventArgs e)
        {
            cargarComboServicios();

            txtFiltroEstudiante.Focus();

            consulta = "select e.codEstudiante, e.apPaterno, e.apMaterno, e.nombre, sexo, CONVERT(varchar, day(fechaNacimiento)) + ' de ' + DATENAME(month, fechaNacimiento) as cumpleaños, a.apPaterno + ' ' + a.apMaterno + ' ; ' + a.nombre as apo, a.telefono, a.celular, a.direccion From Estudiante as e inner join Apoderado as a on e.codApoderado = a.codApoderado";

            encabezados = new string[] { "ID", "APELLIDO PATERNO", "APELLIDO MATERNO", "NOMBRE", "SEXO", "CUMPLEAÑOS", "APODERADO", "TELEFONO", "CELULAR", "DIRECCION" };

            cargarGrid(consulta, encabezados);
            refrescarRecord("NUMERO DE ESTUDIANTES: " + record().ToString());
        }
    }
}
