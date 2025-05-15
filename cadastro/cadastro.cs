using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace cadastro
{
    public partial class cadastro : Form
    {
        List<usuarios> cliente;
        public cadastro()
        {
            InitializeComponent();
           //Puxa Lista
            cliente = new List<usuarios>();
        }
        private void listar()
        {
            //Puxar a lista
            list.Items.Clear();
            foreach(usuarios p in cliente)
            {
                list.Items.Add($"{p.nome}|{p.cpf}|{p.dataNasc}");
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            //Variáveis usadas
            int index = -1;
            char sexo;

            //Testando se os campos estão selecionados
            foreach (usuarios p in cliente)
            {
                if (p.nome == txtNome.Text)
                {
                    index = cliente.IndexOf(p);
                }
            } if(txtNome.Name == "")
            {
                MessageBox.Show("Preencha o campo nome");
                txtNome.Focus();
                return;
            }
            if(txtData.Text == "")
            {
                MessageBox.Show("Preencha o campo Data de nascimento");
                txtData.Focus();
                return;
            }
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF");
                txtCpf.Focus();
                return;
            }
            //Verificando Sexo
            if (radioM.Checked)
            {
                sexo = 'M';
            }
            if (radioF.Checked)
            {
                sexo = 'F';
            }
            if (radioOu.Checked)
            {
                sexo = 'O';
            }

            //Adicionando os termos as classes
            usuarios u = new usuarios();
            u.nome = txtNome.Text;
            u.endereco = txtEnd.Text;
            u.dataNasc = txtData.Text;
            u.cpf = txtCpf.Text;
            u.ec = comboEc.SelectedIndex.ToString();
            u.plano = checkSim.Checked;

            if (index < 0)
            {
                cliente.Add(u);
            }
            else
            {
                cliente[index] = u;
            }
            listar();
            txtNome.Text = "";
            txtEnd.Text = "";
            txtData.Text = "";
            txtCpf.Text = "";
            comboEc.SelectedItem = 0;
            checkSim.Checked = false;
            radioM.Checked = false;
            radioF.Checked = false;
            radioOu.Checked = false;
            txtNome.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtData.Text = "";
            txtCpf.Text = "";
            comboEc.SelectedItem = 0;
            checkSim.Checked = false;
            radioM.Checked = false;
            radioF.Checked = false;
            radioOu.Checked = false;
            txtNome.Focus();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            int indice = list.SelectedIndex;
            cliente.RemoveAt(indice);
            listar();
        }
    }
}
