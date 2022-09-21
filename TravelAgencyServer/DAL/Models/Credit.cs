using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Models
{
    public partial class Credit
    {

        [Key]
        public int UserId { get; set; }
        public int CreditNum { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Cvv { get; set; }

        public virtual User User { get; set; }
    }
}
