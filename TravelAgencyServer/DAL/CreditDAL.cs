using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CreditDAL: ICreditDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        public List<Credit> GetAllCredits()
        {
            try
            {
                return _context.Credits.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddCredit(Credit credit)
        {
            try
            {
                _context.Credits.Add(credit);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCredit(int id)
        {
            try
            {
                Credit Credit = _context.Credits.SingleOrDefault(x => x.UserId.Equals(id));
                _context.Credits.Remove(Credit);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateCredit(int id, Credit credit)
        {
            try
            {
                Credit currentCredit = _context.Credits.SingleOrDefault(x => x.UserId.Equals(id));
                _context.Entry(currentCredit).CurrentValues.SetValues(credit);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
