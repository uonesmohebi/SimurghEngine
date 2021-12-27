using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class Image
    {
        [Key]
        public int imageId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string alternateText { get; set; }
        public string desc { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isDeleted { get; set; }
        
        

        public List<AppUser> appUsers { get; set; }
        public AppUser creatorUserId { get; set; }
        public AppUser editorUserId { get; set; }
    }
}