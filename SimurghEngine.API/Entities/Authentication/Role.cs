using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class Role
    {
        [Key]
        public int roleId { get; set; }
        public string titleEn { get; set; }
        public string? titleFa { get; set; }
        public string? desc { get; set; }
        


        public virtual List<AppUser> appusers { get; set; }
    }
}