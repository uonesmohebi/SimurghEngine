using SimurghEngine.API.Entities.CMS;

namespace SimurghEngine.API.Entities.Authentication
{
    public class BaseObjectData
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int EditorUserId { get; set; }
    }
}