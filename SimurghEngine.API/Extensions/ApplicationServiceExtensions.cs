/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-19 16:19:09
 * @modify date 2022-01-19 16:19:09
 * @desc [This class is extension method for ICollectionService+ApplicationServices]
 */
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Data;
using SimurghEngine.API.Interfaces;
using SimurghEngine.API.Services;

namespace SimurghEngine.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}