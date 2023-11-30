using ProjectDemo.DataAccess.Contracts;
using ProjectDemo.Models.Modules.User.Models;
using ProjectDemo.Services.Contracts;

namespace ProjectDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDataAccess _userDataAccess;

        public UserService(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public UserModel GetUserById(int id)
        {
            return _userDataAccess.GetUserById(id);
        }
    }
}
