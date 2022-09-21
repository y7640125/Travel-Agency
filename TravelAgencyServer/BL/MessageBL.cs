using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class MessageBL : IMessageBL
    {
        IMessageDAL _messageDAL;
        public MessageBL(IMessageDAL message)
        {
            _messageDAL = message;
        }
        public List<Message> GetAllMessages()
        {
            return _messageDAL.GetAllMessages();
        }
        public bool AddMessage(Message message)
        {
            return _messageDAL.AddMessage(message);
        }

        public bool DeleteMessage(int id)
        {
            return _messageDAL.DeleteMessage(id);
        }

        public bool UpdateMessage(int id, Message message)
        {
            return _messageDAL.UpdateMessage(id, message);
        }
    }
}
