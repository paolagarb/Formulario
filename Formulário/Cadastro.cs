using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulário.Entities;

namespace Formulário
{



    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<Cadastros> cad = new List<Cadastros>();


            string nome = txtNome.Text;
            string usuarioC = txtUsuarioC.Text;
            string senhaC = txtSenhaC.Text;
            string cep = txtCEP.Text;
            string numero = txtNumeroCasa.Text;
            string cidade = txtCidade.Text;
            string uf = txtUF.Text;
            string email = txtEmail.Text;
            string telefone1 = txtTel1.Text;
            string telefone2 = txtTel2.Text;

            if (nome == "" || usuarioC == "" || senhaC == "" || cep == "" || numero == "" || cidade == "" || uf == "" || email == "" || telefone1 == "")
            {
                MessageBox.Show("Preencha todos os campos para finalizar o cadastro.", "Cadastro Incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //

                if (telefone2 == "")
                {
                    cad.Add(new Cadastros(nome, usuarioC, senhaC, cep, numero, cidade, uf, email, telefone1));
                }
                else
                {
                    cad.Add(new Cadastros(nome, usuarioC, senhaC, cep, numero, cidade, uf, email, telefone1, telefone2));
                }

                MessageBox.Show("Cadastro realizado com sucesso", "Usuário Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Text = "";
                txtUsuarioC.Text = "";
                txtSenhaC.Text = "";
                txtCEP.Text = "";
                txtNumeroCasa.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";
                txtEmail.Text = "";
                txtTel1.Text = "";
                txtTel2.Text = "";
            }
        }
    }
}
