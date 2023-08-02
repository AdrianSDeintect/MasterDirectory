using Serenity.Services;
using MyRequest = MasterDirectory.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Administration.UserRow>;
using MyRow = MasterDirectory.Administration.UserRow;

namespace MasterDirectory.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}