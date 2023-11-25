using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketPlace.Repository;
using MarketPlace.Model;

namespace MarketPlace.Controllers
{


[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly ProdutoRepository _produtoRepository;

    public ProdutoController(ProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetProdutos()
    {
        var produtos = _produtoRepository.FindAll<Produto>();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> GetProduto(int id)
    {
        var produto = _produtoRepository.FindById<Produto>(id);

        if (produto == null)
        {
            return NotFound();
        }

        return Ok(produto);
    }

    [HttpPost]
    public ActionResult<Produto> PostProduto(Produto produto)
    {
        _produtoRepository.Add(produto);
        _produtoRepository.Save();

        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public ActionResult PutProduto(int id, Produto produto)
    {
        if (id != produto.Id)
        {
            return BadRequest();
        }

        _produtoRepository.Update(produto);
        _produtoRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduto(int id)
    {
        var produto = _produtoRepository.FindById<Produto>(id);

        if (produto == null)
        {
            return NotFound();
        }

        _produtoRepository.Delete(produto);
        _produtoRepository.Save();

        return NoContent();
    }
}

}