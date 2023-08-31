using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Tesoreria.CatalogosTesoreriaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Tesoreria.CatalogosTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICatalogosTesoreriaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTesoreriaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTesoreriaSaveHandler
{
    public CatalogosTesoreriaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}