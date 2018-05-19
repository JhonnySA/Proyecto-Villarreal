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

        /// Falta cargar la foto del docente
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

                boton = MessageBox.Show("Esta seguro que desea actualizar la informacion del docente...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    // UPDATE Docente
                    if (validarCamposObligatoriosDocente())
                    {
                        string[] numeros = txtCelularDocente.Text.Split('-');
                        string numero = "";

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numero += numeros[i];
                        }

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
                        cmd.Parameters.Add("@celular", SqlDbType.Char, 9).Value = numero;
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestaurarDocente_Click(object sender, EventArgs e)
        {
            cargarDatosDocente();
        }

        private void tabDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabDocente.SelectedIndex >= 0)
                {
                    if (tabDocente.SelectedIndex == 1 && valor == 0)
                    {
                        MessageBox.Show("No existe registros", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabDocente.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            if (validarCamposObligatoriosDocente())
            {
                insertarDocente(txtPaternoDocente.Text, txtMaternoDocente.Text, txtNombreDocente.Text, txtCelularDocente.Text);
            }

            else
            {
                MessageBox.Show("Existen datos obligatorios!! \n Datos incompletos...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertarDocente(string paterno, string materno, string nombre, string celular)
        {
            try
            {
                if (validarCamposObligatoriosDocente())
                {
                    string sexo = "";
                    string[] numeros = celular.Split('-');
                    string numero = "";

                    for (int i = 0; i < numeros.Length; i++)
                    {
                        numero += numeros[i];
                    }                    

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
                    cmd.Parameters.Add("@celular", SqlDbType.Char, 9).Value = numero;
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

                else
                {
                    MessageBox.Show("Existen datos obligatorios!! \n Datos incompletos...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la creacion del nuevo Docente ... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Validacion de campos obligatorios para ingresar un docente Error Provider
        /// True si estan completos todos los campos
        /// False si algun campo obligatorio no esta completo
        private bool validarCamposObligatoriosDocente()
        {
            bool valor = true;
            int num;

            /// Dado que el campo numero posee una mascara (999-900-123)
            /// Separamos este campo por el '-'
            /// Luego lo volvemos a unir            
            string[] numeros = txtCelularDocente.Text.Split('-');
            string numero = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                numero += numeros[i];
            }

            try
            {
                if (int.TryParse(txtPaternoDocente.Text, out num))
                {
                    eprCamposDocente.SetError(txtPaternoDocente, "El apellido paterno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtPaternoDocente.Text == "")
                {
                    eprCamposDocente.SetError(txtPaternoDocente, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");
                    valor = false;
                }

                if (int.TryParse(txtMaternoDocente.Text, out num))
                {
                    eprCamposDocente.SetError(txtMaternoDocente, "El apellido materno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtMaternoDocente.Text == "")
                {
                    eprCamposDocente.SetError(txtMaternoDocente, "El campo no debe estar vacio, Ingrese un apellido materno !!!");
                    valor = false;
                }

                if (int.TryParse(txtNombreDocente.Text, out num))
                {
                    eprCamposDocente.SetError(txtNombreDocente, "El nombre no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtNombreDocente.Text == "")
                {
                    eprCamposDocente.SetError(txtNombreDocente, "El campo no debe estar vacio, Ingrese un nombre !!!");
                    valor = false;
                }

                if (numero.Length < 9)
                {
                    eprCamposDocente.SetError(txtCelularDocente, "El campo celular debe contener 9 digitos !!!");
                    valor = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return valor;
        }

        /// Validaciones icono de error campos obligatorios para el campo docente
        private void txtPaternoDocente_Validating(object sender, CancelEventArgs e)
        {
            int num;

            if (int.TryParse(txtPaternoDocente.Text, out num))
            {
                eprCamposDocente.SetError(txtPaternoDocente, "El apellido paterno no debe ser un numero !!!");
            }

            else if (txtPaternoDocente.Text == "")
            {
                eprCamposDocente.SetError(txtPaternoDocente, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");
            }

            else
            {
                eprCamposDocente.SetError(txtPaternoDocente, "");
            }
        }

        private void txtMaternoDocente_Validating(object sender, CancelEventArgs e)
        {
            int num;

            if (int.TryParse(txtMaternoDocente.Text, out num))
            {
                eprCamposDocente.SetError(txtMaternoDocente, "El apellido materno no debe ser un numero !!!");
            }

            else if (txtMaternoDocente.Text == "")
            {
                eprCamposDocente.SetError(txtMaternoDocente, "El campo no debe estar vacio, Ingrese un apellido materno !!!");
            }

            else
            {
                eprCamposDocente.SetError(txtMaternoDocente, "");
            }
        }

        private void txtNombreDocente_Validating(object sender, CancelEventArgs e)
        {
            int num;

            if (int.TryParse(txtNombreDocente.Text, out num))
            {
                eprCamposDocente.SetError(txtNombreDocente, "El nombre no debe ser un numero !!!");
            }

            else if (txtNombreDocente.Text == "")
            {
                eprCamposDocente.SetError(txtNombreDocente, "El campo no debe estar vacio, Ingrese un nombre !!!");
            }

            else
            {
                eprCamposDocente.SetError(txtNombreDocente, "");
            }
        }

        private void txtCelularDocente_Validating(object sender, CancelEventArgs e)
        {
            string[] numeros = txtCelularDocente.Text.Split('-');
            string numero = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                numero += numeros[i];
            }

            if (numero.Length < 9)
            {
                eprCamposDocente.SetError(txtCelularDocente, "El campo celular debe contener 9 digitos !!!");
            }

            else
            {
                eprCamposDocente.SetError(txtCelularDocente, "");
            }            
        }
    }
}
