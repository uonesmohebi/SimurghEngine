/**
* @author [U.Mohebi]
* @email [uones.mohebi@gmail.com]
* @create date 2022-01-10 14:11:02
* @modify date 2022-01-10 14:11:02
* @desc [Register DTO for get/send Register data from/to UI]
*/
using System.ComponentModel.DataAnnotations;
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