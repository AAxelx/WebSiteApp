using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;
using System.Threading.Tasks;

namespace WebSiteApp.Services.Abstractions
{
    public interface ICpuService
    {
        Task<GetByPageCpuResponse> GetByPage(GetByPageProductRequest getByPageProductRequest);
        Task<GetByIdCpuResponse> GetById(GetByIdProductRequest getByIdProductRequest);
    }
}
