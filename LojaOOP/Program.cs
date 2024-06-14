namespace LojaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando categorias
            Categoria categoriaEletronicos = new Categoria("Eletrônicos", "Produtos eletrônicos diversos");
            Categoria categoriaLivros = new Categoria("Livros", "Livros de diversos gêneros");

            // Criando produtos
            Produto produto1 = new Produto("Smartphone", 1500.00m, 10, categoriaEletronicos);
            Produto produto2 = new Produto("Notebook", 3000.00m, 5, categoriaEletronicos);
            Produto produto3 = new Produto("Livro de C#", 50.00m, 20, categoriaLivros);

            // Criando loja
            Loja loja = new Loja("Minha Loja", "Rua da Loja, 123");

            // Adicionando produtos à loja
            loja.AdicionarProduto(produto1);
            loja.AdicionarProduto(produto2);
            loja.AdicionarProduto(produto3);

            // Listar produtos
            loja.ListarProdutos();

            // Ajustar estoque
            produto1.AjustarEstoque(-2);
            produto2.AjustarEstoque(3);

            // Listar produtos após ajuste
            loja.ListarProdutos();

            // Remover produto
            loja.RemoverProduto("Livro de C#");

            // Listar produtos após remoção
            loja.ListarProdutos();
        }
    }
}
