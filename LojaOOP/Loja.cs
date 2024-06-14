using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOOP
{
    internal class Loja
    {
        public string Nome {  get; set; }
        public string Endereco { get; set; }
        public List<Produto> Produtos { get; private set; }

        public Loja(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto '{produto.Nome}' adicionado à loja '{Nome}'.");
        }

        public void RemoverProduto(string nomeProduto)
        {
            var produto = Produtos.Find(p => p.Nome == nomeProduto);
            if (produto != null)
            {
                Produtos.Remove(produto);
                Console.WriteLine($"Produto '{nomeProduto}' removido da loja '{Nome}'.");
            }
            else
            {
                Console.WriteLine($"Produto '{nomeProduto}' não encontrado na loja '{Nome}'.");
            }
        }

        public void ListarProdutos()
        {
            Console.WriteLine($"Produtos na loja '{Nome}':");
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"- {produto.Nome}, Preço: R${produto.Preco}, Estoque: {produto.QtdEstoque}");
            }
        }
    }
}
