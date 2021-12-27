using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class RoleAccess
    {
        [Key]
        public int roleAccessId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        
    }
}