using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL: IUserDAL
    {
            TravelAgencyContext _context = new TravelAgencyContext();
         
            public User Login(string email,string password)
            {
                User user = _context.Users.SingleOrDefault(x => x.Email.Equals(email)&&x.Password.Equals(password));
                return user;
            }
        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddUser(User user)
            {
                try
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        public bool DeleteUser(int id)
            {
                try
                {
                    User user = _context.Users.SingleOrDefault(x => x.Id == id);
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            public bool UpdateUser(int id, User user)
            {
                try
                {
                    User currentUser = _context.Users.SingleOrDefault(x => x.Id == id);
                    _context.Entry(currentUser).CurrentValues.SetValues(user);
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
