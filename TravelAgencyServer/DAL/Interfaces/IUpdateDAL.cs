using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUpdateDAL
    {
        List<Update> GetAllUpdates();
        bool AddUpdate(Update update);
        bool DeleteUpdate(int id);
        bool ChangeUpdate(int id, Update update);
    }
}
