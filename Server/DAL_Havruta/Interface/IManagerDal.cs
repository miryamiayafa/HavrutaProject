
using System;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Interfase
{
    public interface IManagerDal
    {
        IEnumerable<Manager> GetAll();  
        Manager GetById(int id);   
        Manager GetByEmail(string email);
        bool Delete(Manager manager);
        bool Update(Manager manager);   
        bool AddNew(Manager manager);   
    }
}

