using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface ICommentsServices
    {
        IEnumerable<DTO_Havruta.Model.Comment> GetAll();
        bool AddNew(DTO_Havruta.Model.Comment newComment);
        DTO_Havruta.Model.Comment GetById(int id);
        bool Delete(DTO_Havruta.Model.Comment deleteComment);
        bool Update(DTO_Havruta.Model.Comment updateComment);

    }

}
