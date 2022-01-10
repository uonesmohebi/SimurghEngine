/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:16:37
 * @modify date 2022-01-10 14:16:37
 * @desc [آبجکت گروه دسترسی که می تواند به رول اختصاص یابد]
 */
using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class RoleAccess
    {
        [Key]
        public int roleAccessId { get; set; }
        public string titleEn { get; set; }
        public string? titleFa { get; set; }
        public string? desc { get; set; }
        
        public virtual List<Role> Roles { get; set; }
    }
}