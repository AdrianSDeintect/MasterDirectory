using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Tesoreria.CatalogosTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICatalogosTesoreriaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTesoreriaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTesoreriaDeleteHandler
{
    public CatalogosTesoreriaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}