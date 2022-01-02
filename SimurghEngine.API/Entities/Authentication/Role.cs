using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? Desc { get; set; }
        

        public virtual List<RoleAccess> RoleAccesses { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
    }
}