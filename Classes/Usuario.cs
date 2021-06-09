using System;
namespace Projeto_de_produtos.Classes
{
    public class Usuario
    {
        private int codigo { get; set; }
        public int Codigo
        {
            get { return Codigo; }
            set { codigo = value; }
        }

        private string nome { get; set; }
        public string Nome
        {
            get { return Nome; }
            set { nome = value; }
        }

        private string email { get; set; }
        public string Email
        {
            get { return Email; }
            set { email = value; }
        }

        private string senha { get; set; }
        public string Senha
        {
            get { return Senha; }
            set { senha = value; }
        }

        private DateTime dataCadastro { get; set; }
        public DateTime DataCadastro
        {
            get { return DataCadastro; }
            set { dataCadastro = value; }
        }

        public void CadastrarUsuario()
        {
            Console.WriteLine("Digite seu código:");
            this.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu email:");
            this.Email = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            this.Senha = Console.ReadLine();
            Console.WriteLine("Hora de registro:");
            Console.WriteLine(DateTime.Now);
        }

        public void DeletarUsuario()
        {

        }
        // public Usuario(int _codigo, string _nome, string _email, string _senha, int _dataCadastro)
        // {
        //     this.Codigo = _codigo;
        //     this.Nome = _nome;
        //     this.Email = _email;
        //     this.Senha = _senha;
        //     this.DataCadastro = _dataCadastro;
        // }
    }
}