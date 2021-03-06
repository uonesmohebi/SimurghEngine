/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:11:47
 * @modify date 2022-01-10 14:11:47
 * @desc [آبجکت مشخصات کاربران سیستم]
 */
using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.CMS.PageBuilder;

namespace SimurghEngine.API.Entities.CMS
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string? Alias { get; set; }
        public bool AccountIsActive { get; set; }
        public string? EmailAccount { get; set; }
        public string? EmailActivationCode { get; set; }
        public bool EmailIsActive { get; set; }
        public string? MobileNumber { get; set; }
        public string? MobileActivationCode { get; set; }
        public bool MobileIsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? LastLoginIp { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? AppUserImageId { get; set; }


        public virtual List<Role> Roles { get; set; } 
        public virtual List<Article> Articles { get; set; }
        public virtual List<Image>  Images { get; set; }
        public virtual List<PageFrame> PageFrames { get; set; }
    }
}