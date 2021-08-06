using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebSiteApp.Configurations;
using WebSiteApp.Models;
using WebSiteApp.Models.Requests;
using WebSiteApp.Services.Abstractions;

namespace WebSiteApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly WebSiteConfig _options;

        public OrderController(
            ILogger<OrderController> logger,
            IOrderService orderService,
            ICartService cartService,
            IOptions<Config> options)
        {
            _orderService = orderService;
            _options = options.Value.WebSiteConfig;
            _logger = logger;
            _cartService = cartService;
        }

        public async Task Add()
        {
            var userId = User.FindFirst("htttp://").Value;
            var getCartUser = await _cartService.GetCart(new GetCartRequest { UserId = userId });
            var request = new AddOrderRequest()
            {
                UserId = userId,
                Products = getCartUser.CartProducts
            };
            await _orderService.AddOrder(request);
        }

        public async Task<IActionResult> GetByPage(int page)
        {
            var userId = User.FindFirst("http://").Value;
            var request = new GetByPageOrderRequest()
            {
                Page = page,
                UserId = userId
            };
            var response = await _orderService.GetByPageOrder(request);
            await Task.Delay(1000);
            return View(response);
        }

        public async Task<IActionResult> GetById(string orderId)
        {
            var userId = User.FindFirst("http://").Value;
            var request = new GetByIdOrderRequest()
            {
                UserId = userId,
                OrderId = orderId
            };
            var response = await _orderService.GetByIdOrder(request);
            var view = new GetByIdOrderViewModel()
            {
                OrderId = orderId,
                Products = response.ProductModels
            };

            return View(view);
        }
    }
}
