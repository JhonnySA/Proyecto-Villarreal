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
using Bunifu.Framework.UI;
using System.Globalization;

namespace VillaEdu.forms
{
    public partial class frmMatricula : Form
    {

        #region   
        // Conexion general
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);

        public int idUltimaMatricula { get; set; }
        string consulta;

        // Globalizacion
        TextInfo info = new CultureInfo("es-ES", false).TextInfo;
        #endregion

        public frmMatricula()
        {
            InitializeComponent();
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            // Asigar el minDate a la fecha de inicio, Cuota1, Cuota2, Cuota3
            dateFechaInicioClases.MinDate = DateTime.Now;
            dateFechaCuota1.MinDate = DateTime.Now;
            dateFechaCuota2.MinDate = DateTime.Now;
            dateFechaCuota3.MinDate = DateTime.Now;

            // Recibir un 'COUNT' + 1 de las matriculas
            lblNumeroMatricula.Text = "ID MATRICULA #... " + (idUltimaMatricula + 1);

            // Mostrar fecha actual en formato: "Miercoles 24 de junio del 2018"        
            DateTime fechaActual = DateTime.Now;
            string dia = info.ToTitleCase(fechaActual.ToString("dddd"));
            string mes = info.ToTitleCase(fechaActual.ToString("MMMM"));

            lblFechaMatricula.Text = "FECHA MATRICULA... " + dia + " " + fechaActual.Day.ToString() + " de " + mes + " del " + fechaActual.Year;

            cargarComboServicio();
            cargarComboNivel();
            cbxTurno.Text = "Seleccione un turno";
        }

        DateTime GetLastDayOf(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        private void cargarComboServicio()
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

                this.cbxServicio.SelectedIndexChanged += new System.EventHandler(this.cbxServicio_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarComboNivel()
        {
            try
            {
                consulta = "Select codNivel,nombre from Nivel";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conex);

                DataSet data = new DataSet();
                adapter.Fill(data, "DATA");

                cbxNivel.DataSource = data.Tables["DATA"].DefaultView;
                cbxNivel.DisplayMember = "nombre";
                cbxNivel.ValueMember = "codNivel";
                cbxNivel.Tag = "nombre";

                cbxNivel.Text = "Seleccione un Nivel";

                this.cbxNivel.SelectedIndexChanged += new System.EventHandler(this.cbxNivel_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarComboGrado(string nivel)
        {
            try
            {
                if (nivel.Equals("Primaria"))
                {
                    cbxGrado.Items.Clear();

                    cbxGrado.Items.Add("1");
                    cbxGrado.Items.Add("2");
                    cbxGrado.Items.Add("3");
                    cbxGrado.Items.Add("4");
                    cbxGrado.Items.Add("5");
                    cbxGrado.Items.Add("6");
                }

                else if (nivel.Equals("Secundaria"))
                {
                    cbxGrado.Items.Clear();

                    cbxGrado.Items.Add("1");
                    cbxGrado.Items.Add("2");
                    cbxGrado.Items.Add("3");
                    cbxGrado.Items.Add("4");
                    cbxGrado.Items.Add("5");
                }

                cbxGrado.Text = "Seleccione un Grado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro no registrar la matricula...?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSeleccionarEstudiante_Click(object sender, EventArgs e)
        {
            forms.frmSeleccionarEstudiante frmEst = new frmSeleccionarEstudiante();
            frmEst.pasado += new forms.frmSeleccionarEstudiante.PasarID(capturarIDEstudiante);
            frmEst.ShowDialog();
        }

        private void btnSeleccionarInstitucion_Click(object sender, EventArgs e)
        {
            forms.frmSeleccionarInstitucion frmInst = new frmSeleccionarInstitucion();
            frmInst.pasado += new forms.frmSeleccionarInstitucion.PasarID(capturarIDInstitucion);
            frmInst.ShowDialog();
        }

        private void btnSeleccionarGrupo_Click(object sender, EventArgs e)
        {
            if (cbxTurno.SelectedIndex >= 0)
            {
                forms.frmSeleccionarGrupo frmGru = new frmSeleccionarGrupo();
                frmGru.pasado += new forms.frmSeleccionarGrupo.PasarID(capturarIDGrupo);
                frmGru.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un turno...", "ADVERTENCAIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void capturarIDEstudiante(string idEstudiante, string nombreEstudiante, string nombreApoderado)
        {
            lblIDEstudiante.Text = idEstudiante;
            txtEstudiante.Text = nombreEstudiante;
            txtApoderado.Text = nombreApoderado;
        }

        public void capturarIDInstitucion(string id, string nombre)
        {
            lblIDInstitucion.Text = id;
            txtInstitucion.Text = nombre;
        }

        public void capturarIDGrupo(String dato)
        {
            lblIDGrupo.Text = dato;
        }

        private void cbxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServicio.SelectedIndex >= 0)
            {
                if (cbxServicio.Text.Equals("Reforzamiento"))
                {
                    cbxNivel.Enabled = true;
                }
                else if (cbxServicio.Text.Equals("Pre Universitario"))
                {
                    cbxNivel.Enabled = false;
                    lblInformacionMontoTotal.Text = "";
                }

                lblIDServicio.Text = cbxServicio.SelectedValue.ToString();
            }
        }

        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNivel.SelectedIndex >= 0)
            {
                cbxTurno.Enabled = true;
                cbxTipoPago.Enabled = true;
                cargarComboGrado(cbxNivel.Text);
                // Aqui debe de hacerse el calculo automatico de los precios para el cliente
                decimal precioBase = 0;

                if (cbxNivel.Text.Equals("Primaria"))
                {
                    calcularCostoMatricula(120);
                    cbxGrado.Enabled = true;

                }
                else if (cbxNivel.Text.Equals("Secundaria"))
                {
                    calcularCostoMatricula(140);
                    cbxGrado.Enabled = true;
                }

                // Reforzamiento Pre != Pre Universitario
                else if (cbxNivel.Text.Equals("Superior"))
                {
                    precioBase = 450;
                    numMontoTotal.Value = precioBase;
                }
            }
        }

        private void calcularCostoMatricula(decimal precioBase)
        {
            DateTime fechaActual = DateTime.Now;

            int finalMes = GetLastDayOf(fechaActual).Day;
            decimal montoFinal = 0;
            string cantidad;

            // Preguntar si fue el primer dia del mes -> asignarle hasta fin de mes con precio completo
            if (fechaActual.Day == 1)
            {
                numMontoTotal.Value = precioBase;
                dateFechaFinClases.Value = GetLastDayOf(fechaActual);
                lblInformacionMontoTotal.Text = "Matricula activa para este mes, Precio Base: " + precioBase;

                // Asignar fecha fin de clases del mismo mes
                dateFechaFinClases.Value = GetLastDayOf(fechaActual);
            }

            // Regla de 3 simple dias restantes del mes y fecha fin del mismo mes
            else if (fechaActual.Day > 1 && fechaActual.Day <= 15)
            {
                // finalMes                 = precioBase
                // finalMes-fechaActual.Day = x

                montoFinal = precioBase * (finalMes - fechaActual.Day) / finalMes;

                /// Redondeo a la decena mas cercana 
                cantidad = Convert.ToInt16(montoFinal).ToString();
                cantidad = (Convert.ToInt16(cantidad.Substring(0, cantidad.Length - 1)) + 1).ToString() + "0";

                numMontoTotal.Value = Convert.ToDecimal(cantidad);
                lblInformacionMontoTotal.Text = "Matricula activa para este mes, Dias por servicio prestado: " + (finalMes - fechaActual.Day);

                // Asignar fecha fin de clases del mismo mes
                dateFechaFinClases.Value = GetLastDayOf(fechaActual);
            }

            // Regla de 3 simple dias restantes del mes + Precio del siguiente mes y fecha del fin del siguiente mes
            else if (fechaActual.Day > 15)
            {
                // finalMes                 = precioBase
                // finalMes-fechaActual.Day = x

                montoFinal = precioBase * (finalMes - fechaActual.Day) / finalMes;

                /// Redondeo a la decena mas cercana 
                cantidad = Convert.ToInt16(montoFinal).ToString();
                cantidad = (Convert.ToInt16(cantidad.Substring(0, cantidad.Length - 1)) + 1).ToString() + "0";

                numMontoTotal.Value = Convert.ToDecimal(cantidad) + precioBase;
                lblInformacionMontoTotal.Text = "Matricula activa para este mes y el siguiente, Dias por servicio prestado de este mes: " + (finalMes - fechaActual.Day);

                // Asignar fecha fin de clases del siguiente mes
                string nuevaFecha = (Convert.ToDateTime(fechaActual).Year).ToString() + "-" + (Convert.ToDateTime(fechaActual).Month + 1).ToString() + "-" + (Convert.ToDateTime(fechaActual).Day).ToString();
                dateFechaFinClases.Value = GetLastDayOf(Convert.ToDateTime(nuevaFecha));
            }
        }

        private void cbxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPago.SelectedIndex >= 0)
            {
                // Habilitar la opcion de descuento
                chxDescuento.Enabled = true;

                if (cbxTipoPago.SelectedItem.ToString().Equals("Contado"))
                {
                    lblCuotaContado.Visible = true;
                    rbtn2.Visible = false;
                    rbtn3.Visible = false;

                    mostrarControlesCuota(lblCuota1, numCuota1, dateFechaCuota1);
                    ocultarControlesCuota(lblCuota2, numCuota2, dateFechaCuota2);
                    ocultarControlesCuota(lblCuota3, numCuota3, dateFechaCuota3);

                    calcularCostoFechaCuotaUnica();
                }
                else if (cbxTipoPago.SelectedItem.ToString().Equals("Credito"))
                {
                    lblCuotaContado.Visible = false;
                    rbtn2.Visible = true;
                    rbtn3.Visible = true;

                    mostrarControlesCuota(lblCuota1, numCuota1, dateFechaCuota1);
                    mostrarControlesCuota(lblCuota2, numCuota2, dateFechaCuota2);

                    rbtn2.Checked = true;
                    calcularCostoFecha2Cuotas();
                }
                calcularInformacionSumaCuotas();
            }
        }

        private void calcularInformacionSumaCuotas()
        {
            if (cbxTipoPago.SelectedItem.ToString().Equals("Contado"))
            {
                lblSumaCuotas.Text = lblCantidadCuota1.Text.ToString();
            }
            else if (cbxTipoPago.SelectedItem.ToString().Equals("Credito"))
            {
                if (rbtn2.Checked)
                {
                    lblSumaCuotas.Text = (Convert.ToDouble(lblCantidadCuota1.Text) + Convert.ToDouble(numCuota2.Value)).ToString();
                }
                else if (rbtn3.Checked && lblCantidadCuota3.Text != "")
                {
                    lblSumaCuotas.Text = (Convert.ToDouble(lblCantidadCuota1.Text) + Convert.ToDouble(lblCantidadCuota2.Text) + Convert.ToDouble(lblCantidadCuota3.Text)).ToString();
                }
            }
        }

        private void mostrarControlesCuota(BunifuCustomLabel label, NumericUpDown numericPicker, DateTimePicker datePicker)
        {
            label.Visible = true;
            numericPicker.Visible = true;
            datePicker.Visible = true;
        }

        private void ocultarControlesCuota(BunifuCustomLabel label, NumericUpDown numericPicker, DateTimePicker datePicker)
        {
            label.Visible = false;
            numericPicker.Visible = false;
            datePicker.Visible = false;
        }

        private void calcularCostoFechaCuotaUnica()
        {
            // Preguntar cuales de las cuotas estan activas
            // Evento debe ser llamado al cambiar de opcion de nivel preguntando si el numCostoFinal tiene un value
            // Evento debe ser llamado al cambiar de opcion checkBox (cuota 2-3) preguntando si el numCostoFinal tiene un value


            if (chxDescuento.Checked == false)
            {
                numCuota1.Value = numMontoTotal.Value;
            }
            else
            {
                numCuota1.Value = numMontoTotal.Value - numDescuento.Value;
            }
            lblCantidadCuota1.Text = numCuota1.Value.ToString();
            lblCantidadCuota2.Text = "";
            lblCantidadCuota3.Text = "";
        }

        private void calcularCostoFecha2Cuotas()
        {
            // Extraer el penutltimo digito y aumentarle en +1 y el ultimo digito establecerlo en 0
            decimal monto = 0;
            int cuota1 = 0;
            string cantidad = "";

            if (chxDescuento.Checked)
            {
                monto = numMontoTotal.Value - numDescuento.Value;
            }
            else
            {
                monto = numMontoTotal.Value;
            }

            // CUOTA 1
            cuota1 = Convert.ToInt16(monto / 2);
            cantidad = cuota1.ToString();
            cantidad = (Convert.ToInt16(cantidad.Substring(0, cantidad.Length - 1)) + 1).ToString() + "0";

            numCuota1.Value = Convert.ToDecimal(cantidad);

            // CUOTA 2
            numCuota2.Value = monto - numCuota1.Value;

            // Asignar cantidades de cuotas label a CUOTA 1 y CUOTA 2
            lblCantidadCuota1.Text = numCuota1.Value.ToString();
            lblCantidadCuota2.Text = numCuota2.Value.ToString();

            lblCantidadCuota3.Text = "";

            // Asignar fecha Cuota2
            /// Primero calcular diferencia entre dias fechaFinClases e fechaInicioClases
            /// Mitad a la diferencia
            /// Sumarle la mitad obtenida en dias
            /// Aproximarlo a dia laboral mas cercano

            int diferenciaFechaInicioFin = dateFechaFinClases.Value.Day - dateFechaInicioClases.Value.Day;
            int diaAumento = Convert.ToInt16(diferenciaFechaInicioFin / 2);
            DateTime fechaCuota1 = dateFechaCuota1.Value;
            DateTime fechaCuota2 = fechaCuota1.AddDays(diaAumento);

            dateFechaCuota2.Value = fechaCuota2;

            if (fechaCuota2.ToString("dddd").Equals("domingo"))
            {
                dateFechaCuota2.Value = fechaCuota2.AddDays(1);
            }
        }

        private void calcularCostoFecha3Cuotas()
        {
            // Extraer el penutltimo digito y aumentarle en +1 y el ultimo digito establecerlo en 0
            decimal monto = 0;
            int cuota1 = 0;
            int cuota2 = 0;
            string cantidad = "";

            if (chxDescuento.Checked)
            {
                monto = numMontoTotal.Value - numDescuento.Value;
            }
            else
            {
                monto = numMontoTotal.Value;
            }

            // CUOTA 1
            cuota1 = Convert.ToInt16(monto / 3);
            cantidad = cuota1.ToString();
            cantidad = (Convert.ToInt16(cantidad.Substring(0, cantidad.Length - 1)) + 1).ToString() + "0";

            numCuota1.Value = Convert.ToDecimal(cantidad);

            // CUOTA 2
            cuota2 = Convert.ToInt16(monto - numCuota1.Value) / 2;
            cantidad = cuota2.ToString();
            cantidad = (Convert.ToInt16(cantidad.Substring(0, cantidad.Length - 1)) + 1).ToString() + "0";

            numCuota2.Value = Convert.ToDecimal(cantidad);
            numCuota3.Value = monto - numCuota1.Value - numCuota2.Value;

            // Asignar cantidades de cuotas label a CUOTA 1 , CUOTA 2 y CUOTA 3
            lblCantidadCuota1.Text = numCuota1.Value.ToString();
            lblCantidadCuota2.Text = numCuota2.Value.ToString();
            lblCantidadCuota3.Text = numCuota3.Value.ToString();

            // Asignar fecha Cuota2 y Cuota3
            /// Primero calcular diferencia entre dias fechaFinClases e fechaInicioClases
            /// Tercera parte a la diferencia
            /// Sumarle la tercera parte obtenida en dias a la Cuota2
            /// Aproximarlo a dia laboral mas cercano
            /// Sumarle la tercera parte obtenida en dias a la Cuota3
            /// Aproximarlo a dia laboral mas cercano

            int diferenciaFechaInicioFin = dateFechaFinClases.Value.Day - dateFechaInicioClases.Value.Day;
            int diaAumento = Convert.ToInt16(diferenciaFechaInicioFin / 3);
            DateTime fechaCuota1 = dateFechaCuota1.Value;
            DateTime fechaCuota2 = fechaCuota1.AddDays(diaAumento);

            dateFechaCuota2.Value = fechaCuota2;

            // Validar Cuota2 no caiga domingo
            if (fechaCuota2.ToString("dddd").Equals("domingo"))
            {
                dateFechaCuota2.Value = fechaCuota2.AddDays(1);
            }

            fechaCuota2 = dateFechaCuota2.Value;
            DateTime fechaCuota3 = fechaCuota2.AddDays(diaAumento);
            dateFechaCuota3.Value = fechaCuota3;

            // Validar Cuota3 no caiga domingo
            if (fechaCuota3.ToString("dddd").Equals("domingo"))
            {
                dateFechaCuota3.Value = fechaCuota3.AddDays(1);
            }
        }

        private void numMontoTotal_ValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoPago.Text.Equals("Contado"))
            {
                calcularCostoFechaCuotaUnica();
            }
            else if (cbxTipoPago.Text.Equals("Credito"))
            {
                if (rbtn2.Checked)
                {
                    calcularCostoFecha2Cuotas();
                }
                else
                {
                    calcularCostoFecha3Cuotas();
                }
            }
        }

        private void chxDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDescuento.Checked)
            {
                numDescuento.Enabled = true;
                numDescuento.Focus();
                lblTipoDescuento.Enabled = true;
                txtTipoDescuento.Enabled = true;
            }
            else
            {
                numDescuento.Enabled = false;
                numDescuento.Value = numDescuento.Minimum;
                lblTipoDescuento.Enabled = false;
                txtTipoDescuento.Enabled = false;
            }

            if (cbxTipoPago.Text.Equals("Contado"))
            {
                calcularCostoFechaCuotaUnica();
            }
            else
            {
                if (rbtn2.Checked)
                {
                    calcularCostoFecha2Cuotas();
                }
                else
                {
                    calcularCostoFecha3Cuotas();
                }
            }
            calcularInformacionSumaCuotas();
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            mostrarControlesCuota(lblCuota1, numCuota1, dateFechaCuota1);
            mostrarControlesCuota(lblCuota2, numCuota2, dateFechaCuota2);
            ocultarControlesCuota(lblCuota3, numCuota3, dateFechaCuota3);

            calcularCostoFecha2Cuotas();
            calcularInformacionSumaCuotas();
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            mostrarControlesCuota(lblCuota1, numCuota1, dateFechaCuota1);
            mostrarControlesCuota(lblCuota2, numCuota2, dateFechaCuota2);
            mostrarControlesCuota(lblCuota3, numCuota3, dateFechaCuota3);

            calcularCostoFecha3Cuotas();
            calcularInformacionSumaCuotas();
        }

        private void numDescuento_ValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoPago.Text.Equals("Contado"))
            {
                calcularCostoFechaCuotaUnica();
            }
            else
            {
                if (rbtn2.Checked)
                {
                    calcularCostoFecha2Cuotas();
                }
                else
                {
                    calcularCostoFecha3Cuotas();
                }
            }
            calcularInformacionSumaCuotas();
        }

        private void numCuota1_ValueChanged(object sender, EventArgs e)
        {
            if (lblCantidadCuota1.Text != "")
            {
                string montoInicial = lblCantidadCuota1.Text;
                decimal montoNuevo = numCuota1.Value;
                decimal diferenciaCuota = 0;

                if (cbxTipoPago.Text.Equals("Contado") && (montoNuevo > Convert.ToInt16(montoInicial) || montoNuevo < Convert.ToInt16(montoInicial)))
                {
                    calcularCostoFechaCuotaUnica();
                }

                else if (cbxTipoPago.Text.Equals("Credito"))
                {
                    if (rbtn2.Checked && lblCantidadCuota2.Text != "")
                    {
                        if (montoNuevo < (Convert.ToInt16(montoInicial) + Convert.ToInt16(lblCantidadCuota2.Text)))
                        {
                            // Recalcular cantidad de la Cuota2
                            diferenciaCuota = montoNuevo - Convert.ToInt16(montoInicial);

                            if (diferenciaCuota < 0)
                            {
                                numCuota2.Value = numCuota2.Value - diferenciaCuota;
                            }
                            else if (numCuota2.Value - diferenciaCuota >= numCuota2.Minimum)
                            {
                                numCuota2.Value = numCuota2.Value - diferenciaCuota;
                            }
                            else
                            {
                                calcularCostoFecha2Cuotas();
                            }
                            lblCantidadCuota1.Text = numCuota1.Value.ToString();
                            lblCantidadCuota2.Text = numCuota2.Value.ToString();
                        }
                        else if (montoNuevo == (Convert.ToInt16(montoInicial) + Convert.ToInt16(lblCantidadCuota2.Text)) || montoNuevo > (Convert.ToInt16(montoInicial) + Convert.ToInt16(lblCantidadCuota2.Text)))
                        {
                            calcularCostoFecha2Cuotas();
                        }
                    }
                    else if (rbtn3.Checked && lblCantidadCuota3.Text != "")
                    {
                        /// Validar que no sea igual al total del montoFinal
                        /// Calcular la diferencia entre montoNuevo y montoInicial
                        /// La mitad en entero a la Cuota2
                        /// Lo sobrante a la Cuota3        

                        /// Tener en una variable estatica el valor del monto total
                        /// Validar si tiene descuento y asignarle el valor a montoTotal   
                        /// No cada vez que cambie y lo sume de sus etiquetas sus cantidades                     

                        double montoTotal = Convert.ToDouble(montoInicial) + Convert.ToDouble(lblCantidadCuota2.Text) + Convert.ToInt16(lblCantidadCuota3.Text);

                        MessageBox.Show(montoTotal.ToString());


                        if (montoNuevo < Convert.ToInt16(montoTotal) - numCuota2.Minimum - numCuota3.Minimum)
                        {
                            // Recalcular cantidad de la Cuota2
                            diferenciaCuota = Convert.ToInt16((Convert.ToDouble(montoNuevo) - Convert.ToDouble(montoInicial)) / 2);

                            if (diferenciaCuota < 0)
                            {
                                numCuota2.Value = numCuota2.Value - diferenciaCuota;
                            }

                            else if (numCuota2.Value - Convert.ToDecimal((montoNuevo - Convert.ToInt16(montoInicial))) >= numCuota2.Minimum)
                            {
                                numCuota2.Value = numCuota2.Value - diferenciaCuota;
                            }

                            else if (numCuota3.Value - Convert.ToDecimal((montoNuevo - Convert.ToInt16(montoInicial) + numCuota2.Value)) >= numCuota2.Minimum)
                            {
                                numCuota3.Value = Convert.ToDecimal(montoTotal) - (numCuota1.Value + numCuota2.Value);
                            }

                            else
                            {
                                calcularCostoFecha3Cuotas();
                            }

                            lblCantidadCuota1.Text = numCuota1.Value.ToString();
                            lblCantidadCuota2.Text = numCuota2.Value.ToString();
                            lblCantidadCuota3.Text = numCuota3.Value.ToString();
                        }
                        else if (montoNuevo == Convert.ToDecimal(montoTotal) || montoNuevo > (Convert.ToInt16(montoInicial) + Convert.ToInt16(lblCantidadCuota2.Text)) + Convert.ToInt16(lblCantidadCuota3.Text) - numCuota2.Minimum - numCuota3.Value)
                        {
                            calcularCostoFecha3Cuotas();
                        }
                    }
                }
                calcularInformacionSumaCuotas();
            }
        }

        private void btnCrearMatricula_Click(object sender, EventArgs e)
        {
            /// Validar que los montos juntos si es credito sean correctos
            /// Vaidar campos obligatorios como minimo para insertar
            if (montoCorrecto())
            {
                /// Dentro del insertar Matricula
                /// Insertar las cuotas dependiendo al numero de cuotas que se le establesca
                insertarMatricula();
            }
        }

        public bool montoCorrecto()
        {
            bool valor = false;

            if (cbxTipoPago.SelectedIndex >= 0)
            {
                valor = true;
            }

            return valor;
        }

        private void insertarMatricula()
        {
            try
            {
                int montoFinal = 0;
                int descuento = 0;
                int numCuota = 0;

                SqlCommand cmd = new SqlCommand("INSERT INTO Matricula(codEstudiante, fechaMatricula, montoTotal, descuento, montoFinal, fechaInicio, fechaFin, observaciones, codServicio, cantidadCuotas, codInstitucion, tipoPago, conceptoDescuento, codGrupo, grado) VALUES(@codEst, @fechaMatricula, @montoTotal, @descuento, @montoFinal, @fechaInicio, @fechaFin, @observaciones, @codSer, @numCuota, @codIns, @tipoPago, @conceptoDescuento, @codGru, @grado); SELECT SCOPE_IDENTITY()", conex);


                cmd.Parameters.Add("@codEst", SqlDbType.Int).Value = Convert.ToInt16(lblIDEstudiante.Text);
                cmd.Parameters.Add("@fechaMatricula", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@montoTotal", SqlDbType.Money).Value = numMontoTotal.Value;

                // Preguntar si hay descuento, caso contrario montoFinal = montoTotal
                if (chxDescuento.Checked)
                {
                    montoFinal = Convert.ToInt16(numMontoTotal.Value) - Convert.ToInt16(numDescuento.Value);
                    descuento = Convert.ToInt16(numDescuento.Value);
                }

                else
                {
                    descuento = 0;
                    montoFinal = Convert.ToInt16(numMontoTotal.Value);
                }

                cmd.Parameters.Add("@descuento", SqlDbType.Money).Value = descuento;
                cmd.Parameters.Add("@montoFinal", SqlDbType.Money).Value = montoFinal;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = dateFechaInicioClases.Value;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = dateFechaFinClases.Value;
                cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar, 100).Value = info.ToTitleCase(txtObservacion.Text);
                cmd.Parameters.Add("@codSer", SqlDbType.Int).Value = Convert.ToInt16(lblIDServicio.Text);

                // Preguntar cantidad de cuotas
                if (cbxTipoPago.Text.Equals("Contado"))
                {
                    numCuota = 1;
                }
                else if (cbxTipoPago.Text.Equals("Credito"))
                {
                    if (rbtn2.Checked)
                    {
                        numCuota = 2;
                    }
                    else if (rbtn3.Checked)
                    {
                        numCuota = 3;
                    }
                }

                cmd.Parameters.Add("@numCuota", SqlDbType.Int).Value = numCuota;
                cmd.Parameters.Add("@codIns", SqlDbType.Int).Value = Convert.ToInt16(lblIDInstitucion.Text);
                cmd.Parameters.Add("@tipoPago", SqlDbType.NVarChar, 50).Value = cbxTipoPago.Text;
                cmd.Parameters.Add("@conceptoDescuento", SqlDbType.NVarChar, 50).Value = info.ToTitleCase(txtTipoDescuento.Text);
                cmd.Parameters.Add("@codGru", SqlDbType.VarChar, 3).Value = lblIDGrupo.Text;
                cmd.Parameters.Add("@grado", SqlDbType.VarChar, 3).Value = cbxGrado.Text;

                conex.Open();

                int idMat = Convert.ToInt16(cmd.ExecuteScalar());
                conex.Close();
                if (idMat > 0)
                {
                    controles_usuario.CustomDialog.ShowDialog("CREACION DE MATRICULA EXITOSA !!!");

                    // Insertar Cuotas dependiendo al numero de cu otas
                    DateTimePicker[] listaFechas = new DateTimePicker[3];
                    NumericUpDown[] listaCantidades = new NumericUpDown[3];

                    listaFechas[0] = dateFechaCuota1;
                    listaFechas[1] = dateFechaCuota2;
                    listaFechas[2] = dateFechaCuota3;

                    listaCantidades[0] = numCuota1;
                    listaCantidades[1] = numCuota2;
                    listaCantidades[2] = numCuota3;

                    insertarCuotasMatricula(idMat, numCuota, listaFechas, listaCantidades);

                    // Generar el reporte "Boleta de la matricula al cliente"
                    DialogResult boton;
                    boton = MessageBox.Show("Desea generar boleta para el cliente", "SUCCESS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (boton == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmBoletaMatricula bol = new frmBoletaMatricula();
                        bol.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la creacion de nueva Matricula ... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conex.Close();
            }
        }

        private void insertarCuotasMatricula(int idMat, int numCuota, DateTimePicker[] listaFechas, NumericUpDown[] listaCantidades)
        {
            try
            {
                for (int i = 0; i < numCuota; i++)
                {

                    SqlCommand cmd;

                    if (i == 0)
                    {
                        cmd = new SqlCommand("INSERT INTO Cuota(codMatricula, nroCuota, fechaProgramada, montoPagar, fechaPago, estado, montoPagado) VALUES(@codMat, @numCuota, @fechaProgramada, @montoPagar, @fechaPago, @estado, @montoPagado)", conex);

                        cmd.Parameters.Add("@codMat", SqlDbType.Int).Value = idMat;
                        cmd.Parameters.Add("@numCuota", SqlDbType.Int).Value = i + 1;
                        cmd.Parameters.Add("@fechaProgramada", SqlDbType.Date).Value = listaFechas[i].Value;
                        cmd.Parameters.Add("@montoPagar", SqlDbType.Money).Value = listaCantidades[i].Value;

                        // Primera cuota si o si se registra
                        cmd.Parameters.Add("@fechaPago", SqlDbType.Date).Value = listaFechas[i].Value;
                        cmd.Parameters.Add("@estado", SqlDbType.NVarChar, 50).Value = "Pagado";
                        cmd.Parameters.Add("@montoPagado", SqlDbType.Money).Value = listaCantidades[i].Value;
                    }

                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Cuota(codMatricula, nroCuota, fechaProgramada, montoPagar) VALUES(@codMat, @numCuota, @fechaProgramada, @montoPagar)", conex);

                        cmd.Parameters.Add("@codMat", SqlDbType.Int).Value = idMat;
                        cmd.Parameters.Add("@numCuota", SqlDbType.Int).Value = i + 1;
                        cmd.Parameters.Add("@fechaProgramada", SqlDbType.Date).Value = listaFechas[i].Value;
                        cmd.Parameters.Add("@montoPagar", SqlDbType.Money).Value = listaCantidades[i].Value;
                    }

                    conex.Open();

                    int resp = cmd.ExecuteNonQuery();
                    conex.Close();
                    //if (resp == 1)

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la creacion de las cuotas de la Matricula ... !" + "\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conex.Close();
            }
        }
    }
}