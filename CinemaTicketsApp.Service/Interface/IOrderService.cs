using CinemaTicketsApp.Domain;
using CinemaTicketsApp.Domain.DomainModels;
using CinemaTicketsApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Service.Interface
{
    public interface IOrderService
    {
        public List<Order> GetAllOrders(string userId);
        public Order GetOrderDetails(BaseEntity model);
    }
}
