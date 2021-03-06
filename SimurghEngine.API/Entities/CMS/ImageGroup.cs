/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:18:47
 * @modify date 2022-01-10 14:18:47
 * @desc [آبجکت دسته های تصاویر موجود در سیستم]
 */
using System.ComponentModel.DataAnnotations;
using SimurghEngine.API.Entities.Authentication;

namespace SimurghEngine.API.Entities.CMS
{
    public class ImageGroup: BaseObjectData
    {
        [Key]
        public int ImageGroupId { get; set; }
        public int? ParentGroupId { get; set; }
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public string? Desc { get; set; }


        public virtual List<Image> Images { get; set; }
    }
}