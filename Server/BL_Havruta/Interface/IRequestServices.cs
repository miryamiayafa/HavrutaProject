using DAL_Havruta.Migrations.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface IRequestServices
    {
        IEnumerable<DTO_Havruta.Model.Request> GetAll();
        IEnumerable<DTO_Havruta.Model.Request> GetRequestsForIdAcceptingRequest(int IdAcceptingRequest);
        bool AddNew(DTO_Havruta.Model.Request newRequest);
        DTO_Havruta.Model.Request GetById(int id);
        bool Delete(DTO_Havruta.Model.Request deleteRequest);
        bool Update(DTO_Havruta.Model.Request updateRequest);

        int GetNumberOfRequestForUser(int userId);

    }

}
