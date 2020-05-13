using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSoft.CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string nick = textNick.Text.Trim();
            string password = textPassword.Text.Trim();


        }
    }
}
