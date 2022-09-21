using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interfaces
{
    public interface IMessageBL
    {
        public List<Message> GetAllMessages();
        public bool AddMessage(Message message);

        public bool DeleteMessage(int id);

        public bool UpdateMessage(int id, Message message);
    }
}
