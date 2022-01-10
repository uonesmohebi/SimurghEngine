/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:17:58
 * @modify date 2022-01-10 14:17:58
 * @desc [آبجکت دسته های نوشته های سیستم]
 */
using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class ArticleGroup: BaseObjectData
    {
        [Key]
        public int ArticleGroupId { get; set; }
        public int ParentGroupId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? Desc { get; set; }


        public virtual List<Article> Articles { get; set; }
    }
}