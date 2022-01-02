using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class ArticleGroup : BaseUserData
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