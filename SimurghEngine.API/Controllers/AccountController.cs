/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:12:29
 * @modify date 2022-01-10 14:12:29
 * @desc [کنترلر فعالیت های مربوط به کاربران سیستم]
 */
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Data;
using SimurghEngine.API.DTOs;
using SimurghEngine.API.Entities.CMS;
using SimurghEngine.API.Interfaces;
using SimurghEngine.API.Vms;
using System.Security.Cryptography;
using System.Text;

namespace SimurghEngine.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<UserVm>> Register(RegisterDto registerDto){

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
            return new UserVm{
                username= user.UserName,
                token= _tokenService.CreateToken(user)
            };
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserVm>> Login(LoginDto loginDto){
            var existUser = await _context.AppUsers.SingleOrDefaultAsync(u => u.UserName==loginDto.Username);

            if (existUser==null) return Unauthorized("Incorrect username or password!");

            using var hmac= new HMACSHA512(existUser.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i]!=existUser.PasswordHash[i]) return Unauthorized("Incorrect username or password!");
            }

            return new UserVm{
                username= existUser.UserName,
                token= _tokenService.CreateToken(existUser)
            };
        }





        private async Task<bool> UserExists(string username)
        {
            return await _context.AppUsers.AnyAsync(x => x.UserName==username.ToLower());
        }
    }
}