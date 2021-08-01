using WebSiteApp.Models.Requests;
using WebSiteApp.Models.Responses;
using System.Threading.Tasks;

namespace WebSiteApp.Services.Abstractions
{
    public interface ICartService
    {
        Task<AddCartResponse> AddToCart(AddCartRequest addCartRequest);
        Task<GetCartResponse> GetCart(GetCartRequest getCartRequest);
        Task<RemoveCartResponse> RemoveFromCart(RemoveCartRequest removeCartRequest);
        Task<ClearCartResponse> ClearCart(ClearCartRequest clearCartRequest);
    }
}
