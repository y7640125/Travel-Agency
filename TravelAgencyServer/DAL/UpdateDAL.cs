using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UpdateDAL: IUpdateDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        
        public List<Update> GetAllUpdates()
        {
            try
            {
                return _context.Updates.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddUpdate(Update update)
        {
            try
            {
                _context.Updates.Add(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteUpdate(int id)
        {
            try
            {
                Update update = _context.Updates.SingleOrDefault(x => x.Id == id);
                _context.Updates.Remove(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ChangeUpdate(int id, Update update)
        {
            try
            {
                Update currentUpdate = _context.Updates.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentUpdate).CurrentValues.SetValues(update);
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
