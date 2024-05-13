using System;
using System.Reflection.PortableExecutable;
using DAL_Havruta.Interfase;
using DAL_Havruta.Model;




namespace DAL_Havruta.Objects

{
    public class UserDal : IUserDal
    {
        private readonly DB.HavrutaDbContext context;

        public UserDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public int AddNew(User u)
        {
            try
            {
                bool tryUserByEmail = GetAll().Any(user => user.Email == u.Email);

                if (!tryUserByEmail)
                {
                    context.Users.Add(u);
                    context.SaveChanges();
                    return u.Iduser;
                }
                else
                {
                    return -2;
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public bool Delete(User DeleteUser)
        {
            User userTry = GetById(DeleteUser.Iduser);
            try
            {
                if (userTry != null)
                    context.Remove(userTry);
                return true;
            }
            catch(Exception ex)// WHEN userTry==NULL I CAN'T DELETE USER.
            { 
                throw new Exception();
            }  

            
        }

        public User GetByEmail(string email)
        {
            try
            {
                return (User)GetAll().Where(x => x.Email == email);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                return context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


        public User GetById(int id)
        {

            try
            {
                return (User)GetAll().Where(x => x.Iduser == id);
            }
            catch (Exception ex) { }

            throw new NotImplementedException();
        }

        public bool IsUserExsit(int id)
        {
            try
            {
                return context.Users.Any(u => u.Iduser == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't connect to the data base");
            }
        }

        public int Login(string email, string password)
        {
            try
            {
                var userId = context.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault()?.Iduser;
                if (userId == null)
                {
                    return -1;
                }
                return (int)userId;
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't connect to the data base");
            }
        }
    }
}