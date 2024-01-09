using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Model;

namespace DAL_Havruta.Objects
{
    public class StudyTypeDal : IStudyTypeDal
    {
        private readonly DB.HavrutaDbContext context;
        public StudyTypeDal(DB.HavrutaDbContext _context) 
         { 
            this.context = _context;    
        }   
    }
}