using ProjectDemo.DataAccess.Contracts;
using ProjectDemo.Models;
using ProjectDemo.Models.Modules.User.Models;

namespace ProjectDemo.DataAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly ProjectDemoDbContext _dbContext;

        public UserDataAccess(ProjectDemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserModel GetUserById(int id)
        {
            var userModel = _dbContext.Users.Where(x => x.Id == id).Select(x => new UserModel()
            {
                Name = x.Name,
                UserName = x.UserName
            }).FirstOrDefault();

            return userModel;
        }
    }
}
