using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOOP
{
    internal class Categoria
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; private set; }

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto '{produto.Nome}' adicionado à categoria '{Nome}'.");
        }
    }
}
