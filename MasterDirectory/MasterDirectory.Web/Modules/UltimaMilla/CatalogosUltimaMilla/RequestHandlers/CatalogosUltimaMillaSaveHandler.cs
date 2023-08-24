using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.UltimaMilla.CatalogosUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICatalogosUltimaMillaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosUltimaMillaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosUltimaMillaSaveHandler
{
    public CatalogosUltimaMillaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}