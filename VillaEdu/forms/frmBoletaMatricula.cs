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
    public partial class frmBoletaMatricula : Form
    {
        public frmBoletaMatricula()
        {
            InitializeComponent();
        }

        private void frmBoletaMatricula_Load(object sender, EventArgs e)
        {
            this.rvBoletaMatricula.RefreshReport();            
        }
    }
}
