using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class Article: BaseObjectData
    {
        [Key]
        public int ArticleId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? Content { get; set; }
        public string? MetaDesc { get; set; }    
        public string? Summary { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<KeyWord> KeyWords { get; set; }
        public virtual List<ArticleGroup> ArticleGroups { get; set; }


        public virtual AppUser AppUser { get; set; }
    }
}