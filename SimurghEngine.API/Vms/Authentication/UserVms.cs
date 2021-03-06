/**
 * @author [U.Mohebi]
 * @email [uones.mohebi@gmail.com]
 * @create date 2022-01-19 16:47:51
 * @modify date 2022-01-19 16:48:06
 * @desc [User DTO for get/send authorize data from/to UI]
 */

namespace SimurghEngine.API.Vms
{
    public class UserVm
    {
        public string username { get; set; }
        public string token { get; set; }
    }
}