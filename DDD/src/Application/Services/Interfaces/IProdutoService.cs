using DDD.src.Domain;

namespace DDD.src.Application.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto ObterProdutoPorId(int id);
        List<Produto> ObterTodosProdutos();
    }
}
