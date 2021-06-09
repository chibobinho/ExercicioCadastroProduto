using System;
using System.Collections.Generic;

namespace Projeto_de_produtos.Classes
{
    public class Marca
    {
        private int codigo { get; set; }
        public int Codigo
        {
            get { return Codigo; }
            set { codigo = value; }
        }
        private string nomeMarca { get; set; }
        public string NomeMarca
        {
            get { return NomeMarca; }
            set { nomeMarca = value; }
        }

        private DateTime dataCadastro { get; set; }
        public DateTime DataCadastro
        {
            get { return DataCadastro; }
            set { dataCadastro = value; }
        }

        public string CadastrarMarca()
        {
            Console.WriteLine("Digite seu código:");
            this.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da marca:");
            this.NomeMarca = Console.ReadLine();
            Console.WriteLine("Hora de registro:");
            Console.WriteLine(DateTime.Now);
            return "A marca foi cadastrada";
        }

        public void ListarMarca()
        {
            List<Marca> marcas = new List<Marca>();

            foreach (Marca m in marcas)
            {
                Console.WriteLine($"{m.Codigo} - {m.NomeMarca} - {m.DataCadastro}");
            }
            // ListarMarca.Add(Marca);
        }

        public void DeletarMarca()
        {

        }

        // public Marca(int _codigo, string _nomeMarca, DateTime _dataCadastro)
        // {
        //     this.Codigo = _codigo;
        //     this.NomeMarca = _nomeMarca;
        //     this.DataCadastro = _dataCadastro;
        // }
    }
}