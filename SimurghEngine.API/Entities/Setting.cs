namespace SimurghEngine.API.Entities.CMS
{
    public class Setting
    {
        [key]
        public int settingId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string desc { get; set; }
        public string value { get; set; }
        

    }
}