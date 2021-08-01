using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Configurations;
using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;

namespace WebSiteApp.Services
{
    public class CpuService : ICpuService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly RouteConfig _routeConfig;

        public CpuService(IHttpClientService httpClientService, IOptions<Config> options)
        {
            _routeConfig = options.Value.WebSiteRoute;
            _httpClientService = httpClientService;
        }

        public async Task<GetByPageCpuResponse> GetByPage(GetByPageProductRequest getByPageRequest)
        {
            var url = $"{_routeConfig.Cpu}GetByPage";
            var response = await _httpClientService.SendAsync<GetByPageCpuResponse>(url, HttpMethod.Post, getByPageRequest);
            return response;
        }

        public async Task<GetByIdCpuResponse> GetById(GetByIdProductRequest getByIdRequest)
        {
            var url = $"{_routeConfig.Cpu}GetById";
            var response = await _httpClientService.SendAsync<GetByIdCpuResponse>(url, HttpMethod.Post, getByIdRequest);
            return response;
        }
    }
}
