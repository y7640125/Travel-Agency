using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IMessageDAL
    {
        public List<Message> GetAllMessages();
        public bool AddMessage(Message message);

        public bool DeleteMessage(int id);
        public bool UpdateMessage(int id, Message message);
    }
}
