using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaEdu.controles_usuario
{
    public partial class CustomDialog : Form
    {
        public CustomDialog(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            IconDelay.Start();
            icon.Enabled = true;
        }

        private void IconDelay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            IconDelay.Stop();

            bunifuTransition1.ShowSync(btnOk);
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowDialog(string mensaje)
        {
            CustomDialog cd = new CustomDialog(mensaje);
            cd.ShowDialog();            
        }
    }
}
