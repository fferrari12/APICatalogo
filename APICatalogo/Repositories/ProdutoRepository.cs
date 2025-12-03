using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
            
        }

        public PagedList<Produto> GetProdutos(ProdutosParameters produtosParam)
        {
            var produtos = GetAll().OrderBy(p => p.ProdutoId).AsQueryable();
            var produtosPaginados = PagedList<Produto>.ToPagedList(produtos, produtosParam.PageNumber, produtosParam.PageSize);
            return produtosPaginados;
        }

        public PagedList<Produto> GetProdutosFiltroPreco(ProdutosFiltroPreco produtosFiltroPreco)
        {
            var produtos = GetAll().AsQueryable();
            if (produtosFiltroPreco.Preco.HasValue && !string.IsNullOrEmpty(produtosFiltroPreco.PrecoCriterio))
            {
                if (produtosFiltroPreco.PrecoCriterio == "maior")
                {
                    produtos = produtos.Where(p => p.Preco >= produtosFiltroPreco.Preco);
                }
                else if (produtosFiltroPreco.PrecoCriterio == "menor")
                {
                    produtos = produtos.Where(p => p.Preco <= produtosFiltroPreco.Preco);
                }
                else if (produtosFiltroPreco.PrecoCriterio == "igual")
                {
                    produtos = produtos.Where(p => p.Preco == produtosFiltroPreco.Preco);
                }
            }
            var produtosPaginados = PagedList<Produto>.ToPagedList(produtos, produtosFiltroPreco.PageNumber, produtosFiltroPreco.PageSize);
            return produtosPaginados;
        }

        //public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParam)
        //{
        //    return GetAll().OrderBy(p => p.Nome)
        //                     .Skip((produtosParam.PageNumber - 1) * produtosParam.PageSize)
        //                     .Take(produtosParam.PageSize);
        //}


        public IEnumerable<Produto> GetProdutosPorCategoria(int id)
        {
            return GetAll().Where(p => p.CategoriaId == id);
        }
    }
}
