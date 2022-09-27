﻿using CinemaTicketsApp.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Domain.Identity
{
    public class CinemaTicketsAppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public virtual ShoppingCart UserCart { get; set; }
    }
}