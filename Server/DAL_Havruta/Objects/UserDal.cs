﻿using System;
using System.Collections.Generic;
using System.Linq;
using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;
using DTO_Havruta.Model;


namespace DAL_Havruta.Objects
{
    public class UserDal : IUserDal
    {
        private readonly DB.HavrutaDbContext context;

        public UserDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public int AddNew(DAL_Havruta.Migrations.Model.User u)
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

        public bool Delete(DAL_Havruta.Migrations.Model.User DeleteUser)
        {
            DAL_Havruta.Migrations.Model.User userTry = GetById(DeleteUser.Iduser);
            try
            {
                if (userTry != null)
                {
                    context.Remove(userTry);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)// WHEN userTry==NULL I CAN'T DELETE USER.
            {
                throw new Exception();
            }
        }

        public DAL_Havruta.Migrations.Model.User GetByEmail(string email)
        {
            try
            {
                return context.Users.FirstOrDefault(x => x.Email == email);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<DAL_Havruta.Migrations.Model.User> GetAll()
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

        public DAL_Havruta.Migrations.Model.User GetById(int id)
        {
            try
            {
                return context.Users.FirstOrDefault(x => x.Iduser == id);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
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

        public IEnumerable<DTO_Havruta.Model.UserInformation> GetUserSubjectInfo()
        {
            try
            {
                var query = from user in context.Users
                            join userSubject in context.UserSubjects on user.Iduser equals userSubject.IdUser
                            join subject in context.Subjects on userSubject.IdSubject equals subject.Idsubject
                            select new UserInformation
                            {
                                sector = user.Sector,
                                gender = user.Gender,
                                descriptionMyStudy = user.DecriptionMyStudy,
                                fName = user.FName,
                                age = (int)user.Age,
                                subject = subject.Subject1,
                                SubjectDescription = subject.Description
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user subject information", ex);
            }
        }
    }
}
