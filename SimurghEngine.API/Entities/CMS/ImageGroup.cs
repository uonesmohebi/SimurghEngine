namespace SimurghEngine.API.Entities.CMS
{
    public class ImageGroup
    {
        [key]
        public int imageGroupId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string desc { get; set; }
        public date createDate { get; set; }
        public string modifiedDate { get; set; }


        public AppUser creatorUserId { get; set; }
        public AppUser editorUserId { get; set; }
        

    }
}