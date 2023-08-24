using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICatalogosUltimaMillaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosUltimaMillaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosUltimaMillaDeleteHandler
{
    public CatalogosUltimaMillaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}