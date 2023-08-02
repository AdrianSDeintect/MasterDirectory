using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Catalogos.TipoCatalogosRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCatalogosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCatalogosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCatalogosDeleteHandler
{
    public TipoCatalogosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}