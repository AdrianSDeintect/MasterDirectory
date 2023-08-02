using Serenity.Services;

namespace MasterDirectory.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}