namespace SimurghEngine.API.Entities.CMS
{
    public class AppUser
    {
        [key]
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
        public date createDate { get; set; }
        public date lastLoginDate { get; set; }
        public string lastLoginIp { get; set; }
        

        public image appUserImage { get; set; }
        public Role role { get; set; }
        public list<Article> articles { get; set; }
        public list<KeyWord> keyWords { get; set; }
        public list<Image>  images { get; set; }
        public list<ArticleGroup> articleGroups { get; set; }
        public list<ImageGroup> imageGroups { get; set; }


    }
}