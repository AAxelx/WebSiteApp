using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;
using System.Threading.Tasks;

namespace WebSiteApp.Services.Abstractions
{
    public interface IOrderService
    {
        Task<AddOrderResponse> AddOrder(AddOrderRequest addOrderRequest);
        Task<GetByPageOrderResponse> GetByPageOrder(GetByPageOrderRequest getByPageOrderRequest);
        Task<GetByIdOrderResponse> GetByIdOrder(GetByIdOrderRequest getByIdOrderRequest);
    }
}
