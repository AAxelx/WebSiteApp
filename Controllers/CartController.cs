using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Common.Enums;
using WebSiteApp.Models.Requests;

namespace WebSiteApp.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ILogger<CpuCatalogController> _cpuLogger;
        private readonly ILogger<GpuCatalogController> _gpuLogger;
        private readonly ICartService _cartService;

        public CartController( ICartService cartService, ILogger<CpuCatalogController> cpuLogger, ILogger<GpuCatalogController> gpuLogger)
        {
            _cpuLogger = cpuLogger;
            _gpuLogger = gpuLogger;
            _cartService = cartService;
        }

        public async Task AddToCart(string productId, ProductTypeEnum productType)
        {
            var userId = User.FindFirst("http://").Value;
            var request = new AddCartRequest()
            {
                UserId = userId,
                ProductId = productId,
                Type = productType
            };
            await _cartService.AddToCart(request);
        }

        public async Task<IActionResult> GetCart()
        {
            var userId = User.FindFirst("http://").Value;
            var request = new GetCartRequest()
            {
                UserId = userId
            };
            var response = await _cartService.GetCart(request);
            return View(response);
        }

        public async Task RemoveFromCart(string productId)
        {
            var userId = User.FindFirst("http://").Value;
            var request = new RemoveCartRequest()
            {
                UserId = userId,
                ProductId = productId
            };
            await _cartService.RemoveFromCart(request);
        }

        public async Task ClearCart()
        {
            var userId = User.FindFirst("http://").Value;
            var request = new ClearCartRequest()
            {
                UserId = userId
            };
            await _cartService.ClearCart(request);
        }
    }
}
