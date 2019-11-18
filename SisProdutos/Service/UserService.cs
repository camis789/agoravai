using System;
using SisProdutos.models;
using SisProdutos.Config;
using System.Linq;
using System.Collections.Generic;

namespace SisProdutos.Service
{
    public class UserService
    {
        DbContextProduct context = new DbContextProduct();

        public User AddUser(User user)
        {
            user.DateCreate = DateTime.Now;

            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }

        public List<User> ListUsers()
        {
            var result = context.Users.ToList();

            return result;
        }
        public bool Auth(User user)
        {
            var result = context.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            if (result != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
            public bool TestEmail(User user) 
            {
                var results = context.Users.Where(x => x.Email == user.Email).FirstOrDefault();
                if (results != null)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

        public bool TestUser(User user)
        {
            var resultsname = context.Users.Where(x => x.Name == user.Name).FirstOrDefault();
            if (resultsname != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        }

       



    }
