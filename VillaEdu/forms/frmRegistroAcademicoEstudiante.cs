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
    public partial class frmRegistroAcademicoEstudiante : Form
    {

        #region
        // VARIABLES CONSULTA
        string consulta;
        string[] encabezados;

        public int cod { get; set; }
        #endregion

        public frmRegistroAcademicoEstudiante()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroAcademicoEstudiante_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

                SqlDataAdapter datos = new SqlDataAdapter("select top 1 CONVERT(varchar, day(fechaMatricula)) + ' de ' + DATENAME (month, fechaMatricula) + ' del ' + CONVERT(VARCHAR, YEAR(fechaMatricula)) as fechaInicial from Matricula where codEstudiante = @codEst order by fechaMatricula", conex);
                datos.SelectCommand.Parameters.Add("@codEst", SqlDbType.Int).Value = cod;
                DataSet DB = new DataSet();
                datos.Fill(DB, "RegistroEstudiante");


                // Preguntar si este estudiante contiene matriculas anteriores
                if (DB.Tables["RegistroEstudiante"].Rows.Count > 0)
                {
                    // Cargamos los datos

                    lblIdEstudiante.Text = cod.ToString();
                    lblEstudianteDesde.Text = DB.Tables["RegistroEstudiante"].Rows[0]["fechaInicial"].ToString();

                    // Cargar tabla
                    cargarTablaMatriculasAnteriores();
                }
                else
                {
                    MessageBox.Show("Este alumno no contiene historial de matriculas anteriores...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarTablaMatriculasAnteriores()
        {
            try
            {
                // Consulta para llenar el grid de matriculas anteriores
                consulta = "select codMatricula, fechaMatricula, fechaInicio, fechaFin, montoTotal, montoFinal, s.nombre, tipoPago, codGrupo from Matricula as m inner join Servicio as s on m.codServicio = s.codServicio where codEstudiante = @cod";

                encabezados = new string[] { "ID MATRICULA", "FECHA MATRICULA", "FECHA INICIO", "FECHA FIN", "MONTO TOTAL", "MONTO FINAL", "SERVICIO", "TIPO PAGO", "GRUPO" };

                gvMatriculasAnteriores.cadenaConsulta = consulta;
                gvMatriculasAnteriores.listaEncabezados = encabezados;
                gvMatriculasAnteriores.cargarGrid(cod);

                lblRecordMatricula.Text = "NUMERO DE MATRICULAS: " + gvMatriculasAnteriores.record();
                lblNumVecesMatriculado.Text = gvMatriculasAnteriores.record().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
