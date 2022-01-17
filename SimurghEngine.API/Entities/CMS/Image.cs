/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:18:22
 * @modify date 2022-01-10 14:18:22
 * @desc [آبجکت تصاویر موجود در سیستم]
 */
using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;
using SimurghEngine.API.Entities.CMS.PageBuilder;

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
        public virtual RowBox RowBox { get; set; }
    }
}