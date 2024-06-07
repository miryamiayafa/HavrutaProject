using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Havruta.Migrations.Model;


namespace DAL_Havruta.Interfase
{
    public interface ICommentsDal
    {
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        bool AddNew(Comment newComment);
        bool Update(Comment Comment);
        bool Delete(Comment Comment);
    
    }
}

     