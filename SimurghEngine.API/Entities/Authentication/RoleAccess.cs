namespace SimurghEngine.API.Entities.CMS
{
    public class RoleAccess
    {
        [key]
        public int roleAccessId { get; set; }
        public string titleEn { get; set; }
        public string titleFa { get; set; }
        
    }
}