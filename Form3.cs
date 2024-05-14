using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static datosPersonales.frmLogin;

namespace datosPersonales
{
    public partial class frmAdmin : Form
    {
        private DatosPersonales datosUsuario;

        public frmAdmin(DatosPersonales datosUsuario)
        {
            InitializeComponent();
            this.datosUsuario = datosUsuario;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido " + datosUsuario.Nombre + " " + datosUsuario.Apellido;        }
    }
}
