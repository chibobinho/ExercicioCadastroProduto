using System;
using System.Collections.Generic;
using Projeto_de_produtos.Classes;

namespace Projeto_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string desejo, opcao;
            Marca m = new Marca();
            List<Marca> ma = new List<Marca>();
            Login l = new Login();
            Usuario u = new Usuario();
            Produto p = new Produto();

            Console.WriteLine("Você quer logar? (S/N)");
            desejo = Console.ReadLine().ToLower();
            while (l.Logado == false)
            {
                if (desejo == "s")
                {
                    l.Logar();
                }
                else if (desejo == "n")
                {
                    l.Logado = true;
                    Console.WriteLine("Quer ir embora mesmo? Digite 0");
                }

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        u.CadastrarUsuario();
                        break;
                    case "2":
                        m.CadastrarMarca();
                        break;
                    case "3":
                        p.CadastrarProduto();
                        break;
                    case "4":
                        m.ListarMarca();
                        break;
                    case "5":
                        p.ListarProduto();
                        break;
                    case "6":
                        break;
                    case "7":
                        p.DeletarProduto(); 
                        break;
                    case "0":
                        l.Deslogar();
                        break;
                }
            }
        }

        // Console.WriteLine(m.CadastrarMarca());

        //             List<Marca> marcas = new List<Marca>();

        //             // Cadastrar
        //             marcas.Add(new Marca(123, "Nike", 2020));
        //             marcas.Add(new Marca(456, "Adidas", 2009));
        //             marcas.Add(new Marca(789, "Puma", 2010));

        //             // Remover
        //             marcas.RemoveAt(0);

        //             // Listar
        //             foreach (Marca m in marcas)
        //             {
        //                 Console.WriteLine($"{m.Codigo} - {m.NomeMarca} - {m.DataCadastro}");
        //             }

        //             List<Produto> produtos = new List<Produto>();

        //             // Cadastrar
        //             produtos.Add(new Produto(111, "bbb", 30, 2020, "Gamdias", "Qualquer"));
        //             produtos.Add(new Produto(222, "ccc", 20, 2010, "Redragon", "Qualquer dois"));

        //             // Remover
        //             produtos.RemoveAt(0);

        //             // Listar
        //             foreach (Produto p in produtos)
        //             {
        //                 Console.WriteLine($"{p.Codigo} - {p.NomeProduto} - {p.Preco} - {p.DataCadastro} - {p.Marca} - {p.CadastradoPor}");
        //             }

        //             // Cadastrar
        //             Usuario u = new Usuario(333, "aaa", "@gmail", "blabla", 2020);

        //             // Mostrar usuario
        //             Console.WriteLine($@"
        // Seu código é: {u.Codigo}
        // Seu nome é: {u.Nome}
        // Seu email é: {u.Email}
        // Sua senha é: {u.Senha}
        // Sua data de cadastro é: {u.DataCadastro}

        // Guarde essas informações!
        // ");

        //             // Remover

        //         }
        //     }
    }
}

