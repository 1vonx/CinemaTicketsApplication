using CinemaTicketsApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketsApp.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<CinemaTicketsAppUser> GetAll();
        CinemaTicketsAppUser Get(string id);
        void Insert(CinemaTicketsAppUser entity);
        void Update(CinemaTicketsAppUser entity);
        void Delete(CinemaTicketsAppUser entity);
    }
}
