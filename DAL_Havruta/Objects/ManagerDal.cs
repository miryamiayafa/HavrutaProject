using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Model;

namespace DAL_Havruta.Objects
{
    public class ManagerDal : IManagerDal
    {
        private readonly DB.HavrutaDbContext context;
        public ManagerDal(DB.HavrutaDbContext _context) 
        { 
        this.context = _context;
        
        }

        public bool AddNew(Manager manager)
        {
            try
            {
                if (GetByEmail(manager.Email)!=null)
                    return false;
                context.Managers.Add(manager);
                return true;

            }
            catch(Exception ex) 
            {
                throw new Exception();
            }
        }

        public bool Delete(Manager manager)
        {
            try
            {
                if(GetById(manager.Idmanager)==null)
                    return false;
                context.Managers.Remove(manager);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Manager> GetAll()
        {
            try
            {
               return context.Managers.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Manager GetById(int id)
        {
            try
            {
                return ((Manager)(GetAll().Where(X => X.Idmanager.Equals(id))));

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Manager GetByEmail(string email) 
        {
            return (Manager)GetAll().Where(x => x.Email.Equals(email));


        }

        public bool Update(Manager manager)
        {
            try
            {
                if (GetByEmail(manager.Email)==null)
                    return false;
                context.Managers.Update(manager);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}