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
public class ItemCarrinhoController : ControllerBase
{
    private readonly ItemCarrinhoRepository _itemCarrinhoRepository;

    public ItemCarrinhoController(ItemCarrinhoRepository itemCarrinhoRepository)
    {
        _itemCarrinhoRepository = itemCarrinhoRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ItemCarrinho>> GetItemCarrinhos()
    {
        var itemCarrinhos = _itemCarrinhoRepository.FindAll<ItemCarrinho>();
        return Ok(itemCarrinhos);
    }

    [HttpGet("{id}")]
    public ActionResult<ItemCarrinho> GetItemCarrinho(int id)
    {
        var itemCarrinho = _itemCarrinhoRepository.FindById<ItemCarrinho>(id);

        if (itemCarrinho == null)
        {
            return NotFound();
        }

        return Ok(itemCarrinho);
    }

    [HttpPost]
    public ActionResult<ItemCarrinho> PostItemCarrinho(ItemCarrinho itemCarrinho)
    {
        _itemCarrinhoRepository.Add(itemCarrinho);
        _itemCarrinhoRepository.Save();

        return CreatedAtAction(nameof(GetItemCarrinho), new { id = itemCarrinho.Id }, itemCarrinho);
    }

    [HttpPut("{id}")]
    public ActionResult PutItemCarrinho(int id, ItemCarrinho itemCarrinho)
    {
        if (id != itemCarrinho.Id)
        {
            return BadRequest();
        }

        _itemCarrinhoRepository.Update(itemCarrinho);
        _itemCarrinhoRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteItemCarrinho(int id)
    {
        var itemCarrinho = _itemCarrinhoRepository.FindById<ItemCarrinho>(id);

        if (itemCarrinho == null)
        {
            return NotFound();
        }

        _itemCarrinhoRepository.Delete(itemCarrinho);
        _itemCarrinhoRepository.Save();

        return NoContent();
    }
}

}