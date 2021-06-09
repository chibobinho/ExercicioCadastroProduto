using System;
namespace Projeto_de_produtos.Classes
{
    public class Login
    {
        private bool logado = false;
        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }
        public void Loginn()
        {

        }

        public void Logar()
        {
            Logado = false;
            Console.WriteLine($@"
_________________________
| 1 - Cadastrar usuario 
| 2 - Cadastrar marca   
| 3 - Cadastrar Produto 
| 4 - Listar marcas     
| 5 - Listar Produtos   
| 6 - Deletar marca     
| 7 - Deletar produto   
| 8 - Deletar usuario   
| 0 - Deslogar          
");
        }

        public void Deslogar()
        {
            Logado = true;
            Console.WriteLine("certo, flw ae");
        }
        // public Login(string _usuario)
        // {
        //     this.Usuario = _usuario;
        // }
    }
}