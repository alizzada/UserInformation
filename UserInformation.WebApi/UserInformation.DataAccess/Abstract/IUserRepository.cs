using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformation.Entities;

namespace UserInformation.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
