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
    public class GpuCatalogController : Controller
    {
        private readonly ILogger<GpuCatalogController> _logger;
        private readonly IGpuService _gpuCatalogService;
        private readonly WebSiteConfig _options;

        public GpuCatalogController(ILogger<GpuCatalogController> logger, IOptions<Config> options, IGpuService gpuCatalogService)
        {
            _logger = logger;
            _gpuCatalogService = gpuCatalogService;
            _options = options.Value.WebSiteConfig;
        }

        public async Task<IActionResult> Catalog(int page, SortedTypeEnum sortedType)
        {
            var request = new GetByPageProductRequest() { Page = page, PageSize = _options.PageSize, SortedType = sortedType };
            var response = await _gpuCatalogService.GetByPage(request);
            if (response != null)
            {
                var view = new GpuCatalogViewModel
                {
                    Gpus = response.Gpus,
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
            var response = await _gpuCatalogService.GetById(request);
            if (response != null)
            {
                var view = new GpuViewModel()
                {
                    Cpu = response.Gpu,
                    Page = page,
                    SortedType = sortedType
                };
                return View(view);
            }

            return View("oops...");
        }
    }
}