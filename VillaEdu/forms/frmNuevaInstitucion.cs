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
using System.Globalization;

namespace VillaEdu.forms
{
    public partial class frmNuevaInstitucion : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string id, string nombre);
        public event PasarID pasado;

        #region
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        // Dar fomato a los datos recibidos
        TextInfo info = new CultureInfo("es-ES", false).TextInfo;
        #endregion

        public frmNuevaInstitucion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no registrar la institucion...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevaInstitucion_Click(object sender, EventArgs e)
        {
            if (camposInstitucionCompletos())
            {
                insertarInstitucion();
            }
        }

        private void insertarInstitucion()
        {
            try
            {
                int id = 0;
                string nombre = "";

                // Para registrar primero debo preguntar si existe la institucion que se va a insertar
                if (!ExisteInstitucion())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Institucion(nombre, direccion) VALUES(@nombre, @direccion); SELECT SCOPE_IDENTITY()", conex);

                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(txtNombreInstitucion.Text.ToLower()));
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = info.ToTitleCase(txtDireccionInstitucion.Text.ToLower());


                    conex.Open();

                    id = Convert.ToInt16(cmd.ExecuteScalar());
                    nombre = txtNombreInstitucion.Text;
                    conex.Close();

                    pasado(id.ToString(), nombre);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe la institucion...");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la creacion de nueva Institucion... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteInstitucion()
        {
            bool valor = false;

            SqlDataAdapter adapter = new SqlDataAdapter("Select *from Institucion where nombre = @nombre", conex);
            adapter.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = txtNombreInstitucion.Text;
            DataSet data = new DataSet();
            adapter.Fill(data, "DATA");

            if (data.Tables["DATA"].Rows.Count > 0)
            {
                valor = true;
            }
            return valor;
        }

        private bool camposInstitucionCompletos()
        {
            bool valor = false;
            if (txtNombreInstitucion.Text != "")
            {
                valor = true;
            }
            return valor;
        }
    }
}