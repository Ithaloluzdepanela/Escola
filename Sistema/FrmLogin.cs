using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FrmMenu menu;
        FrmLogin login;

        
        public static bool cancelar = false;
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cancelar = true;
            Close();
        }

        private void BtnLog_Click_1(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;
            if (CadastroUsuario.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso negado");
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
            }
        }
    }
}
