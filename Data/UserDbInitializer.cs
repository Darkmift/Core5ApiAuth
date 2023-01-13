using Core5ApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5ApiAuth.Data
{
    public static class UserDbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new Users[]
            {
                new Users{Name="admin",Password="12345"},
                new Users{Name="bob",Password="123456"}
            };

            foreach(Users user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }

    }
}
