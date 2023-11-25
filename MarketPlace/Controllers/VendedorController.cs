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
public class VendedorController : ControllerBase
{
    private readonly VendedorRepository _vendedorRepository;

    public VendedorController(VendedorRepository vendedorRepository)
    {
        _vendedorRepository = vendedorRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Vendedor>> GetVendedors()
    {
        var vendedors = _vendedorRepository.FindAll<Vendedor>();
        return Ok(vendedors);
    }

    [HttpGet("{id}")]
    public ActionResult<Vendedor> GetVendedor(int id)
    {
        var vendedor = _vendedorRepository.FindById<Vendedor>(id);

        if (vendedor == null)
        {
            return NotFound();
        }

        return Ok(vendedor);
    }

    [HttpPost]
    public ActionResult<Vendedor> PostVendedor(Vendedor vendedor)
    {
        _vendedorRepository.Add(vendedor);
        _vendedorRepository.Save();

        return CreatedAtAction(nameof(GetVendedor), new { id = vendedor.Id }, vendedor);
    }

    [HttpPut("{id}")]
    public ActionResult PutVendedor(int id, Vendedor vendedor)
    {
        if (id != vendedor.Id)
        {
            return BadRequest();
        }

        _vendedorRepository.Update(vendedor);
        _vendedorRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteVendedor(int id)
    {
        var vendedor = _vendedorRepository.FindById<Vendedor>(id);

        if (vendedor == null)
        {
            return NotFound();
        }

        _vendedorRepository.Delete(vendedor);
        _vendedorRepository.Save();

        return NoContent();
    }
}

}