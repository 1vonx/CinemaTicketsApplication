using CinemaTicketsApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto GetShoppingCartInfo(string userId);
        bool DeleteProductFromSoppingCart(string userId, Guid ticketId);
        bool Order(string userId);
    }
}
