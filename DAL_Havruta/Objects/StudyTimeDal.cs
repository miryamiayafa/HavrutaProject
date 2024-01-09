using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Model;

namespace DAL_Havruta.Objects
{
   public class StudyTimeDal : IStudyTimeDal
    {
        private readonly DB.HavrutaDbContext context;
        public StudyTimeDal(DB.HavrutaDbContext _context)
        { 
        this.context = _context;  
        }   
    }
}