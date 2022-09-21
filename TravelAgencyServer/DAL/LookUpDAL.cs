using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
  public class LookUpDAL: ILookUpDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        public List<Airline> GetAllAirlines()
        {
            try
            {
                return _context.Airlines.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
          
            }

        }
        public List<Country> GetAllCountries()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Role> GetAllRoles()
        {
            try
            {
                return _context.Roles.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
