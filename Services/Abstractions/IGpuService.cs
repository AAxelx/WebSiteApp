using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;
using System.Threading.Tasks;

namespace WebSiteApp.Services.Abstractions
{
    public interface IGpuService
    {
        Task<GetByPageGpuResponse> GetByPage(GetByPageProductRequest getByPageProductRequest);
        Task<GetByIdGpuResponse> GetById(GetByIdProductRequest getByIdProductRequest);
    }
}
