/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:12:29
 * @modify date 2022-01-10 14:12:29
 * @desc [کنترلر فعالیت های مربوط به کاربران سیستم]
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Data;
using SimurghEngine.API.DTOs;
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
        public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto){

            if (await UserExists(registerDto.Username)) return BadRequest("This username already exist, please try with another.");

            using var hmac = new HMACSHA512();
            var user= new AppUser{
                UserName=registerDto.Username.ToLower(),
                AccountIsActive=true,
                EmailIsActive=false,
                MobileIsActive=false,
                CreateDate=DateTime.Now,
                PasswordHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt= hmac.Key
            };

            _context.AppUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AppUser>> Login(string Username, string Password){
            
        }





        private async Task<bool> UserExists(string username)
        {
            return await _context.AppUsers.AnyAsync(x => x.UserName==username.ToLower());
        }
    }
}