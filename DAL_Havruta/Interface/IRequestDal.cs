using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IRequestDal
    {
        IEnumerable<Request> GetAll();
        Request GetById(int id);    
        bool Update(Request request);
        bool Delete(int id);
        bool AddNew(Request request);


    }
}

