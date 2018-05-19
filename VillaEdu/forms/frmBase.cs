using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaEdu.forms
{
    public partial class frmBase : Form 
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            posicionInicialMenu();
        }

        private void posicionInicialMenu()
        {
            btnInicio.Location = new Point(22, 155);
            btnEstudiante.Location = new Point(22, 203);
            btnDocente.Location = new Point(22, 256);
            btnGrupo.Location = new Point(22, 309);
            btnServicio.Location = new Point(22, 362);
            btnPago.Location = new Point(22, 415);
            btnCalendario.Location = new Point(22, 468);
            btnReporte.Location = new Point(22, 521);
            btnUsuario.Location = new Point(22, 574);

            ocultarTodosSubMenus();
        }

        private void ocultarTodosSubMenus()
        {
            panSMGrupo.Hide();
            panSMServicio.Hide();
            panSMPago.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult boton;

            boton = MessageBox.Show("Esta seguro que desea salir del sistema ... ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (boton == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMiximixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            if (panMenuSlider.Width == 240)
            {
                // Menu Slider
                bunAnimLogo.HideSync(pbxLogoMenuSlider);
                panMenuSlider.Visible = false;
                panMenuSlider.Width = 77;
                bunAnimSlider.ShowSync(panMenuSlider);

                // Ocultar el logo grande y mostrar el logo pequeño
                bunAnimLogo.HideSync(pbxLogoMenuSlider);
                bunAnimLogo.ShowSync(pbxLogo);
            }
            else
            {
                // Menu slider
                panMenuSlider.Visible = false;
                panMenuSlider.Width = 240;
                bunAnimSlider.ShowSync(panMenuSlider);
                bunAnimLogo.ShowSync(pbxLogoMenuSlider);

                // Ocultar el logo pequeño y mostrar el logo grande
                bunAnimLogo.HideSync(pbxLogo);
                bunAnimLogo.ShowSync(pbxLogoMenuSlider);
            }
        }

        // Metodo para abrir un control de usuario
        private void abrirUC(UserControl uc)
        {
            if (this.panContenedor.Controls.Count > 0)
            {
                this.panContenedor.Controls.Clear();
            }

            uc.Dock = DockStyle.Fill;
            this.panContenedor.Controls.Add(uc);
            this.panContenedor.Tag = uc;
            uc.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            controles_usuario.CustomDialog.ShowDialog("CONEXION A LA BASE DE DATOS EXITOSA !!!");

            posicionInicialMenu();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            abrirUC(new controles_usuario.cuEstudiante());

            posicionInicialMenu();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            abrirUC(new controles_usuario.cuDocente());

            posicionInicialMenu();
        }

        /// Sub-Menu debe quedar seleccionada la opcion del Sub-Menu        
        private void btnGrupo_Click(object sender, EventArgs e)
        {
            /// Mostrar SubMenu
            /// No se muestra ningun control de usuario

            if (panSMGrupo.Visible == false)
            {
                /// Mostrar SMGrupo y ubicamos
                panSMGrupo.Visible = true;                
                panSMGrupo.Location = new Point(22, 357);

                /// Ocultar otros SubMenus (SERVICIO, PAGO)
                panSMServicio.Visible = false;
                panSMPago.Visible = false;

                /// Mover los botones debajo de la opcion Grupos
                btnServicio.Location = new Point(22, 433);
                btnPago.Location = new Point(22, 486);
                btnCalendario.Location = new Point(22, 539);
                btnReporte.Location = new Point(22, 592);
                btnUsuario.Location = new Point(22, 645);
            }

            else
            {
                posicionInicialMenu();
            }
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            /// Mostrar SubMenu
            /// No se muestra ningun control de usuario

            if (panSMServicio.Visible == false)
            {
                /// Ubicar opcion Servicio
                btnServicio.Location = new Point(22, 362);

                /// Mostrar SMServicio y ubicamos
                panSMServicio.Visible = true;
                panSMServicio.Location = new Point(22, 410);

                /// Ocultar otros SubMenus (GRUPO, PAGO)
                panSMGrupo.Visible = false;
                panSMPago.Visible = false;

                /// SBgrupo mover hacia arriba
                btnGrupo.Location = new Point(22, 309);

                /// Mover los botones debajo de la opcion Grupos                
                btnPago.Location = new Point(22, 486);
                btnCalendario.Location = new Point(22, 539);
                btnReporte.Location = new Point(22, 592);
                btnUsuario.Location = new Point(22, 645);
            }

            else
            {
                //btnServicio.Location = new Point(22, 294);
                //btnPago.Location = new Point(22, 347);
                //btnReporte.Location = new Point(22, 400);
                //btnUsuario.Location = new Point(22, 453);

                posicionInicialMenu();
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            /// Mostrar SubMenu
            /// No se muestra ningun control de usuario

            if (panSMPago.Visible == false)
            {
                /// Ubicar opcion Pago                
                btnPago.Location = new Point(22, 415);

                /// Mostrar SMPago y ubicamos
                panSMPago.Visible = true;
                panSMPago.Location = new Point(22, 463);

                /// Ocultar otros SubMenus (GRUPO, SERVICIO)
                panSMGrupo.Visible = false;
                panSMServicio.Visible = false;

                /// SBgrupo mover hacia arriba
                btnGrupo.Location = new Point(22, 309);
                btnServicio.Location = new Point(22, 362);

                /// Mover los botones debajo de la opcion Grupos                                
                btnCalendario.Location = new Point(22, 539);
                btnReporte.Location = new Point(22, 592);
                btnUsuario.Location = new Point(22, 645);
            }

            else
            {
                //btnPago.Location = new Point(22, 347);
                //btnReporte.Location = new Point(22, 400);
                //btnUsuario.Location = new Point(22, 453);

                posicionInicialMenu();
            }
        }

        /// Sub-Menus Grupos
        
        /// Sub-Menus Servicios
        private void btnSMMatricula_Click(object sender, EventArgs e)
        {
            abrirUC(new controles_usuario.cuMatricula());
        }

        /// Sub-Menus Pagos
        private void btnSMPagoCuotaMatricula_Click(object sender, EventArgs e)
        {
            abrirUC(new controles_usuario.cuCuotaMatricula());
        }        
    }
}