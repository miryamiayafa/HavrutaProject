using DAL_Havruta.DB;
using DAL_Havruta.Model;
using System;
using System.Linq;
using DAL_Havruta.Interfase;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL_Havruta.Objects

{
    public class CommentsDal : ICommentsDal
    {
        private readonly DB.HavrutaDbContext context;

        public CommentsDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public bool AddNew(Comment comment)
        {
            try
            {
                if (GetById(comment.Idcomment) != null)
                    return false;
                context.Comments.Add(comment);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public bool Delete(Comment comment)
        {
            try
            {
                if (GetById(comment.Idcomment) == null)
                    return false;
                context.Comments.Remove(comment);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Comment> GetAll()
        {
            try
            {
                return context.Comments.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Comment GetById(int id)
        {
            try
            {
                return ((Comment)(GetAll().Where(X => X.Idcomment.Equals(id))));

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        

        public bool Update(Comment comment)
        {
            Comment getByIdTry = GetById(comment.Idcomment);
            try
            {
                if (getByIdTry != null)
                    return false;
                context.Comments.Update(comment);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}