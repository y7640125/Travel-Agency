using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interfaces
{
    public interface ILookUpBL
    {
        public List<Airline> GetAllAirlines();
        public List<Country> GetAllCountries();
        public List<Role> GetAllRoles();
    }
}
