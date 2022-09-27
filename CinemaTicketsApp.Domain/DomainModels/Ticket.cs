using CinemaTicketsApp.Domain.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketsApp.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public string TicketName { get; set; }

        [Required]
        public string TicketImage { get; set; }

        [Required]
        [Display(Name = "Valid till")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public string TicketGenre { get; set; }

        [Required]
        public double TicketPrice { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
        public virtual ICollection<TicketInOrder> TicketsInOrder { get; set; }
    }
}
