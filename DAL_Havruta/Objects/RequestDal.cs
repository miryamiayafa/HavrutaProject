using System;
using DAL_Havruta.Model;
using DAL_Havruta.Interfase;

namespace DAL_Havruta.Objects
{
    public class RequestDal : IRequestDal
    {
        private readonly DB.HavrutaDbContext context;

        public RequestDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }



    }


}


