using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IProductoService _productoService;
        private readonly IPedidoService _pedidoService;

        public HomeController(
            IClienteService clienteService, 
            IProductoService productoService,
            IPedidoService pedidoService)
        {
            _clienteService = clienteService;
            _productoService = productoService;
            _pedidoService = pedidoService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Clientes = new SelectList(await _clienteService.List(), "Codigo", "NombreCompleto");
            ViewBag.Productos = new SelectList(await _productoService.List(), "Codigo", "Descripcion");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SaveOrder([FromBody] PedidoDto pedido)
        {
            await _pedidoService.Save(pedido);
            return Json("El pedido se guardó de manera exitosa");
        }
    }
}
