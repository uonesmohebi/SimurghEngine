/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:19:36
 * @modify date 2022-01-10 14:19:36
 * @desc [آبجکت تنظیمات موجود در سایت]
 */
using System.ComponentModel.DataAnnotations;

namespace SimurghEngine.API.Entities.CMS
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        public string TitleEn { get; set; }
        public string Value { get; set; }
        public string? TitleFa { get; set; }
        public string? Desc { get; set; }
    }
}