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
public class ClienteController : ControllerBase
{
    private readonly ClienteRepository _clienteRepository;

    public ClienteController(ClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cliente>> GetClientes()
    {
        var clientes = _clienteRepository.FindAll<Cliente>();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> GetCliente(int id)
    {
        var cliente = _clienteRepository.FindById<Cliente>(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return Ok(cliente);
    }

    [HttpPost]
    public ActionResult<Cliente> PostCliente(Cliente cliente)
    {
        _clienteRepository.Add(cliente);
        _clienteRepository.Save();

        return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
    }

    [HttpPut("{id}")]
    public ActionResult PutCliente(int id, Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return BadRequest();
        }

        _clienteRepository.Update(cliente);
        _clienteRepository.Save();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCliente(int id)
    {
        var cliente = _clienteRepository.FindById<Cliente>(id);

        if (cliente == null)
        {
            return NotFound();
        }

        _clienteRepository.Delete(cliente);
        _clienteRepository.Save();

        return NoContent();
    }
}

}