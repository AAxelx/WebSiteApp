using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Configurations;
using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;


namespace WebSiteApp.Services
{
    public class GpuService : IGpuService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly RouteConfig _routeConfig;

        public GpuService(IHttpClientService httpClientService, IOptions<Config> options)
        {
            _routeConfig = options.Value.WebSiteRoute;
            _httpClientService = httpClientService;
        }

        public async Task<GetByPageGpuResponse> GetByPage(GetByPageProductRequest getByPageRequest)
        {
            var url = $"{_routeConfig.Gpu}GetByPage";
            var response = await _httpClientService.SendAsync<GetByPageGpuResponse>(url, HttpMethod.Post, getByPageRequest);
            return response;
        }

        public async Task<GetByIdGpuResponse> GetById(GetByIdProductRequest getByIdRequest)
        {
            var url = $"{_routeConfig.Gpu}GetById";
            var response = await _httpClientService.SendAsync<GetByIdGpuResponse>(url, HttpMethod.Post, getByIdRequest);
            return response;
        }
    }
}
