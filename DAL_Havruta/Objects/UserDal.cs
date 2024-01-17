using System;
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

        public bool AddNew(User u)
        {
            try
            {
               User tryUserByEmail=GetByEmail(u.Email);
                
                if (tryUserByEmail==null)
                    
                    context.Users.Add(u);
              
                return true;
               
            }

            catch(Exception ex) 
            {  

                    throw new Exception();
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
                return (User)GetAll().Where(x => x.Email.Equals(email));
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







    }
}