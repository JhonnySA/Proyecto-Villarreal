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
    public partial class frmEstudiante : Form
    {
        // Eventos y Delegados:
        public delegate void PasarID(string idEstudiante, string nombreEstudiante, string nombreApoderado);
        public event PasarID pasado;

        #region    
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        public int cod { get; set; }
        public int devolucion { get; set; }
        int codApo;

        // valor 0 - creacion
        // valor 1 - actualizacion
        int valor;

        // Dar fomato a los datos recibidos
        TextInfo info = new CultureInfo("es-ES", false).TextInfo;
        #endregion

        public frmEstudiante(int valor)
        {
            InitializeComponent();
            this.valor = valor;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no registrar al estudiante...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            // CREACION
            if (valor == 0)
            {
                tabEstudiante.SelectedIndex = 1;
                btnSeleccionarApoderado.Visible = true;

                // Boton Estudiante                
                btnCrearEstudiante.Visible = true;
                btnCrearEstudiante.BringToFront();

                // Boton Apoderado                               
                btnNuevoApoderado.BringToFront();
                btnNuevoApoderado.Visible = true;

                // Label Estudiante
                lblEstudiante.Visible = false;
                lblIDEstudiante.Visible = false;
            }

            // ACTUALIZACION
            else if (valor == 1)
            {
                tabEstudiante.SelectedIndex = 0;
                cargarDatosEstudiante();
                cargarDatosApoderado(codApo);

                // Boton Estudiante
                btnRestaurarEstudiante.Visible = true;
                btnRegistroAcademico.Visible = true;
                btnActualizarEstudiante.Visible = true;

                // Boton Apoderado
                btnRestaurarApoderado.Visible = true;
                btnActualizarApoderado.Visible = true;

                // Habilitar los campos del apoderado para edicion
                txtDNIApoderado.Enabled = true;
                txtPaternoApoderado.Enabled = true;
                txtMaternoApoderado.Enabled = true;
                txtNombreApoderado.Enabled = true;
                txtTelefonoApoderado.Enabled = true;
                txtCelularApoderado.Enabled = true;
                txtCorreoApoderado.Enabled = true;
                txtDireccionApoderado.Enabled = true;
            }
        }

        private void cargarDatosEstudiante()
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter datos = new SqlDataAdapter("Select * from Estudiante where codEstudiante = @codEst", conex);
                datos.SelectCommand.Parameters.Add("@codEst", SqlDbType.Int).Value = cod;
                DataSet DB = new DataSet();
                datos.Fill(DB, "Estudiantes");

                // Cargar los datos del estudiante para actualizar
                lblIDEstudiante.Text = cod.ToString();
                txtPaternoEstudiante.Text = DB.Tables["Estudiantes"].Rows[0]["apPaterno"].ToString();
                txtMaternoEstudiante.Text = DB.Tables["Estudiantes"].Rows[0]["apMaterno"].ToString();
                txtNombrestudiante.Text = DB.Tables["Estudiantes"].Rows[0]["nombre"].ToString();

                if (DB.Tables["Estudiantes"].Rows[0]["sexo"].ToString().Equals("M"))
                {
                    rbtnMasculinoEst.Checked = true;
                }
                else
                {
                    rbtnFemeninoEst.Checked = true;
                }

                codApo = Convert.ToInt16(DB.Tables["Estudiantes"].Rows[0]["codApoderado"].ToString());
                dateFechaNac.Value = Convert.ToDateTime(DB.Tables["Estudiantes"].Rows[0]["fechaNacimiento"].ToString());

                // Cargar foto de estudiante: -------------------------
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cargarDatosApoderado(int codApoderado)
        {
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter datos = new SqlDataAdapter("Select * from Apoderado where codApoderado = @codApo", conex);
                datos.SelectCommand.Parameters.Add("@codApo", SqlDbType.Int).Value = codApoderado;
                DataSet DB = new DataSet();
                datos.Fill(DB, "Apoderado");

                // Cargar los datos del estudiante para actualizar
                lblIDApoderado.Text = codApoderado.ToString();
                txtPaternoApoderado.Text = DB.Tables["Apoderado"].Rows[0]["apPaterno"].ToString();
                txtMaternoApoderado.Text = DB.Tables["Apoderado"].Rows[0]["apMaterno"].ToString();
                txtNombreApoderado.Text = DB.Tables["Apoderado"].Rows[0]["nombre"].ToString();
                txtCelularApoderado.Text = DB.Tables["Apoderado"].Rows[0]["celular"].ToString();
                txtTelefonoApoderado.Text = DB.Tables["Apoderado"].Rows[0]["telefono"].ToString();
                txtCorreoApoderado.Text = DB.Tables["Apoderado"].Rows[0]["correo"].ToString();
                txtDNIApoderado.Text = DB.Tables["Apoderado"].Rows[0]["dni"].ToString();
                txtDireccionApoderado.Text = DB.Tables["Apoderado"].Rows[0]["direccion"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string traerNombreApoderado(int codApoderado)
        {
            string nombre = "";
            try
            {
                SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                SqlDataAdapter datos = new SqlDataAdapter("Select * from Apoderado where codApoderado = @codApo", conex);
                datos.SelectCommand.Parameters.Add("@codApo", SqlDbType.Int).Value = codApoderado;
                DataSet data = new DataSet();
                datos.Fill(data, "DATA");

                nombre = data.Tables["DATA"].Rows[0]["apPaterno"].ToString() + " " + data.Tables["DATA"].Rows[0]["apMaterno"].ToString() + ", " + data.Tables["DATA"].Rows[0]["nombre"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return nombre;
        }

        private void btnRestaurarEstudiante_Click(object sender, EventArgs e)
        {
            if (cod != 0)
            {
                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea resetear la informacion del estudiante ya existente de la Base de Datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    cargarDatosEstudiante();
                }
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = "";

                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea actualizar la informacion del estudiante?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    // UPDATE Estudiante
                    if (validarCamposObligatoriosEstudiante())
                    {
                        if (txtPaternoEstudiante.Text != "" && txtMaternoEstudiante.Text != "" && txtNombrestudiante.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand("Update Estudiante set apPaterno = @apPaterno, apMaterno = @apMaterno, nombre = @nombre, sexo = @sexo, fechaNacimiento = @fNac where codEstudiante = @codEst", conex);

                            cmd.Parameters.Add("@codEst", SqlDbType.Int).Value = cod;
                            cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(txtPaternoEstudiante.Text.ToLower()));
                            cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar, 50).Value = info.ToTitleCase(txtMaternoEstudiante.Text.ToLower());
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtNombrestudiante.Text.ToLower());

                            if (rbtnMasculinoEst.Checked)
                            {
                                sexo = "M";
                            }
                            else
                            {
                                sexo = "F";
                            }

                            cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = sexo;
                            cmd.Parameters.Add("@fNac", SqlDbType.Date).Value = dateFechaNac.Value;

                            conex.Open();

                            int resp = cmd.ExecuteNonQuery();
                            conex.Close();
                            if (resp == 1)
                                controles_usuario.CustomDialog.ShowDialog("ACTUALIZACION DE INFORMACION DE ESTUDIANTE EXITOSA !!!");
                            else
                                MessageBox.Show("ERROR AL INTENTAR ACTULIZAR INFORMACION DE ESTUDIANTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Campos del Estudiante incompletos...!", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistroAcademico_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar como parametro el id del estudiante seleccionado 

                frmRegistroAcademicoEstudiante regEst = new frmRegistroAcademicoEstudiante();
                regEst.cod = cod;
                regEst.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEstudiante.SelectedIndex == 0)
            {
                txtPaternoEstudiante.Focus();
            }

            else if (tabEstudiante.SelectedIndex == 1)
            {
                if (cod > 0)
                {
                    // Cargar la informacion del apoderado
                    cargarDatosApoderado(codApo);
                }
            }
        }

        private void btnSeleccionarApoderado_Click(object sender, EventArgs e)
        {
            forms.frmSeleccionarApoderado Apo = new frmSeleccionarApoderado();
            Apo.pasado += new forms.frmSeleccionarApoderado.PasarID(ejecutar);
            Apo.ShowDialog();

            lblApoderado.Visible = true;
            lblIDApoderado.Visible = true;

            txtDNIApoderado.Enabled = false;
            txtPaternoApoderado.Enabled = false;
            txtMaternoApoderado.Enabled = false;
            txtNombreApoderado.Enabled = false;
            txtTelefonoApoderado.Enabled = false;
            txtCelularApoderado.Enabled = false;
            txtCorreoApoderado.Enabled = false;
            txtDireccionApoderado.Enabled = false;
        }

        public void ejecutar(string dato)
        {
            cargarDatosApoderado(Convert.ToInt16(dato));
        }

        private void btnNuevoApoderado_Click(object sender, EventArgs e)
        {
            lblApoderado.Visible = false;
            lblIDApoderado.Visible = false;
            txtDNIApoderado.Enabled = true;
            txtPaternoApoderado.Enabled = true;
            txtMaternoApoderado.Enabled = true;
            txtNombreApoderado.Enabled = true;
            txtTelefonoApoderado.Enabled = true;
            txtCelularApoderado.Enabled = true;
            txtCorreoApoderado.Enabled = true;
            txtDireccionApoderado.Enabled = true;

            txtDNIApoderado.Text = "";
            txtPaternoApoderado.Text = "";
            txtMaternoApoderado.Text = "";
            txtNombreApoderado.Text = "";
            txtTelefonoApoderado.Text = "";
            txtCelularApoderado.Text = "";
            txtCorreoApoderado.Text = "";
            txtDireccionApoderado.Text = "";

            txtPaternoApoderado.Focus();
        }

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            // Primero hay que registrar al apoderado si no tiene un cod de apoderado
            if (lblIDApoderado.Text != "")
            {
                // Preguntar si todos los campos del estudiante estan completos para insertar con el cod del Apo                
                if (validarCamposObligatoriosEstudiante())
                {
                    // Insertar al estudiante con el cod del Apo
                    int apoderado = Convert.ToInt16(lblIDApoderado.Text);
                    insertarEstudiante(txtPaternoEstudiante.Text, txtMaternoEstudiante.Text, txtNombrestudiante.Text, apoderado);
                }

                else
                {
                    MessageBox.Show("Campos del estudiante incompletos ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // 1. Insertar al apoderado
                if (validarCamposObligatoriosApoderado() && validarCamposObligatoriosEstudiante())
                {
                    int apoderado = insertarApoderado();

                    // 2. Insertar al estudiante con el cod del Apo generado
                    // Preguntar si los campos del estudiante son completos
                    insertarEstudiante(txtPaternoEstudiante.Text, txtMaternoEstudiante.Text, txtNombrestudiante.Text, apoderado);
                }
                else if (!validarCamposObligatoriosApoderado())
                {
                    MessageBox.Show("Faltan campos del Apoderado por llenar ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabEstudiante.SelectedIndex = 1;
                }
            }
        }

        private void insertarEstudiante(string paterno, string materno, string nombre, int apoderado)
        {
            try
            {
                string idEstudiante = "";
                string nombreEstudiante = "";
                string nombreApoderado = "";
                string sexo = "";

                SqlCommand cmd = new SqlCommand("INSERT INTO Estudiante(apPaterno, apMaterno, nombre, sexo, codApoderado, fechaNacimiento) VALUES(@apPaterno, @apMaterno, @nombre, @sexo, @codApo, @fNac); SELECT SCOPE_IDENTITY()", conex);

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
                cmd.Parameters.Add("@codApo", SqlDbType.Int).Value = apoderado;
                cmd.Parameters.Add("@fNac", SqlDbType.Date).Value = dateFechaNac.Value;

                conex.Open();

                // Capturar los datos a enviar (IdEstudiante, nombreEstudiante, nombreApoderado)
                idEstudiante = Convert.ToInt16(cmd.ExecuteScalar()).ToString();
                nombreEstudiante = paterno + " " + materno + ", " + nombre;
                nombreApoderado = traerNombreApoderado(apoderado);

                conex.Close();
                if (Convert.ToInt16(idEstudiante) > 0)
                {
                    controles_usuario.CustomDialog.ShowDialog("CREACION DE ESTUDIANTE EXITOSA !!!");

                    // Pasa los datos del nuevo estudiante recien creado (SIRVE PARA LAS MATRICULAS) no para la parte del modulo de estudiantes       
                    if (devolucion == 1)
                    {
                        pasado(idEstudiante, nombreEstudiante, nombreApoderado);
                    }                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la creacion del nuevo Estudiante xD... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int insertarApoderado()
        {
            int id = 0;

            try
            {
                string[] numeros = txtCelularApoderado.Text.Split(' ');
                string numero = "";

                for (int i = 0; i < numeros.Length; i++)
                {
                    numero += numeros[i];
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Apoderado(apPaterno, apMaterno, nombre, celular, telefono, correo, dni, direccion) VALUES(@apPaterno, @apMaterno, @nombre, @celular, @telefono, @correo, @dni, @direccion); 	SELECT SCOPE_IDENTITY()", conex);

                //cmd.Parameters.Add("@codEst", SqlDbType.Int).Value = cod;
                cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(txtPaternoApoderado.Text.ToLower()));
                cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar, 50).Value = info.ToTitleCase(txtMaternoApoderado.Text.ToLower());
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtNombreApoderado.Text.ToLower());

                cmd.Parameters.Add("@celular", SqlDbType.VarChar, 9).Value = numero;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 12).Value = txtTelefonoApoderado.Text;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = txtCorreoApoderado.Text;
                cmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = txtDNIApoderado.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = txtDireccionApoderado.Text;

                conex.Open();

                id = Convert.ToInt16(cmd.ExecuteScalar());
                conex.Close();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return id;
        }

        /// Validacion de campos obligatorios para ingresar un apoderado Error Provider
        /// True si estan completos todos los campos
        /// False si algun campo obligatorio no esta completo
        private bool validarCamposObligatoriosApoderado()
        {
            bool valor = true;
            int num;

            /// Dado que el campo numero posee una mascara (999-900-123)
            /// Separamos este campo por el '-'
            /// Luego lo volvemos a unir            
            string[] numeros = txtCelularApoderado.Text.Split(' ');
            string numero = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                numero += numeros[i];
            }

           /* try
            {
                if (int.TryParse(txtPaternoApoderado.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtPaternoApoderado, "El apellido paterno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtPaternoApoderado.Text == "")
                {
                    eprCamposObligatorios.SetError(txtPaternoApoderado, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");
                    valor = false;
                }

                if (int.TryParse(txtMaternoApoderado.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtMaternoApoderado, "El apellido materno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtMaternoApoderado.Text == "")
                {
                    eprCamposObligatorios.SetError(txtMaternoApoderado, "El campo no debe estar vacio, Ingrese un apellido materno !!!");
                    valor = false;
                }

                if (int.TryParse(txtNombreApoderado.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtNombreApoderado, "El nombre no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtNombreApoderado.Text == "")
                {
                    eprCamposObligatorios.SetError(txtNombreApoderado, "El campo no debe estar vacio, Ingrese un nombre !!!");
                    valor = false;
                }

                if (int.TryParse(txtDireccionApoderado.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtDireccionApoderado, "El nombre no debe ser solo un numero !!!");
                    valor = false;
                }

                else if (txtDireccionApoderado.Text == "")
                {
                    eprCamposObligatorios.SetError(txtDireccionApoderado, "El campo no debe estar vacio, Ingrese una direccion !!!");
                    valor = false;
                }

                if (numero.Length < 9)
                {
                    eprCamposObligatorios.SetError(txtCelularApoderado, "El campo celular debe contener 9 digitos !!!");
                    valor = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            return valor;
        }

        /// Validacion de campos obligatorios para ingresar un estudiante Error Provider
        /// True si estan completos todos los campos
        /// False si algun campo obligatorio no esta completo
        private bool validarCamposObligatoriosEstudiante()
        {
            bool valor = true;
            int num;

           /* try
            {
                if (int.TryParse(txtPaternoEstudiante.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtPaternoEstudiante, "El apellido paterno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtPaternoEstudiante.Text == "")
                {
                    eprCamposObligatorios.SetError(txtPaternoEstudiante, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");
                    valor = false;
                }

                if (int.TryParse(txtMaternoEstudiante.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtMaternoEstudiante, "El apellido materno no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtMaternoEstudiante.Text == "")
                {
                    eprCamposObligatorios.SetError(txtMaternoEstudiante, "El campo no debe estar vacio, Ingrese un apellido materno !!!");
                    valor = false;
                }

                if (int.TryParse(txtNombrestudiante.Text, out num))
                {
                    eprCamposObligatorios.SetError(txtNombrestudiante, "El nombre no debe ser un numero !!!");
                    valor = false;
                }

                else if (txtNombrestudiante.Text == "")
                {
                    eprCamposObligatorios.SetError(txtNombrestudiante, "El campo no debe estar vacio, Ingrese un nombre !!!");
                    valor = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            return valor;
        }

        private void btnActualizarApoderado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea actualizar la informacion del apoderado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    // UPDATE Apoderado
                    if (validarCamposObligatoriosApoderado())
                    {
                        string[] numeros = txtCelularApoderado.Text.Split(' ');
                        string numero = "";

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numero += numeros[i];
                        }

                        SqlCommand cmd = new SqlCommand("Update Apoderado set apPaterno = @apPaterno, apMaterno = @apMaterno, nombre = @nombre, celular = @celular, telefono = @telefono, correo = @correo, dni = @dni, direccion = @direccion where codApoderado = @codApo", conex);

                        cmd.Parameters.Add("@codApo", SqlDbType.Int).Value = codApo;
                        cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar, 50).Value = (info.ToTitleCase(txtPaternoApoderado.Text.ToLower()));
                        cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar, 50).Value = info.ToTitleCase(txtMaternoApoderado.Text.ToLower());
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtNombreApoderado.Text.ToLower());
                        cmd.Parameters.Add("@celular", SqlDbType.Char, 9).Value = numero;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = txtTelefonoApoderado.Text;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = txtCorreoApoderado.Text;
                        cmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = txtDNIApoderado.Text;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = info.ToTitleCase(txtDireccionApoderado.Text);

                        conex.Open();

                        int resp = cmd.ExecuteNonQuery();
                        conex.Close();
                        if (resp == 1)
                            controles_usuario.CustomDialog.ShowDialog("ACTUALIZACION DE INFORMACION DE APODERADO EXITOSA !!!");
                        else
                            MessageBox.Show("ERROR AL INTENTAR ACTULIZAR INFORMACION DEL APODERADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Campos del Apoderado incompletos...!", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// Preguntar si desea resetear los datos ya existentes
        private void btnRestaurarApoderado_Click(object sender, EventArgs e)
        {
            if (cod != 0)
            {
                DialogResult boton;

                boton = MessageBox.Show("Esta seguro que desea resetear la informacion del apoderado ya existente de la Base de Datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == System.Windows.Forms.DialogResult.Yes)
                {
                    cargarDatosApoderado(codApo);
                }
            }
        }

        /// Validaciones icono de error campos obligatorios para los campos del apoderado        
        private void txtPaternoApoderado_Validating(object sender, CancelEventArgs e)
        {
            int num;

           /* if (int.TryParse(txtPaternoApoderado.Text, out num))
            {
                eprCamposObligatorios.SetError(txtPaternoApoderado, "El apellido paterno no debe ser un numero !!!");            
            }

            else if (txtPaternoApoderado.Text == "")
            {
                eprCamposObligatorios.SetError(txtPaternoApoderado, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");            
            }

            else
            {
                eprCamposObligatorios.SetError(txtPaternoApoderado, "");
            }*/
        }

        private void txtMaternoApoderado_Validating(object sender, CancelEventArgs e)
        {
            int num;

           /* if (int.TryParse(txtMaternoApoderado.Text, out num))
            {
                eprCamposObligatorios.SetError(txtMaternoApoderado, "El apellido materno no debe ser un numero !!!");            
            }

            else if (txtMaternoApoderado.Text == "")
            {
                eprCamposObligatorios.SetError(txtMaternoApoderado, "El campo no debe estar vacio, Ingrese un apellido materno !!!");                
            }

            else
            {
                eprCamposObligatorios.SetError(txtMaternoApoderado, "");
            }*/
        }

        private void txtNombreApoderado_Validating(object sender, CancelEventArgs e)
        {
            int num;

            /*if (int.TryParse(txtNombreApoderado.Text, out num))
            {
                eprCamposObligatorios.SetError(txtNombreApoderado, "El nombre no debe ser un numero !!!");            
            }

            else if (txtNombreApoderado.Text == "")
            {
                eprCamposObligatorios.SetError(txtNombreApoderado, "El campo no debe estar vacio, Ingrese un nombre !!!");                
            }

            else
            {
                eprCamposObligatorios.SetError(txtNombreApoderado, "");
            }*/
        }

        private void txtCelularApoderado_Validating(object sender, CancelEventArgs e)
        {
            string[] numeros = txtCelularApoderado.Text.Split(' ');
            string numero = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                numero += numeros[i];
            }

           /* if (numero.Length < 9)
            {
                eprCamposObligatorios.SetError(txtCelularApoderado, "El campo celular debe contener 9 digitos !!!");
            }

            else
            {
                eprCamposObligatorios.SetError(txtCelularApoderado, "");
            }   */         
        }

        private void txtDireccionApoderado_Validating(object sender, CancelEventArgs e)
        {
            int num;

           /* if (int.TryParse(txtDireccionApoderado.Text, out num))
            {
                eprCamposObligatorios.SetError(txtDireccionApoderado, "El nombre no debe ser solo un numero !!!");             
            }

            else if (txtDireccionApoderado.Text == "")
            {
                eprCamposObligatorios.SetError(txtDireccionApoderado, "El campo no debe estar vacio, Ingrese una direccion !!!");
            }

            else
            {
                eprCamposObligatorios.SetError(txtDireccionApoderado, "");
            }*/
        }

        /// Validaciones icono de error campos obligatorios para los campos del estudiante
        private void txtPaternoEstudiante_Validating(object sender, CancelEventArgs e)
        {
            int num;

            /*if (int.TryParse(txtPaternoEstudiante.Text, out num))
            {
                eprCamposObligatorios.SetError(txtPaternoEstudiante, "El apellido paterno no debe ser un numero !!!");
            }

            else if (txtPaternoEstudiante.Text == "")
            {
                eprCamposObligatorios.SetError(txtPaternoEstudiante, "El campo no debe estar vacio, Ingrese un apellido paterno !!!");
            }

            else
            {
                eprCamposObligatorios.SetError(txtPaternoEstudiante, "");
            }*/
        }

        private void txtMaternoEstudiante_Validating(object sender, CancelEventArgs e)
        {
            int num;

           /* if (int.TryParse(txtMaternoEstudiante.Text, out num))
            {
                eprCamposObligatorios.SetError(txtMaternoEstudiante, "El apellido materno no debe ser un numero !!!");
            }

            else if (txtMaternoEstudiante.Text == "")
            {
                eprCamposObligatorios.SetError(txtMaternoEstudiante, "El campo no debe estar vacio, Ingrese un apellido materno !!!");                
            }

            else
            {
                eprCamposObligatorios.SetError(txtMaternoEstudiante, "");
            }*/
        }

        private void txtNombrestudiante_Validating(object sender, CancelEventArgs e)
        {
            int num;

            /*if (int.TryParse(txtNombrestudiante.Text, out num))
            {
                eprCamposObligatorios.SetError(txtNombrestudiante, "El nombre no debe ser un numero !!!");           
            }

            else if (txtNombrestudiante.Text == "")
            {
                eprCamposObligatorios.SetError(txtNombrestudiante, "El campo no debe estar vacio, Ingrese un nombre !!!");                
            }

            else
            {
                eprCamposObligatorios.SetError(txtNombrestudiante, "");
            }*/
        }
    }
}
