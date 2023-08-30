using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.RecursosHumanos.CatalogosRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICatalogosRHDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosRHDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosRHDeleteHandler
{
    public CatalogosRHDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}