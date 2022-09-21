using BL.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class LookUpBL:ILookUpBL
    {
        ILookUpDAL _lookUpDAL;
        public LookUpBL(ILookUpDAL lookUpDAL)
        {
            _lookUpDAL = lookUpDAL;
        }
        public List<Airline> GetAllAirlines()
        {
            return _lookUpDAL.GetAllAirlines();
        }
        public List<Country> GetAllCountries()
        {
            return _lookUpDAL.GetAllCountries();
        }
        public List<Role> GetAllRoles()
        {
            return _lookUpDAL.GetAllRoles();
        }
    }
}
