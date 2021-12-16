namespace SimurghEngine.API.Entities.CMS
{
    public class KeyWord
    {
        [key]
        public int keyWordId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string desc { get; set; }
        public Date createDate { get; set; }
        public date modifiedDate { get; set; }
        public bool isDeleted { get; set; }


        public AppUser creatorUserId { get; set; }
        public AppUser editorUserId { get; set; }

        
    }
}