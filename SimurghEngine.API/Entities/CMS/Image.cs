using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class Image: BaseObjectData
    {
        [Key]
        public int ImageId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? AlternateText { get; set; }
        public string? Desc { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<ImageGroup> ImageGroups { get; set; }


        public virtual AppUser AppUser { get; set; }
    }
}