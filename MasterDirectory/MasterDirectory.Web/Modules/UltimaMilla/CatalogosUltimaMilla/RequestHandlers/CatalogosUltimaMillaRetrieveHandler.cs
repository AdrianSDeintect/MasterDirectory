using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow>;
using MyRow = MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICatalogosUltimaMillaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosUltimaMillaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosUltimaMillaRetrieveHandler
{
    public CatalogosUltimaMillaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}