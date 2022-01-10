/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:19:15
 * @modify date 2022-01-10 14:19:15
 * @desc [آبجکت کلمات کلیدی موجود در سیستم]
 */
using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class KeyWord: BaseObjectData
    {
        [Key]
        public int KeyWordId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? Desc { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<Article> Articles { get; set; }
    }
}