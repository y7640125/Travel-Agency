using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ILookUpDAL
    {
        public List<Airline> GetAllAirlines();
        public List<Country> GetAllCountries();
        public List<Role> GetAllRoles();

    }
}
