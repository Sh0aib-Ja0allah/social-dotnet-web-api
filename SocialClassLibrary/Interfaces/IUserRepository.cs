using SocialClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClassLibrary.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();

        //User GetUser(int id);
        //User GetUser(string FirstName, string LastName);

    }
}
