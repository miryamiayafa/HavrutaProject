
using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IManagerDal
    {
        IEnumerable<Manager> GetAll();  
        Manager GetById(int id);   
        bool Delete(Manager manager);
        bool Update(Manager manager);   
        bool AddNew(Manager manager);   
    }
}

