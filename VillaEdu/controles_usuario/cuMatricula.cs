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
    public partial class cuMatricula : UserControl
    {
        #region
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        string consulta;
        string[] encabezados;
        #endregion

        public cuMatricula()
        {
            InitializeComponent();
        }

        private void cuMatricula_Load(object sender, EventArgs e)
        {
            cargarComboServicio();
            cargarComboMes();

            consulta = "Select *From Matricula";
            encabezados = new string[] { "ID MATRICULA", "ID ESTUDIANTE", "FECHA MATRICULA", "MONTO TOTAL", "DESCUENTO", "MONTO FINAL", "FECHA INICIO", "FECHA FIN", "OBSERVACIONES", "SERVICIO", "NUMERO CUOTAS", "INSTITUCION", "TIPO PAGO", "CONCEPTO DESCUENTO", "GRUPO", "GRADO" };
            cargarGrid(consulta, encabezados);

            refrescarRecord("NUMERO DE MATRICULAS: " + record().ToString());
        }

        private void cargarComboServicio()
        {
            try
            {
                consulta = "Select codServicio, nombre from Servicio";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                cbxServicioMatricula.DataSource = data.Tables["DATA"].DefaultView;
                cbxServicioMatricula.DisplayMember = "nombre";
                cbxServicioMatricula.ValueMember = "codServicio";

                cbxServicioMatricula.Text = "Seleccione un Servicio";

                // PROBLEMA SOLUCIONADO:
                /// Primero se ejecutaba el evento selectedIndexChanged y luego el evento Load del Form
                // Activar Evento handler desactivado en el diseñador
                this.cbxServicioMatricula.SelectedIndexChanged += new System.EventHandler(this.cbxServicioMatricula_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarComboMes()
        {
            try
            {
                consulta = "Select DISTINCT MONTH(fechaMatricula)as numeroMes, DATENAME(month, fechaMatricula) as mes from Matricula";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                cbxMesMatricula.DataSource = data.Tables["DATA"].DefaultView;
                cbxMesMatricula.DisplayMember = "mes";
                cbxMesMatricula.ValueMember = "numeroMes";

                cbxMesMatricula.Text = "Seleccione un Mes";

                // PROBLEMA SOLUCIONADO:
                /// Primero se ejecutaba el evento selectedIndexChanged y luego el evento Load del Form
                // Activar Evento handler desactivado en el diseñador
                this.cbxMesMatricula.SelectedIndexChanged += new System.EventHandler(this.cbxMesMatricula_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chxDeudaMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDeudaMatricula.Checked)
            {
                btnDetalleDeudaMatricula.Visible = true;
            }
            else
            {
                btnDetalleDeudaMatricula.Visible = false;
            }
        }

        private void cargarGrid(string consulta, string[] encabezados)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvMatricula.DataSource = data.Tables["DATA"];
                estiloGrid(encabezados);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void estiloGrid(string[] encabezados)
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < gvMatricula.Columns.Count; i++)
            {
                gvMatricula.Columns[i].HeaderText = encabezados[i];
                gvMatricula.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvMatricula.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            gvMatricula.HeaderBgColor = Color.Black;
            gvMatricula.HeaderForeColor = Color.White;

            // Fuente
            gvMatricula.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            gvMatricula.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            gvMatricula.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            gvMatricula.RowHeadersVisible = false;

            if (gvMatricula.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                gvMatricula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvMatricula.MultiSelect = false;
                gvMatricula.ReadOnly = true;
                gvMatricula.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvMatricula.Rows[0].Selected = true;
            }
        }

        private int record()
        {
            return gvMatricula.Rows.Count;
        }

        private void refrescarRecord(string mensaje)
        {
            lblRecord.Text = mensaje;
        }

        private int ultimoIdMatricula()
        {
            int codMatricula = 0;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 codMatricula FROM Matricula ORDER BY codMatricula DESC", conex);
            DataSet data = new DataSet();
            adapter.Fill(data, "DATA");

            if (data.Tables["DATA"].Rows.Count > 0)
            {
                codMatricula = Convert.ToInt16(data.Tables["DATA"].Rows[0]["codMatricula"].ToString());
            }

            return codMatricula;
        }

        private void btnNuevaMatricula_Click(object sender, EventArgs e)
        {
            forms.frmMatricula mat = new forms.frmMatricula();

            // Pasarle (COUNT + 1) al nuevo form para ser visualizado 
            mat.idUltimaMatricula = ultimoIdMatricula();

            mat.ShowDialog();

            consulta = "Select *From Matricula";
            encabezados = new string[] { "ID MATRICULA", "ID ESTUDIANTE", "FECHA MATRICULA", "MONTO TOTAL", "DESCUENTO", "MONTO FINAL", "FECHA INICIO", "FECHA FIN", "OBSERVACIONES", "SERVICIO", "NUMERO CUOTAS", "INSTITUCION", "TIPO PAGO", "CONCEPTO DESCUENTO", "GRUPO", "GRADO" };
            cargarGrid(consulta, encabezados);

            refrescarRecord("NUMERO DE MATRICULAS: " + record().ToString());
            cargarGrid(consulta, encabezados);
        }

        private void btnRefrescarControlUsuario_Click(object sender, EventArgs e)
        {
            cargarComboServicio();
            cargarComboMes();

            consulta = "Select *From Matricula";
            encabezados = new string[] { "ID MATRICULA", "ID ESTUDIANTE", "FECHA MATRICULA", "MONTO TOTAL", "DESCUENTO", "MONTO FINAL", "FECHA INICIO", "FECHA FIN", "OBSERVACIONES", "SERVICIO", "NUMERO CUOTAS", "INSTITUCION", "TIPO PAGO", "CONCEPTO DESCUENTO", "GRUPO", "GRADO" };
            cargarGrid(consulta, encabezados);

            refrescarRecord("NUMERO DE MATRICULAS: " + record().ToString());
        }

        private void cbxServicioMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServicioMatricula.SelectedIndex >= 0)
            {
                // Servicio Reforzamiento
                if (cbxServicioMatricula.SelectedIndex == 0)
                {

                }

                // Servicio Resolucion Practicas
                else if (cbxServicioMatricula.SelectedIndex == 1)
                {

                }
            }
        }

        private void cbxMesMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
