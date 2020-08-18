using Formulário.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário
{
   
    public partial class Form1 : Form
    {
        string confirmarUsuario, confirmarSenha;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string usuario, string senha) : this()
        {
            confirmarUsuario = usuario;
            confirmarSenha = senha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

           if (usuario == confirmarUsuario && senha == confirmarSenha)
            {
                MessageBox.Show("Login realizado com sucesso!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Dados incorretos.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Visible = false;
        }
    }
}
