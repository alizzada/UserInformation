using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation.Business.Abstract;
using UserInformation.DataAccess.Abstract;
using UserInformation.DataAccess.Concrete;
using UserInformation.Entities;

namespace UserInformation.Business
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
