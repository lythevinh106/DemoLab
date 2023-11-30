using ProjectDemo.DataAccess.Contracts;
using ProjectDemo.DataAccess;
using ProjectDemo.Services.Contracts;
using ProjectDemo.Services;

namespace ProjectDemo.Configurations
{
    public static class ConfigurationExtension
    {
        public static void ConfigureRightStoreServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDataAccess, UserDataAccess>();
        }
    }
}
