using OperationsPortal.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OperationsPortal.Data.Repositories
{
    public class UserRepository
    {
        private readonly OperationsPortalDbEntities1 _context;

        public UserRepository()
        {
            _context = new OperationsPortalDbEntities1();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.UserId == id);
        }
    }
}                           