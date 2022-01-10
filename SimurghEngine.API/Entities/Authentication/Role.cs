/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:16:08
 * @modify date 2022-01-10 14:16:08
 * @desc [آبجکت رول های موجود در سیستم]
 */
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