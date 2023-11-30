using ProjectDemo.Models.Modules.User.Models;

namespace ProjectDemo.DataAccess.Contracts
{
    public interface IUserDataAccess
    {
        public UserModel GetUserById(int id);
    }
}
