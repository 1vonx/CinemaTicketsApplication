using CinemaTicketsApp.Domain.DomainModels;
using CinemaTicketsApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Service.Interface
{
    public interface IUserService
    {
        public IEnumerable<CinemaTicketsAppUser> GetAllUsers();
        public void UpdateUserRole(string userId, List<UserRoles> model);
    }
}
