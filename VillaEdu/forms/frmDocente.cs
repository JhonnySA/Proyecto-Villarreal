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
    public partial class frmDocente : Form
    {

        #region    
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        public int cod { get; set; }        

        // valor 0 - creacion
        // valor 1 - actualizacion
        int valor;

        // Dar fomato a los datos recibidos
        TextInfo info = new CultureInfo("es-ES", false).TextInfo;
        #endregion

        public frmDocente(int valor)
        {
            InitializeComponent();
            this.valor = valor;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no registrar al docente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {
            // CREACION
            if (valor == 0)
            {
                btnCrearDocente.Visible = true;
                btnRestaurarDocente.Visible = false;
            }

            // ACTUALIZACION
            else if (valor == 1)
            {
                txtDNIDocente.Focus();
                cargarDatosDocente();

                // Boton de edicion
                btnActualizarDocente.Visible = true;

                // Boton restaurar datos (Solo si no se ha guardado los datos)
                btnRestaurarDocente.Visible = true;
            }
        }

        // Falta cargar la foto del docente
        private void cargarDatosDocente()
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter datos = new SqlDataAdapter("Select * from Docente where codDocente = @codDoc", conex);
                datos.SelectCommand.Parameters.Add("@codDoc", SqlDbType.Int).Value = cod;
                DataSet DB = new DataSet();
                datos.Fill(DB, "Docentes");

                // Cargar los datos del estudiante para actualizar
                lblIDDocente.Text = cod.ToString();
                txtDNIDocente.Text = DB.Tables["Docentes"].Rows[0]["dni"].ToString();
                txtPaternoDocente.Text = DB.Tables["Docentes"].Rows[0]["apPaterno"].ToString();
                txtMaternoDocente.Text = DB.Tables["Docentes"].Rows[0]["apMaterno"].ToString();
                txtNombreDocente.Text = DB.Tables["Docentes"].Rows[0]["nombre"].ToString();

                if (DB.Tables["Docentes"].Rows[0]["sexo"].ToString().Equals("M"))
                {
                    rbtnMasculinoEst.Checked = true;
                }
                else
                {
                    rbtnFemeninoEst.Checked = true;
                }

                txtTelefonoDocente.Text = DB.Tables["Docentes"].Rows[0]["telefono"].ToString();
                txtCelularDocente.Text = DB.Tables["Docentes"].Rows[0]["celular"].ToString();
                txtDireccionDocente.Text = DB.Tables["Docentes"].Rows[0]["direccion"].ToString();
                txtProfesionDocente.Text = DB.Tables["Docentes"].Rows[0]["profesion"].ToString();
                txtGradoAcademico.Text = DB.Tables["Docentes"].Rows[0]["gradoAcademico"].ToString();

                /// Cargar foto del docente: -------------------------
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnActualizarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = "";

                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea actualizar la informacion del docente...?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    // UPDATE Docente
                    if (camposDocenteCompletos())
                    {
                        SqlCommand cmd = new SqlCommand("Update Docente set apPaterno = @apPaterno, apMaterno = @apMaterno, nombre = @nombre, sexo = @sexo, telefono = @telefono, celular = @celular, dni = @dni, direccion = @direccion, profesion = @profesion, gradoAcademico = @gradoAcademico where codDocente = @codDoc", conex);

                        cmd.Parameters.Add("@codDoc", SqlDbType.Int).Value = cod;
                        cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(txtPaternoDocente.Text.ToLower()));
                        cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar, 50).Value = info.ToTitleCase(txtMaternoDocente.Text.ToLower());
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtNombreDocente.Text.ToLower());

                        if (rbtnMasculinoEst.Checked)
                        {
                            sexo = "M";
                        }
                        else
                        {
                            sexo = "F";
                        }

                        cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = sexo;
                        cmd.Parameters.Add("@telefono", SqlDbType.Char, 9).Value = txtTelefonoDocente.Text;
                        cmd.Parameters.Add("@celular", SqlDbType.Char, 9).Value = txtCelularDocente.Text;
                        cmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = txtDNIDocente.Text;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtDireccionDocente.Text.ToLower());
                        cmd.Parameters.Add("@profesion", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtProfesionDocente.Text.ToLower());
                        cmd.Parameters.Add("@gradoAcademico", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtGradoAcademico.Text.ToLower());

                        conex.Open();

                        int resp = cmd.ExecuteNonQuery();
                        conex.Close();
                        if (resp == 1)
                            controles_usuario.CustomDialog.ShowDialog("ACTUALIZACION DE INFORMACION DE DOCENTE EXITOSA !!!");
                        else
                            MessageBox.Show("ERROR AL INTENTAR ACTULIZAR INFORMACION DE DOCENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Existen datos obligatorios!! \n Datos incompletos...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        señalarCamposObligatorios();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool camposDocenteCompletos()
        {
            bool valor = false;
            if (txtPaternoDocente.Text != "" && txtMaternoDocente.Text != "" && txtNombreDocente.Text != "" && txtCelularDocente.Text != "")
            {
                valor = true;
            }
            return valor;
        }

        private void señalarCamposObligatorios()
        {
            if (txtPaternoDocente.Text == "")
            {
                txtPaternoDocente.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (txtPaternoDocente.Text != "")
            {
                txtPaternoDocente.BackColor = SystemColors.Control;
            }
            if (txtMaternoDocente.Text == "")
            {
                txtMaternoDocente.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (txtMaternoDocente.Text != "")
            {
                txtMaternoDocente.BackColor = SystemColors.Control;
            }
            if (txtNombreDocente.Text == "")
            {
                txtNombreDocente.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (txtNombreDocente.Text != "")
            {
                txtNombreDocente.BackColor = SystemColors.Control;
            }
            if (txtCelularDocente.Text == "")
            {
                txtCelularDocente.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (txtCelularDocente.Text != "")
            {
                txtCelularDocente.BackColor = SystemColors.Control;
            }
        }

        private void btnRestaurarDocente_Click(object sender, EventArgs e)
        {
            cargarDatosDocente();
        }

        private void tabDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valor == 1)
            {
                // Preguntar si este docente con 'COD' recibido tiene registro de contratos anteriores
            }
            else if (valor == 0)
            {
                // Ocultar el pag de 'CONTRATOS ANTERIORES'
                MessageBox.Show("No existe historial...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                señalarCamposObligatorios();

                /// Falta corregir esto
                tabDocente.SelectedIndex = 0;
            }
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            if (camposDocenteCompletos())
            {
                insertarDocente(txtPaternoDocente.Text, txtMaternoDocente.Text, txtNombreDocente.Text, txtCelularDocente.Text);
            }
            else
            {
                MessageBox.Show("Existen datos obligatorios!! \n Datos incompletos...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                señalarCamposObligatorios();
            }
        }

        private void insertarDocente(string paterno, string materno, string nombre, string celular)
        {
            try
            {
                string sexo = "";

                SqlCommand cmd = new SqlCommand("INSERT INTO Docente(apPaterno, apMaterno, nombre, sexo, celular, telefono, dni, direccion, profesion, gradoAcademico) VALUES(@apPaterno, @apMaterno, @nombre, @sexo, @celular, @telefono, @dni, @direccion, @profesion, @gradoAcademico)", conex);

                cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(paterno.ToLower()));
                cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar, 50).Value = info.ToTitleCase(materno.ToLower());
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = info.ToTitleCase(nombre.ToLower());

                if (rbtnMasculinoEst.Checked)
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }

                cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = sexo;
                cmd.Parameters.Add("@celular", SqlDbType.Char, 9).Value = celular;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = txtTelefonoDocente.Text;
                cmd.Parameters.Add("@dni", SqlDbType.Char, 9).Value = txtDNIDocente.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtDireccionDocente.Text.ToLower());
                cmd.Parameters.Add("@profesion", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtProfesionDocente.Text.ToLower());
                cmd.Parameters.Add("@gradoAcademico", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtGradoAcademico.Text.ToLower());

                conex.Open();

                int resp = cmd.ExecuteNonQuery();
                conex.Close();
                if (resp == 1)
                    controles_usuario.CustomDialog.ShowDialog("CREACION DE DOCENTE EXITOSA !!!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la creacion del nuevo Docente ... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
