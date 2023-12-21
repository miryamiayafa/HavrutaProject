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

        public bool AddNew(Comment newFile)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }

}