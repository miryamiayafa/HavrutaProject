using DAL_Havruta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Havruta.Interface
{
    public interface IUserServices
    {
      IEnumerable<DTO_Havruta.Model.User>GetAll();
        bool AddNew(DTO_Havruta.Model.User newUser);
        DTO_Havruta.Model.User GetById(int id);
        DTO_Havruta.Model.User GetByEmail(string emaile);
        bool Delete(DTO_Havruta.Model.User deleteUser);    


    }



}