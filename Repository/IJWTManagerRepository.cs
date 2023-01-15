using Core5ApiAuth.Data;
using Core5ApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5ApiAuth.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(UsersDto userData,UserContext context);
    }
}
