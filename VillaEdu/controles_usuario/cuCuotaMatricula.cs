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
using Bunifu.Framework.UI;

namespace VillaEdu.controles_usuario
{
    public partial class cuCuotaMatricula : UserControl
    {

        #region   
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        public int idEstudiante { get; set; }
        string consulta;
        string[] encabezados;
        #endregion

        public cuCuotaMatricula()
        {
            InitializeComponent();
        }

        private void cuCuotaMatricula_Load(object sender, EventArgs e)
        {
            /// Cargar todos los estudiantes 
            cargarComboEstudiante();

            if (idEstudiante != 0)
            {
                consulta = "SELECT *FROM Matricula WHERE codEstudiante=@p1";
                encabezados = new string[] { "ID MATRICULA", "ID ESTUDIANTE", "FECHA MATRICULA", "MONTO TOTAL", "DESCUENTO", "MONTO FINAL", "FECHA INICIO", "FECHA FIN", "OBSERVACIONES", "SERVICIO", "NUMERO CUOTAS", "INSTITUCION", "TIPO PAGO", "CONCEPTO DESCUENTO", "GRUPO", "GRADO" };

                cargarGrid(gvMatricula, consulta, encabezados, idEstudiante);
            }
        }

        private void cargarComboEstudiante()
        {
            try
            {
                consulta = "Select codEstudiante ,apPaterno + ' ' + apMaterno + ' ;' + nombre as estudiante from Estudiante";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                /// Autocompletado
                //DataTable tabla = new DataTable();
                //adapter.Fill(tabla);

                cbxEstudiante.DataSource = data.Tables["DATA"];
                cbxEstudiante.DisplayMember = "estudiante";
                cbxEstudiante.ValueMember = "codEstudiante";

                /// Probando
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in data.Tables["DATA"].Rows)
                {
                    coleccion.Add(Convert.ToString(row["estudiante"])); // columna de la consulta sql
                }
                cbxEstudiante.AutoCompleteCustomSource = coleccion;
                cbxEstudiante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxEstudiante.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cbxEstudiante.Text = "Seleccione un Estudiante";

                this.cbxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarGrid(Bunifu.Framework.UI.BunifuCustomDataGrid grid, string consulta, string[] encabezados, int p1)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);
                adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.Int).Value = p1;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                grid.DataSource = data.Tables["DATA"];
                estiloGrid(grid, encabezados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estiloGrid(Bunifu.Framework.UI.BunifuCustomDataGrid grid, string[] encabezados)
        {
            // Cargar los encabezados y centrarlos                
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].HeaderText = encabezados[i];
                grid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Color de encabezados y color de letra
            grid.HeaderBgColor = Color.Black;
            grid.HeaderForeColor = Color.White;

            // Fuente
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            // Quitar la ultima fila por defecto
            grid.AllowUserToAddRows = false;

            // Quitar el estilo de rejilla de las celdas del gridView
            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Quitar la columna a la izquierda por defecto
            grid.RowHeadersVisible = false;

            if (grid.Rows.Count > 0)
            {
                // Estilos celdas dentro del gidView
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.AllowUserToResizeRows = false;

                // Seleccionar por defecto la primera fila del gridView
                grid.Rows[0].Selected = true;
            }
        }

        private string valorCelda(Bunifu.Framework.UI.BunifuCustomDataGrid grid, string column)
        {
            string celda = "";
            try
            {
                celda = grid.CurrentRow.Cells[column].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void cbxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstudiante.SelectedIndex >= 0)
            {
                consulta = "SELECT *FROM Matricula WHERE codEstudiante=@p1 order by fechaMatricula desc";
                encabezados = new string[] { "ID MATRICULA", "ID ESTUDIANTE", "FECHA MATRICULA", "MONTO TOTAL", "DESCUENTO", "MONTO FINAL", "FECHA INICIO", "FECHA FIN", "OBSERVACIONES", "SERVICIO", "NUMERO CUOTAS", "INSTITUCION", "TIPO PAGO", "CONCEPTO DESCUENTO", "GRUPO", "GRADO" };
                cargarGrid(gvMatricula, consulta, encabezados, Convert.ToInt16(cbxEstudiante.SelectedValue.ToString()));

                refrescarRecord(lblRecord, "Matriculas pendiente de pago: " + gvMatricula.Rows.Count);
            }
        }

        // Placeholder
        private void cbxEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (cbxEstudiante.Text == "")
                cbxEstudiante.Text = "Selecione un estudiante";
        }

        private void gvMatricula_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codMatricula = Convert.ToInt16(valorCelda(gvMatricula, "codMatricula"));

            consulta = "Select *from Cuota where codMatricula = @p1";
            encabezados = new string[] { "ID MATRICULA", "N° CUOTA", "FECHA PROGRAMADA", "MONTO A PAGAR", "FECHA PAGO", "ESTADO", "MONTO PAGADO" };

            cargarGrid(gvDetalleMatricula, consulta, encabezados, codMatricula);
            gbxInformacionMatricula.Visible = true;

            refrescarRecord(lblInformacionCuota, "El estudiante tiene: " + cuotasPendientes(codMatricula) + " cuota (s) pendientes");
        }

        private void refrescarRecord(Label label, string mensaje)
        {
            label.Text = mensaje;
        }

        private int cuotasPendientes(int codMatricula)
        {
            int cant = 0;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) as cantidad from Cuota where codMatricula = @p1 and montoPagado is null", conex);
                adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.Int).Value = codMatricula;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                cant = Convert.ToInt16(data.Tables["DATA"].Rows[0]["cantidad"].ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cant;
        }

        private void gvMatricula_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int codMatricula = Convert.ToInt16(gvMatricula.Rows[e.RowIndex].Cells[0].Value.ToString());

            consulta = "Select *from Cuota where codMatricula = @p1";
            encabezados = new string[] { "ID MATRICULA", "N° CUOTA", "FECHA PROGRAMADA", "MONTO A PAGAR", "FECHA PAGO", "ESTADO", "MONTO PAGADO" };

            cargarGrid(gvDetalleMatricula, consulta, encabezados, codMatricula);

            /// Mostrar informacion de la detallada de la matricula con respecto sus cuotas
            gbxInformacionMatricula.Visible = true;

            refrescarRecord(lblInformacionCuota, "El estudiante tiene: " + cuotasPendientes(codMatricula) + " cuota (s) pendientes");

            if (gvDetalleMatricula.Rows.Count == 1)
            {
                // Mostrar y ocultar controles
                mostrarControles(lblCuota1, lblCantidadCuota1, lblEstadoCuota1);
                OcultarControles(lblCuota2, lblCantidadCuota2, lblEstadoCuota2);
                OcultarControles(lblCuota3, lblCantidadCuota3, lblEstadoCuota3);

                // Asignar valores                
            }

            else if (gvDetalleMatricula.Rows.Count == 2)
            {
                mostrarControles(lblCuota2, lblCantidadCuota2, lblEstadoCuota2);
                OcultarControles(lblCuota3, lblCantidadCuota3, lblEstadoCuota3);
            }

            else if (gvDetalleMatricula.Rows.Count == 3)
            {
                mostrarControles(lblCuota2, lblCantidadCuota2, lblEstadoCuota2);
                mostrarControles(lblCuota3, lblCantidadCuota3, lblEstadoCuota3);
            }
        }

        private void mostrarControles(BunifuCustomLabel lblCuota, BunifuCustomLabel lblCantidadCuota, BunifuCustomLabel lblEstadoCuota)
        {
            lblCuota.Visible = true;
            lblCantidadCuota.Visible = true;
            lblEstadoCuota.Visible = true;
        }

        private void OcultarControles(BunifuCustomLabel lblCuota, BunifuCustomLabel lblCantidadCuota, BunifuCustomLabel lblEstadoCuota)
        {
            lblCuota.Visible = false;
            lblCantidadCuota.Visible = false;
            lblEstadoCuota.Visible = false;
        }

        /// Tengo que hacerlo en el evento que cambia de Matricula "RowEnter - Matricula" 
        /// Otra opcion es hacer una consulta capturando el ID al momento que cambia de matricula               
        private void asignarValores(BunifuCustomLabel lblCantidadCuota, BunifuCustomLabel lblEstadoCuota)
        {                        
            lblCantidadCuota.Text=valorCelda(gvDetalleMatricula,"");
            lblEstadoCuota.Visible = false;

            // Calcular saldo total - saldo pendiente
        }
    }
}
