using System;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Interfase
{
    public interface IRequestDal
    {
        IEnumerable<Request> GetAll();
        public IEnumerable<Request> RequestsForIdAcceptingRequest(int IdAcceptingRequest);
        Request GetById(int id);    
        bool Update(Request request);
        bool Delete(Request request);
        bool AddNew(Request request);
        int GetNumberOfRequestForUser(int userId);
    }
}

