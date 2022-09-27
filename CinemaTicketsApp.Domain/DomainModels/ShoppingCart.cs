using CinemaTicketsApp.Domain.Identity;
using CinemaTicketsApp.Domain.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual CinemaTicketsAppUser Owner { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
    }
}
