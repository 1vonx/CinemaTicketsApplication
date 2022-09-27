using CinemaTicketsApp.Domain.DomainModels;
using CinemaTicketsApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Service.Interface
{
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewTicket(Ticket t);
        void UpdeteExistingTicket(Ticket t);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteTicket(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
