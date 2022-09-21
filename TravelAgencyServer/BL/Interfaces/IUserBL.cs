using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IUserBL
    {
        User Login(string email, string password);
        List<User> GetAllUsers();
        bool AddUser(User user);
        bool DeleteUser(int id);
        bool UpdateUser(int id, User user);
        int IncreaseCount();
    }
}
