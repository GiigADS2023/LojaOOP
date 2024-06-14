using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOOP
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; private set; }
        public Categoria Categoria { get; set; }

        public Produto(string nome, decimal preco, int qtdestoque, Categoria categoria)
        {
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdestoque;
            Categoria = categoria;
            categoria.AdicionarProduto(this);
        }

        public void AjustarEstoque(int quantidade)
        {
            if (QtdEstoque + quantidade >= 0)
            {
                QtdEstoque += quantidade;
                Console.WriteLine($"Estoque do produto '{Nome}' ajustado para {QtdEstoque} unidades.");
            }
            else
            {
                Console.WriteLine($"Operação inválida. Quantidade em estoque não pode ser negativa.");
            }
        }
    }
}
