/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-10 14:15:13
 * @modify date 2022-01-10 14:15:13
 * @desc [کلاس مشخصات پایه آبجکت های کاربر]
 */

namespace SimurghEngine.API.Entities.Authentication
{
    public class BaseObjectData
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int EditorUserId { get; set; }
    }
}