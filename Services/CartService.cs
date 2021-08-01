using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebSiteApp.Configurations;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;

namespace WebSiteApp.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly RouteConfig _routeConfig;

        public CartService(IHttpClientService httpClientService, IOptions<Config> options)
        {
            _httpClientService = httpClientService;
            _routeConfig = options.Value.WebSiteRoute;
        }

        public async Task<AddCartResponse> AddToCart(AddCartRequest addCartRequest)
        {
            string url = $"{_routeConfig.Cart}Add";
            var response = await _httpClientService.SendAsync<AddCartResponse>(url, HttpMethod.Post, addCartRequest);
            return response;
        }

        public async Task<GetCartResponse> GetCart(GetCartRequest getCartRequest)
        {
            string url = $"{_routeConfig.Cart}Get";
            var response = await _httpClientService.SendAsync<GetCartResponse>(url, HttpMethod.Post, getCartRequest);
            return response;
        }

        public async Task<RemoveCartResponse> RemoveFromCart(RemoveCartRequest removeCartRequest)
        {
            string url = $"{_routeConfig.Cart}Remove";
            var response = await _httpClientService.SendAsync<RemoveCartResponse>(url, HttpMethod.Post, removeCartRequest);
            return response;
        }

        public async Task<ClearCartResponse> ClearCart(ClearCartRequest clearCartRequest)
        {
            string url = $"{_routeConfig.Cart}Clear";
            var response = await _httpClientService.SendAsync<ClearCartResponse>(url, HttpMethod.Post, clearCartRequest);
            return response;
        }
    }
}
