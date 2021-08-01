using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Configurations;
using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;

namespace WebSiteApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly RouteConfig _routeConfig;

        public OrderService(IHttpClientService httpClientService, IOptions<Config> options)
        {
            _routeConfig = options.Value.WebSiteRoute;
            _httpClientService = httpClientService;
        }

        public async Task<AddOrderResponse> AddOrder(AddOrderRequest addOrderRequest)
        {
            string url = $"{_routeConfig.Order}Add";
            var response = await _httpClientService.SendAsync<AddOrderResponse>(url, HttpMethod.Post, addOrderRequest);
            return response;
        }

        public async Task<GetByPageOrderResponse> GetByPageOrder(GetByPageOrderRequest getByPageOrderRequest)
        {
            string url = $"{_routeConfig.Order}GetByPage";
            var response = await _httpClientService.SendAsync<GetByPageOrderResponse>(url, HttpMethod.Post, getByPageOrderRequest);
            return response;
        }

        public async Task<GetByIdOrderResponse> GetByIdOrder(GetByIdOrderRequest getByIdOrderRequest)
        {
            string url = $"{_routeConfig.Order}GetById";
            var response = await _httpClientService.SendAsync<GetByIdOrderResponse>(url, HttpMethod.Post, getByIdOrderRequest);
            return response;
        }
    }
}
