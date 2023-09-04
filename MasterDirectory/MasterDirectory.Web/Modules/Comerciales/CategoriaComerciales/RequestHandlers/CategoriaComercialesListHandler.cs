using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Comerciales.CategoriaComercialesRow>;
using MyRow = MasterDirectory.Comerciales.CategoriaComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICategoriaComercialesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaComercialesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaComercialesListHandler
{
    public CategoriaComercialesListHandler(IRequestContext context)
            : base(context)
    {
    }
}