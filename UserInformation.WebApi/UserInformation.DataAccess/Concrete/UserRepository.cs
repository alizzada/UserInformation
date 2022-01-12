using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation.DataAccess.Abstract;
using UserInformation.Entities;

namespace UserInformation.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly UserInformationDbContext _context;

        public UserRepository(UserInformationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {

            return  _context.Users.ToList();
            
        }
    }
}
