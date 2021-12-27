using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class Article
    {
        [Key]
        public int articleId { get; set; }
        public string titleEn { get; set; }
        public string? titleFa { get; set; }
        public string? content { get; set; }
        public string? metaDesc { get; set; }    
        public string? summary { get; set; }
        public DateTime createDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool isDeleted { get; set; }



        public virtual AppUser creatorUserId { get; set; }
        public virtual AppUser? editorUserId { get; set; }

    }
}