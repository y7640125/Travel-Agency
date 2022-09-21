using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CreditBL : ICreditBL
    {
        ICreditDAL _CreditDAL;

        public List<Credit> GetAllCredits()
        {
            return _CreditDAL.GetAllCredits();
        }
        public bool AddCredit(Credit credit)
        {
            return _CreditDAL.AddCredit(credit);
        }

        public bool DeleteCredit(int id)
        {
            return _CreditDAL.DeleteCredit(id);
        }

        public bool UpdateCredit(int id, Credit credit)
        {
            return _CreditDAL.UpdateCredit(id, credit);
        }
    }
}
