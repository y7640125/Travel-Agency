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
    public class UpdateBL : IUpdateBL
    {
        IUpdateDAL _UpdateDAL;
        public UpdateBL(IUpdateDAL update)
        {
            _UpdateDAL = update;
        }
        public List<Update> GetAllUpdates()
        {
            return _UpdateDAL.GetAllUpdates();
        }
        public bool AddUpdate (Update update)
        {
            return _UpdateDAL.AddUpdate(update);
        }

        public bool DeleteUpdate (int id)
        {
            return _UpdateDAL.DeleteUpdate(id);
        }

        public bool ChangeUpdate(int id, Update  Update)
        {
            return _UpdateDAL.ChangeUpdate(id, Update);
        }
    }
}
