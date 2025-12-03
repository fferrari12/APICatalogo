using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        {
            
        }

        public PagedList<Categoria> GetCategorias(CategoriasParameters categoriasParam)
        {
            var categorias = GetAll().OrderBy(p=>p.CategoriaId).AsQueryable();
            var categoriasPaginadas = PagedList<Categoria>.ToPagedList(categorias, categoriasParam.PageNumber, categoriasParam.PageSize);
            return categoriasPaginadas;
        }

        public PagedList<Categoria> GetCategoriasPorNome(CategoriasFiltroNome categoriasFiltro)
        {
            var categorias = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(categoriasFiltro.Nome))
            {
                categorias = categorias.Where(c => c.Nome!.Contains(categoriasFiltro.Nome));
            }
            var categoriasPaginadas = PagedList<Categoria>.ToPagedList(categorias, categoriasFiltro.PageNumber, categoriasFiltro.PageSize);
            return categoriasPaginadas;
        }
    }
}
