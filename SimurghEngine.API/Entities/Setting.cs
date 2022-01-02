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