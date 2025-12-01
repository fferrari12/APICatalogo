using APICatalogo.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;
using APICatalogo.Filters;
using APICatalogo.Repositories;
using AutoMapper;
using APICatalogo.DTOs;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CategoriasController> _logger;
        private readonly IMapper _mapper;
        public CategoriasController(IConfiguration configuration, ILogger<CategoriasController> logger, IUnitOfWork uow, IMapper mapper)
        {
            _configuration = configuration;
            _logger = logger;
            _uow = uow;
            _mapper = mapper;
        }
        //teste ler arquivo de configuração
        [HttpGet("LerArqDeConfiguracao")]
        public String LerArqDeConfiguracao()
        {
            var valor = _configuration["valor1"];
            var valor2 = _configuration["valor2"];
            var secaoVal3 = _configuration["secao1:subvalor1"];
            return $"Valor1: {valor} - Valor2: {valor2} - Secao1:Subvalor1: {secaoVal3}";
        }

        //[HttpGet("Produtos")]
        //public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        //{
        //    //return _context.Categorias.Include("Produtos").ToList(); traz tudo
        //    return _context.Categorias.Include(p => p.Produtos).Where(c => c.CategoriaId <= 10).ToList();
        //}

        [HttpGet]
        [ServiceFilter(typeof(ApiLogginFilter))]
        public ActionResult<IEnumerable<CategoriaDTO>> Get()
        {
            var categorias = _uow.Categorias.GetAll();
            var categoriasDto = _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
            return Ok(categoriasDto);
        }

        [HttpGet("{id:int:min(1)}", Name = "ObterCategoria")]
        public ActionResult<CategoriaDTO> Get(int id)
        {
            var categoria = _uow.Categorias.Get(id);
            if (categoria is null)
            {
                _logger.LogWarning($"Categoria com id {id} não foi encontrada.");
                return NotFound("Categoria não encontrada ....");
            }
            var categoriaDto = _mapper.Map<CategoriaDTO>(categoria);
            return Ok(categoriaDto);
        }

        [HttpPost]
        public ActionResult<CategoriaDTO> Post(CategoriaDTO categoriaDto)
        {
            if (categoriaDto is null)
            {
                _logger.LogWarning("Objeto categoria enviado é nulo.");
                return BadRequest();
            }
            var categoria = _mapper.Map<Categoria>(categoriaDto);
            var CategoriaCriada = _uow.Categorias.Create(categoria);
            _uow.Commit();
            var categoriaDtoCriada = _mapper.Map<CategoriaDTO>(CategoriaCriada);
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoriaDtoCriada.CategoriaId }, categoriaDtoCriada);
        }

        [HttpPut("{id:int}")]
        public ActionResult<CategoriaDTO> Put(int id, CategoriaDTO categoriaDto)
        {
            if(id != categoriaDto.CategoriaId)
            {
                _logger.LogWarning("O id informado na URL é diferente do id do objeto enviado.");
                return BadRequest();
            }
            var categoria = _mapper.Map<Categoria>(categoriaDto);
            _uow.Categorias.Update(categoria);
            _uow.Commit();
            var categoriaDtoAtualizada = _mapper.Map<CategoriaDTO>(categoria);
            return Ok(categoriaDtoAtualizada);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<CategoriaDTO> Delete(int id)
        {
            var CategDeletada = _uow.Categorias.Get(id);
            if (CategDeletada is null)
            {
                _logger.LogWarning($"Categoria com id {id} não foi encontrada para exclusão.");
                return NotFound("Categoria não encontrada ....");
            }
            _uow.Categorias.Delete(CategDeletada);
            _uow.Commit();
            var categoriaDtoDeletada = _mapper.Map<CategoriaDTO>(CategDeletada);
            return Ok(categoriaDtoDeletada);
        }
    }
}
