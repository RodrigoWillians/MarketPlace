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
public class CategoriaController : ControllerBase
{
    private readonly CategoriaRepository _categoriaRepository;

    public CategoriaController(CategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Categoria>> GetCategorias()
    {
        var categorias = _categoriaRepository.FindAll<Categoria>();
        return Ok(categorias);
    }

    [HttpGet("{id}")]
    public ActionResult<Categoria> GetCategoria(int id)
    {
        var categoria = _categoriaRepository.FindById<Categoria>(id);

        if (categoria == null)
        {
            return NotFound();
        }

        return Ok(categoria);
    }

    [HttpPost]
    public ActionResult<Categoria> PostCategoria(Categoria categoria)
    {
        _categoriaRepository.Add(categoria);
        _categoriaRepository.Save();

        return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
    }

    [HttpPut("{id}")]
    public ActionResult PutCategoria(int id, Categoria categoria)
    {
        if (id != categoria.Id)
        {
            return BadRequest();
        }

        _categoriaRepository.Update(categoria);
        _categoriaRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCategoria(int id)
    {
        var categoria = _categoriaRepository.FindById<Categoria>(id);

        if (categoria == null)
        {
            return NotFound();
        }

        _categoriaRepository.Delete(categoria);
        _categoriaRepository.Save();

        return NoContent();
    }
}

}