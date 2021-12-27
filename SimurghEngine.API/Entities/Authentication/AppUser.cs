using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class AppUser
    {
        [Key]
        public int appUserId { get; set; }
        public string userName { get; set; }
        public string alias { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool activeAccount { get; set; }
        public string emailAccount { get; set; }
        public bool emailIsActive { get; set; }
        public string mobileNumber { get; set; }
        public string mobileActivation { get; set; }
        public bool mobileIsActive { get; set; }
        public DateTime createDate { get; set; }
        public DateTime lastLoginDate { get; set; }
        public string lastLoginIp { get; set; }
        

        public Image appUserImage { get; set; }
        public Role role { get; set; }
        public List<Article> articles { get; set; }
        public List<KeyWord> keyWords { get; set; }
        public List<Image>  images { get; set; }
        public List<ArticleGroup> articleGroups { get; set; }
        public List<ImageGroup> imageGroups { get; set; }


    }
}