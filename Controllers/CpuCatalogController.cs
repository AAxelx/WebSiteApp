using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using WebSiteApp.Common.Enums;
using WebSiteApp.Models;
using WebSiteApp.Models.Requests;
using WebSiteApp.Services.Abstractions;
using WebSiteApp.Configurations;

namespace WebSiteApp.Controllers
{
    public class CpuCatalogController : Controller
    {
        private readonly ILogger<CpuCatalogController> _logger;
        private readonly ICpuService _cpuCatalogService;
        private readonly WebSiteConfig _options;

        public CpuCatalogController(ILogger<CpuCatalogController> logger, IOptions<Config> options, ICpuService cpuCatalogService)
        {
            _logger = logger;
            _cpuCatalogService = cpuCatalogService;
            _options = options.Value.WebSiteConfig;
        }

        public async Task<IActionResult> Catalog(int page, SortedTypeEnum sortedType)
        {
            var request = new GetByPageProductRequest() { Page = page, PageSize = _options.PageSize, SortedType = sortedType };
            var response = await _cpuCatalogService.GetByPage(request);
            if(response != null)
            {
                var view = new CpuCatalogViewModel
                {
                    Cpus = response.Cpus,
                    TotalRecords = response.TotalRecords,
                    CurrentPage = page,
                    PageSize = _options.PageSize,
                    SortedType = sortedType
                };
                return View(view);
            }

            return View("oops...");
        }

        public async Task<IActionResult> GetById(string id, int page, SortedTypeEnum sortedType)
        {
            var request = new GetByIdProductRequest() { Id = id };
            var response = await _cpuCatalogService.GetById(request);
            if(response != null)
            {
                var view = new CpuViewModel()
                {
                    Cpu = response.Cpu,
                    Page = page,
                    SortedType = sortedType
                };
                return View(view);
            }

            return View("oops...");
        }
    }
}
