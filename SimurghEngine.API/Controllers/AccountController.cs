using Microsoft.AspNetCore.Mvc;
using SimurghEngine.API.Data;
using SimurghEngine.API.Entities.CMS;
using System.Security.Cryptography;
using System.Text;

namespace SimurghEngine.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(string username, string password){
            using var hmac = new HMACSHA512();
            var user= new AppUser{
                UserName=username,
                AccountIsActive=true,
                EmailIsActive=false,
                MobileIsActive=false,
                CreateDate=DateTime.Now,
                PasswordHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt= hmac.Key
            };

            _context.AppUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}