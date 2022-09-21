using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICreditBL
    {
        List<Credit> GetAllCredits();
        bool AddCredit(Credit credit);
        bool DeleteCredit(int id);
        bool UpdateCredit(int id, Credit credit);
    }
}
