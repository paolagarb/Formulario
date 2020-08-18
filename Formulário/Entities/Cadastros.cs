using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário.Entities
{
    class Cadastros
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        public Cadastros(string nome, string usuario, string senha, string cep, string numero, string cidade, string uF, string email, string telefone1)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            UF = uF;
            Email = email;
            Telefone1 = telefone1;
        }

        public Cadastros(string nome, string usuario, string senha, string cep, string numero, string cidade, string uF, string email, string telefone1, string telefone2) : this(nome, usuario, senha, cep, numero, cidade, uF, email, telefone1)
        {
            Telefone2 = telefone2;
        }
    }
}
