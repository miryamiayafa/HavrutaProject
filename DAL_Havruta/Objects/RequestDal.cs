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


    }
}



    
