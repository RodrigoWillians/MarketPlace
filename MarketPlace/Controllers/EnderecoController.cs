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
public class EnderecoController : ControllerBase
{
    private readonly EnderecoRepository _enderecoRepository;

    public EnderecoController(EnderecoRepository enderecoRepository)
    {
        _enderecoRepository = enderecoRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Endereco>> GetEnderecos()
    {
        var enderecos = _enderecoRepository.FindAll<Endereco>();
        return Ok(enderecos);
    }

    [HttpGet("{id}")]
    public ActionResult<Endereco> GetEndereco(int id)
    {
        var endereco = _enderecoRepository.FindById<Endereco>(id);

        if (endereco == null)
        {
            return NotFound();
        }

        return Ok(endereco);
    }

    [HttpPost]
    public async Task<ActionResult<Endereco>> PostEndereco(Endereco endereco)
    {
        _enderecoRepository.Add(endereco);
        await _enderecoRepository.Save();

        return CreatedAtAction(nameof(GetEndereco), new { id = endereco.Id }, endereco);
    }

    [HttpPut("{id}")]
    public ActionResult PutEndereco(int id, Endereco endereco)
    {
        if (id != endereco.Id)
        {
            return BadRequest();
        }

        _enderecoRepository.Update(endereco);
        _enderecoRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteEndereco(int id)
    {
        var endereco = _enderecoRepository.FindById<Endereco>(id);

        if (endereco == null)
        {
            return NotFound();
        }

        _enderecoRepository.Delete(endereco);
        _enderecoRepository.Save();

        return NoContent();
    }
}

}