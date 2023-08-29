using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Operaciones.CatalogosOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICatalogosOperacionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosOperacionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosOperacionesDeleteHandler
{
    public CatalogosOperacionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}