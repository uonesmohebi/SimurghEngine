namespace SimurghEngine.API.Entities.CMS
{
    public class Role
    {
        [key]
        public int roleId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string desc { get; set; }
        


        public list<AppUser> appusers { get; set; }
    }
}