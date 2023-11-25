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
public class CarrinhoController : ControllerBase
{
    private readonly CarrinhoRepository _carrinhoRepository;

    public CarrinhoController(CarrinhoRepository carrinhoRepository)
    {
        _carrinhoRepository = carrinhoRepository;
    }

    // GET: api/Carrinho
    [HttpGet]
    public ActionResult<IEnumerable<Carrinho>> GetCarrinhos()
    {
        var carrinhos = _carrinhoRepository.FindAll<Carrinho>();
        return Ok(carrinhos);
    }

    // GET: api/Carrinho/1
    [HttpGet("{id}")]
    public ActionResult<Carrinho> GetCarrinho(int id)
    {
        var carrinho = _carrinhoRepository.FindById<Carrinho>(id);

        if (carrinho == null)
        {
            return NotFound();
        }

        return Ok(carrinho);
    }

    // POST: api/Carrinho
    [HttpPost]
    public ActionResult<Carrinho> PostCarrinho(Carrinho carrinho)
    {
        _carrinhoRepository.Add(carrinho);
        _carrinhoRepository.Save();

        return CreatedAtAction(nameof(GetCarrinho), new { id = carrinho.Id }, carrinho);
    }

    // PUT: api/Carrinho/1
    [HttpPut("{id}")]
    public ActionResult PutCarrinho(int id, Carrinho carrinho)
    {
        if (id != carrinho.Id)
        {
            return BadRequest();
        }

        _carrinhoRepository.Update(carrinho);
        _carrinhoRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCarrinho(int id)
    {
        var carrinho = _carrinhoRepository.FindById<Carrinho>(id);

        if (carrinho == null)
        {
            return NotFound();
        }

        _carrinhoRepository.Delete(carrinho);
        _carrinhoRepository.Save();

        return NoContent();
}
}
}
