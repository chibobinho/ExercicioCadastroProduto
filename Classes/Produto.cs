using System;
using System.Collections.Generic;

namespace Projeto_de_produtos.Classes
{
    public class Produto
    {
        private int codigo { get; set; }
        public int Codigo
        {
            get { return Codigo; }
            set { codigo = value; }
        }
        private string nomeProduto { get; set; }
        public string NomeProduto
        {
            get { return NomeProduto; }
            set { nomeProduto = value; }
        }
        private float preco { get; set; }
        public float Preco
        {
            get { return Preco; }
            set { preco = value; }
        }
        private DateTime dataCadastro { get; set; }
        public DateTime DataCadastro
        {
            get { return DataCadastro; }
            set { dataCadastro = value; }
        }
        private string marca { get; set; }
        public string Marca
        {
            get { return Marca; }
            set { marca = value; }
        }
        private string cadastradoPor { get; set; }
        public string CadastradoPor
        {
            get { return CadastradoPor; }
            set { cadastradoPor = value; }
        }
        private List<Produto> listaDeProduto { get; set; }
        public List<Produto> ListaDeProduto
        {
            get { return ListaDeProduto; }
            set { listaDeProduto = value; }
        }

        public void CadastrarProduto()
        {
            Console.WriteLine("Digite seu código:");
            this.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do produto:");
            this.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            this.Preco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a marca do produto:");
            this.Marca = Console.ReadLine();
            Console.WriteLine("Digite quem está cadastrando o produto:");
            this.CadastradoPor = Console.ReadLine();
            Console.WriteLine("Hora de registro");
            Console.WriteLine(DateTime.Now);
            List<Produto> ListaDeProduto = new List<Produto>();
        }

        public void ListarProduto(Produto produto)
        {
           ListaDeProduto.Add(produto);
        }
        public void DeletarProduto(Produto produto)
        {
           ListaDeProduto.Remove(produto);
        }

        public List<Produto> ListarProduto()
        {
            return ListaDeProduto;
        }
        //     public Produto(int _codigo, string _nomeProduto, float _preco, int _dataCadastro, string _marca, string _cadastradoPor)
        //     {
        //         this.Codigo = _codigo;
        //         this.NomeProduto = _nomeProduto;
        //         this.Preco = _preco;
        //         this.DataCadastro = _dataCadastro;
        //         this.Marca = _marca;
        //         this.CadastradoPor = _cadastradoPor;
        //     }
        // }
    }
}
