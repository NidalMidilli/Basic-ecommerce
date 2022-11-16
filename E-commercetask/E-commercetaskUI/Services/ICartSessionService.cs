using EntityLayer;

namespace E_commercetaskUI.Services
{
    public interface ICartSessionService
    {
       
            Cart GetCart();
            void SetCart(Cart cart);
        
    }
}
