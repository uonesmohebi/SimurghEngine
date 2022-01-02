using SimurghEngine.API.Entities.CMS;

namespace SimurghEngine.API.Entities.Authentication
{
    public class BaseUserData
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        

        public virtual int  CreatorUserId { get; set; }
        public virtual int?  EditorUserId { get; set; }
        public virtual AppUser CreatorUser { get; set; }
        public virtual AppUser? EditorUser { get; set; }
    }
}