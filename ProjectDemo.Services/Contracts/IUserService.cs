using ProjectDemo.Models.Modules.User.Models;

namespace ProjectDemo.Services.Contracts
{
    public interface IUserService
    {
        public UserModel GetUserById(int id);
    }
}
