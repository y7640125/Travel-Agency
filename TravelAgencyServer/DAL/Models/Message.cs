using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message1 { get; set; }
        public string Answer { get; set; }
    }
}
