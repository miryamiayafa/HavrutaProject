﻿using DAL_Havruta.Model;
using DTO_Havruta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Havruta.Interface
{
    public interface IManager
    {
        IEnumerable<DTO_Havruta.Model.Manager> getAll();
         bool AddNew(DTO_Havruta.Model.Manager manager);    
        DTO_Havruta.Model.Manager GetById(int id);
        DTO_Havruta.Model.Manager GetByEmail(string email);
        bool Delete(DTO_Havruta.Model.Manager deleteManager);
        

    }
}
