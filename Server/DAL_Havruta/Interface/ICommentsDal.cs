using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Havruta.Interfase
{
    public interface ICommentsDal
    {
        IEnumerable<DAL_Havruta.Model.Comment> GetAll();
        Model.Comment GetById(int id);
        bool AddNew(Model.Comment newComment);
        bool Update(Model.Comment Comment);
        bool Delete(Model.Comment Comment);
    
    }
}

     