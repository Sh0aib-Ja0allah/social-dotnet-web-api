using SocialClassLibrary.DataAccess;
using SocialClassLibrary.Interfaces;
using SocialClassLibrary.Models;

namespace SocialClassLibrary.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
         public UserRepository(AppDbContext context)
         {
            _context = context;
         }

        public ICollection<User> GetUsers()
        {
            return _context.users.OrderBy(u => u.Id).ToList();
        }
    }
}
