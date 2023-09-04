using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Comerciales.CatalogosComercialesRow>;
using MyRow = MasterDirectory.Comerciales.CatalogosComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICatalogosComercialesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosComercialesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosComercialesListHandler
{
    public CatalogosComercialesListHandler(IRequestContext context)
            : base(context)
    {
    }
}