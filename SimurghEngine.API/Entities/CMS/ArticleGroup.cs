using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class ArticleGroup 
    {
        [Key]
        public int articleGroupId { get; set; }
        public int parentGroupId { get; set; }
        public string titleEn { get; set; }
        public string? titleFa { get; set; }
        public string? desc { get; set; }
        public DateTime createDate { get; set; }
        public DateTime? modifiedDate { get; set; }


        public virtual AppUser creatorUserId { get; set; }
        public virtual AppUser editorUserId { get; set; }

    }
}