using DDD.src.Domain;

namespace DDD.src.Infrastructure.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Produto ObterProdutoPorId(int id);
        List<Produto> ObterTodosProdutos();
    }
}
