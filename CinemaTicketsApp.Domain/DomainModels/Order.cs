using CinemaTicketsApp.Domain.Identity;
using CinemaTicketsApp.Domain.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public CinemaTicketsAppUser User { get; set; }

        public virtual ICollection<TicketInOrder> TicketsInOrder { get; set; }
    }
}
