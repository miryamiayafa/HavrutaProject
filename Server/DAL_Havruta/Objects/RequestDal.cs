using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Objects
{
    public class RequestDal : IRequestDal
    {
        private readonly DB.HavrutaDbContext context;

        public RequestDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public bool AddNew(Request request)
        {
            try
            {
                if (request != null)
                {
                    context.Requests.Add(request);
                }

                return true;


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }




        public bool Delete(Request request)
        {
            Request requestTry = GetById(request.Idrequest);
            try
            {
                if (requestTry != null)
                    context.Requests.Remove(request);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public bool Update(Request request)
        {
            Request requestTry = GetById(request.Idrequest);
            try
            {
                if (requestTry != null)
                    context.Requests.Update(request);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public IEnumerable<Request> GetAll()
        {
            try
            {
                return context.Requests.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public Request GetById(int id)
        {

            try
            {
                return (Request)GetAll().Where(x => x.Idrequest == id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public int GetNumberOfRequestForUser(int userId)
        {
            try
            {
                return context.Requests.Where(r => r.IdAcceptingRequest == userId && r.Ok == null).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Couldn't get the data");
            }
            
        }
    }
}



    
