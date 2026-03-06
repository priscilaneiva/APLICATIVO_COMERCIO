using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Priscila";
            string senha = "123";

            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                MessageBox.Show("Logado com sucesso!");
                frmMenu fM = new frmMenu();
                fM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novament!");
            }
        }
    }
}
