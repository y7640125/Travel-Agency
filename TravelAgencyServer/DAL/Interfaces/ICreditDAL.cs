using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICreditDAL
    {
        List<Credit> GetAllCredits();
        bool AddCredit(Credit credit);
        bool DeleteCredit(int id);
        bool UpdateCredit(int id, Credit credit);
    }
}
