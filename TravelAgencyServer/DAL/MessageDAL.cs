using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MessageDAL:IMessageDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        public List<Message> GetAllMessages()
        {
            try
            {
                return _context.Messages.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddMessage(Message message)
        {
            try
            {
                _context.Messages.Add(message);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteMessage(int id)
        {
            try
            {
                Message message = _context.Messages.SingleOrDefault(x => x.Id == id);
                _context.Messages.Remove(message);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateMessage(int id, Message message)
        {
            try
            {
                Message currentMessage = _context.Messages.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentMessage).CurrentValues.SetValues(message);
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
