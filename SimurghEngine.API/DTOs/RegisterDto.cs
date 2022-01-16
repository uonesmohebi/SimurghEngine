
using System.ComponentModel.DataAnnotations;
/**
* @author [U.Mohebi]
* @email [uones.mohebi@gmail.com]
* @create date 2022-01-10 14:11:02
* @modify date 2022-01-10 14:11:02
* @desc [آبجکت دریافتی از کاربر هنگام ثبت نام]
*/
namespace SimurghEngine.API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}