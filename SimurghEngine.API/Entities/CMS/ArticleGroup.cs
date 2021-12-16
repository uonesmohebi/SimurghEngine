namespace SimurghEngine.API.Entities.CMS
{
    public class ArticleGroup 
    {
        [key]
        public int articleGroupId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string desc { get; set; }
        public date createDate { get; set; }
        public date modifiedDate { get; set; }


        public AppUser creatorUserId { get; set; }
        public AppUser editorUserId { get; set; }

    }
}