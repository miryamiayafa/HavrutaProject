using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface IStudy
    {
        IEnumerable<DTO_Havruta.Model.Study> GetAll();
        bool AddNew(DTO_Havruta.Model.Study newStudy);
        DTO_Havruta.Model.Study GetById(int id);
        bool Delete(DTO_Havruta.Model.Study deleteStudy);
        bool Update(DTO_Havruta.Model.Study updateStudy);

    }

}
