using APICatalogo.Context;
using APICatalogo.DTOs;
using APICatalogo.Models;
using APICatalogo.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ProdutosController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet("produtos/{id}")]
        public ActionResult<IEnumerable<ProdutoDTO>> GetProdutosCategoria(int id)
        {
            var produtos = _uow.Produtos.GetProdutosPorCategoria(id).ToList();
            if (produtos is null || produtos.Count == 0)
            {
                return NotFound("Produto não encontrado........");
            }
            var produtosDto = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
            return Ok (produtosDto);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProdutoDTO>> Get()
        {
            var produtos = _uow.Produtos.GetAll().ToList();
            if (produtos is null || produtos.Count == 0)
            {
                return NotFound("Produto não encontrado........");
            }
            var produtosDto = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
            return Ok(produtosDto);
        }   
        [HttpGet("{id:int:min(1)}",Name ="ObterProduto")]
        public ActionResult<ProdutoDTO> Get(int id)
        {
            var produto = _uow.Produtos.Get(id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado ....");
            }
            var produtoDto = _mapper.Map<ProdutoDTO>(produto);
            return Ok(produtoDto);
        }
        [HttpPost]
        public ActionResult<ProdutoDTO> Post(ProdutoDTO produtoDto)
        {
            if(produtoDto is null)
            {
                return BadRequest();
            }
            var produto = _mapper.Map<Produto>(produtoDto);
            var novoProduto = _uow.Produtos.Create(produto);
            _uow.Commit();
            var produtoDTO = _mapper.Map<ProdutoDTO>(novoProduto);
            return new CreatedAtRouteResult("ObterProduto", new { id = produtoDTO.ProdutoId }, produtoDTO);
        }
        [HttpPut("{id:int}")]
        public ActionResult<ProdutoDTO> Put(int id, ProdutoDTO produtoDto)
        {
            if(id != produtoDto.ProdutoId)
            {
                return BadRequest();
            }
            var produto = _mapper.Map<Produto>(produtoDto);
            var produtoAtualizado = _uow.Produtos.Update(produto);
            if (produtoAtualizado is null)
            {
                return StatusCode(500, "Atualização não realizada ....");
            }
            _uow.Commit();
            var produtoAtualizadoDto = _mapper.Map<ProdutoDTO>(produtoAtualizado);
            return Ok(produtoAtualizadoDto);
        }
        [HttpDelete("{id:int}")]
        public ActionResult<ProdutoDTO> Delete(int id)
        {
            var produto = _uow.Produtos.Get(id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado ....");
            }
            _uow.Produtos.Delete(produto);
            _uow.Commit();

            var produtoDto = _mapper.Map<ProdutoDTO>(produto);

            //return Ok($"Produto de id {id} excluido");
            return Ok(produtoDto);
        }
    }
}
