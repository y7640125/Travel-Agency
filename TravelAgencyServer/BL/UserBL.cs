using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BL
{
    public class UserBL: IUserBL
    {
        IUserDAL _UserDAL;
        public UserBL(IUserDAL userDAL)
        {

            _UserDAL = userDAL;
        }
        public User Login(string email, string password)
        {
            return _UserDAL.Login(email,password);
        }
        public List<User> GetAllUsers()
        {
            return _UserDAL.GetAllUsers();
        }
        public bool AddUser(User user)
        {
            return _UserDAL.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _UserDAL.DeleteUser(id);
        }

        public bool UpdateUser(int id, User user)
        {
            return _UserDAL.UpdateUser(id, user);
        }

        int count = 0;
        public int IncreaseCount()
        {
            count = count + 1;
            return count;
        }
    }
}
