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
    public partial class ComplexDataGridView : Bunifu.Framework.UI.BunifuCustomDataGrid
    {
        // Delegados y metodos
        #region
        public delegate void pasarID(int cod);
        public event pasarID pasado;
        #endregion

        public ComplexDataGridView()
        {
            InitializeComponent();
        }

        #region
        string consulta;
        string[] encabezados;
        string celda;
        #endregion        

        public String cadenaConsulta
        {
            get { return consulta; }
            set { consulta = value; }
        }

        public String[] listaEncabezados
        {
            get { return encabezados; }
            set { encabezados = value; }
        }
        
        // General
        public void cargarGrid()
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvComplex.DataSource = data.Tables["DATA"];
                estiloGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        // Cargar gridView a partir de un ID especifico
        public void cargarGrid(int cod)
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);
                adapter.SelectCommand.Parameters.Add("@cod", SqlDbType.Int).Value = cod;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvComplex.DataSource = data.Tables["DATA"];

                estiloGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        // Cargar gridView con filtro like apPaterno, apMaterno, nombre
        public void cargarGrid(string p1, string p2, string p3)
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);
                adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50).Value = p1;
                adapter.SelectCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50).Value = p2;
                adapter.SelectCommand.Parameters.Add("@p3", SqlDbType.VarChar, 50).Value = p3;

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                gvComplex.DataSource = data.Tables["DATA"];

                estiloGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void estiloGrid()
        {
            if (gvComplex.Rows.Count > 0)
            {
                // Cargar los encabezados y centrarlos
                for (int i = 0; i < gvComplex.Columns.Count; i++)
                {
                    gvComplex.Columns[i].HeaderText = listaEncabezados[i];
                    gvComplex.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    gvComplex.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // Estilos
                gvComplex.HeaderBgColor = Color.Black;
                gvComplex.HeaderForeColor = Color.White;

                gvComplex.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);
                gvComplex.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvComplex.MultiSelect = false;
                gvComplex.ReadOnly = true;
                gvComplex.AllowUserToResizeRows = false;
                gvComplex.RowHeadersVisible = false;

                // Quitar la ultima fila por defecto
                gvComplex.AllowUserToAddRows = false;

                // Seleccionar por defecto la primera fila del gridView
                gvComplex.Rows[0].Selected = true;
            }
        }

        public int record()
        {
            return gvComplex.Rows.Count;
        }

        public string valorCelda(string column)
        {
            try
            {
                celda = gvComplex.CurrentRow.Cells[column].Value.ToString();
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
                celda = gvComplex.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return celda;
        }

        private void gvComplex_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            //pasado(Convert.ToInt16(ID()));                        
        }
    }
}
