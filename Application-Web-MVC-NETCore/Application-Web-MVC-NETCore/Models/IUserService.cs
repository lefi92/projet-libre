using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Web_MVC_NETCore.Models
{
    public interface IUserService
    {

        User Inscription(User user);
        User Connexion(User user);

        User GetUser(int id);

        User UpdateUser(int id, User user);

        User DeleteUser(int id);
    }
}
