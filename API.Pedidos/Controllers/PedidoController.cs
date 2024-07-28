using API.Pedidos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Pedidos.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListaPedidos()
        {
            return Ok(CriarListaDePedidos());
        }

        [HttpGet("{numeroPedido:int}")]
        public IActionResult ObterPedido([FromRoute] int numeroPedido)
        {
            return Ok(CriarListaDePedidos().Where(x => x.Numero == numeroPedido));
        }

        [HttpPost]
        public IActionResult SalvaPedido()
        {
            return Ok("Pedido Salvo");
        }

        private static List<Pedido> CriarListaDePedidos()
        {
            // Criando uma lista de pedidos
            List<Pedido> pedidos = new List<Pedido>();

            // Adicionando 3 pedidos à lista
            pedidos.Add(new Pedido { Numero = 1, Produto = "Produto 1", Valor = 10.50m });
            pedidos.Add(new Pedido { Numero = 2, Produto = "Produto 2", Valor = 20.75m });
            pedidos.Add(new Pedido { Numero = 3, Produto = "Produto 3", Valor = 15.30m });

            // Retornando a lista de pedidos
            return pedidos;
        }
    }
}
