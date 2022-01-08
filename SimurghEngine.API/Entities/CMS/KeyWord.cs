using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class KeyWord
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