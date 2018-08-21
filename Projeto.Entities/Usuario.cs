using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Permissao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        public Usuario()
        {

        }

        public Usuario(int idUsuario, string nome, string email, string permissao, string login, string senha)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            Permissao = permissao;
            Login = login;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"Id: {IdUsuario}, Nome: {Nome}, E-mail: {Email}, Permissão: {Permissao},Login: {Login}, Senha: {Senha}";
        }
    }

    
}
