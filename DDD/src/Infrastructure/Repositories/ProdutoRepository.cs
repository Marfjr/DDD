using DDD.src.Domain;
using DDD.src.Infrastructure.Repositories.Interfaces;

namespace DDD.src.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //Lista de produtos fake para simular o banco de dados
        private List<Produto> _produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto 1", Preco = 10 },
            new Produto { Id = 2, Nome = "Produto 2", Preco = 20 },
            new Produto { Id = 3, Nome = "Produto 3", Preco = 30 },
            new Produto { Id = 4, Nome = "Produto 4", Preco = 40 },
            new Produto { Id = 5, Nome = "Produto 5", Preco = 50 }
        };

        public Produto ObterProdutoPorId(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id);
            //Lógica de acesso ao banco de dados
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _produtos;
        }
    }
}
