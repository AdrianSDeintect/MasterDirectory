using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow>;
using MyRow = MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICatalogosUltimaMillaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosUltimaMillaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosUltimaMillaListHandler
{
    public CatalogosUltimaMillaListHandler(IRequestContext context)
            : base(context)
    {
    }
}