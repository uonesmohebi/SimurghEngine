namespace SimurghEngine.API.Entities.CMS
{
    public class Article
    {
        [key]
        public int articleId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        public string content { get; set; }
        public string metaDesc { get; set; }    
        public string summary { get; set; }
        public date createDate { get; set; }
        public date modifiedDate { get; set; }
        public bool isDeleted { get; set; }

    }
}