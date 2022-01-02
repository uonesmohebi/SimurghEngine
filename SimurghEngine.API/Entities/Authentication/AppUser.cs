using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string? Alias { get; set; }
        public bool AccountIsActive { get; set; }
        public string EmailAccount { get; set; }
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
        public int AppUserImageId { get; set; }


        public virtual List<Role> Roles { get; set; }
        public virtual List<Article> ArticleCreators { get; set; }
        public virtual List<Article> ArticleEditors { get; set; }
        public virtual List<ArticleGroup> ArticleGroupCreators { get; set; }
        public virtual List<ArticleGroup> ArticleGroupEditors { get; set; }
        public virtual List<KeyWord> KeyWordCreators { get; set; }
        public virtual List<KeyWord> KeyWordEditors { get; set; }
        public virtual List<Image>  ImageCreators { get; set; }
        public virtual List<Image>  ImageEditors { get; set; }
        public virtual List<ImageGroup> ImageGroupCreators { get; set; }
        public virtual List<ImageGroup> ImageGroupEditors { get; set; }
    }
}