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
using System.Data.SqlClient;

namespace Formulário
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Login();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Visible = false;
        }

        public void Login()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            int i = 0;
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LBQF810B;Initial Catalog=Formulario;Integrated Security=True");

            string sql = "SELECT COUNT(Usuario) FROM Usuario WHERE Usuario = @usuario AND Senha = @senha";
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

            connection.Open();

            i = (int)cmd.ExecuteScalar();
            
            if(i == 1)
            {
                MessageBox.Show("Login realizado com sucesso!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dados incorretos.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              




        connection.Close();
        }
    }
}
