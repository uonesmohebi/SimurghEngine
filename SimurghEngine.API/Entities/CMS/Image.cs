namespace SimurghEngine.API.Entities.CMS
{
    public class Image
    {
        [key]
        public int imageId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string alternateText { get; set; }
        public string desc { get; set; }
        public date createDate { get; set; }
        public date modifiedDate { get; set; }
        public bool isDeleted { get; set; }
        
        

        public list<AppUser> appUsers { get; set; }
        public AppUser creatorUserId { get; set; }
        public AppUser editorUserId { get; set; }
    }
}