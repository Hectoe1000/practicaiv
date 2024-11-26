using context;
using Dt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using models;
namespace MiApi.Controllers;
public class ClientesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ClientesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Endpoint que devuelve clientes con sus pedidos
    [HttpGet("clientes-con-pedidos")]
    public async Task<ActionResult<IEnumerable<object>>> GetClientesConPedidos()
    {
        var resultado = await _context.Clientes
            .Join(
                _context.Pedidos,
                cliente => cliente.ClienteId,
                pedido => pedido.ClienteId,
                (cliente, pedido) => new
                {
                    ClienteId = cliente.ClienteId,
                    Nombre = cliente.Nombre,
                    Correo = cliente.Correo,
                    PedidoId = pedido.PedidoId,
                    Fecha = pedido.Fecha,
                    Monto = pedido.Monto
                })
            .ToListAsync();

        return Ok(resultado);
    }
}

