using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Catalogos.TipoCatalogosRow>;
using MyRow = MasterDirectory.Catalogos.TipoCatalogosRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCatalogosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCatalogosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCatalogosListHandler
{
    public TipoCatalogosListHandler(IRequestContext context)
            : base(context)
    {
    }
}