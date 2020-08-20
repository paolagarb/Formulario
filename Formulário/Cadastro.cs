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
using System.Data.Sql;
using System.Data.SqlClient;

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

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LBQF810B;Initial Catalog=Formulario;Integrated Security=True");


            List<Cadastros> cad = new List<Cadastros>();
            string sql;
            Random Id = new Random(1);
            Id.Next();

            

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
                

                if (telefone2 == "")
                {
                    cad.Add(new Cadastros(nome, usuarioC, senhaC, cep, numero, cidade, uf, email, telefone1));

                    sql = "INSERT INTO Usuario(IDUser, Nome, Usuario, Senha, CEP, NumeroCasa, Cidade, UF, Email, Telefone1) " +
                    "VALUES(@IDUser, @Nome, @Usuario, @Senha, @CEP, @NumeroCasa, @Cidade, @UF, @Email, @Telefone1)";
                    SqlCommand sc = new SqlCommand(sql, connection);
                    sc.Parameters.Add(new SqlParameter("@IDUser", Id.Next()));
                    sc.Parameters.Add(new SqlParameter("@Nome", nome));
                    sc.Parameters.Add(new SqlParameter("@Usuario", usuarioC));
                    sc.Parameters.Add(new SqlParameter("@Senha", senhaC));
                    sc.Parameters.Add(new SqlParameter("@CEP", cep));
                    sc.Parameters.Add(new SqlParameter("@NumeroCasa", numero));
                    sc.Parameters.Add(new SqlParameter("@Cidade", cidade));
                    sc.Parameters.Add(new SqlParameter("@UF", uf));
                    sc.Parameters.Add(new SqlParameter("@Email", email));
                    sc.Parameters.Add(new SqlParameter("@Telefone1", telefone1));
                    connection.Open();
                    sc.BeginExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                    cad.Add(new Cadastros(nome, usuarioC, senhaC, cep, numero, cidade, uf, email, telefone1, telefone2));
                    sql = "INSERT INTO Usuario(IDUser, Nome, Usuario, Senha, CEP, NumeroCasa, Cidade, UF, Email, Telefone1, Telefone2) " +
                     "VALUES(@IDUser, @nome, @Usuario, @Senha, @CEP, @NumeroCasa, @Cidade, @UF, @Email, @Telefone1, @Telefone2)";

                    SqlCommand sc = new SqlCommand(sql, connection);
                    sc.Parameters.Add(new SqlParameter("@IDUser", Id.Next()));
                    sc.Parameters.Add(new SqlParameter("@Nome", nome));
                    sc.Parameters.Add(new SqlParameter("@Usuario", usuarioC));
                    sc.Parameters.Add(new SqlParameter("@Senha", senhaC));
                    sc.Parameters.Add(new SqlParameter("@CEP", cep));
                    sc.Parameters.Add(new SqlParameter("@NumeroCasa", numero));
                    sc.Parameters.Add(new SqlParameter("@Cidade", cidade));
                    sc.Parameters.Add(new SqlParameter("@UF", uf));
                    sc.Parameters.Add(new SqlParameter("@Email", email));
                    sc.Parameters.Add(new SqlParameter("@Telefone1", telefone1));
                    sc.Parameters.Add(new SqlParameter("@Telefone2", telefone2));
                    connection.Open();
                    sc.BeginExecuteNonQuery();
                    connection.Close();
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
