using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio02_DAEA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            string[] data = new string[2] { txtUsuario.ToString(), txtPassword.ToString() };
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            string x = "miguel";
            string usuario = txtUsuario.ToString();
            bool equal = String.Equals(x, usuario);
            Console.WriteLine(equal);
            if (equal)
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales erroneas");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
