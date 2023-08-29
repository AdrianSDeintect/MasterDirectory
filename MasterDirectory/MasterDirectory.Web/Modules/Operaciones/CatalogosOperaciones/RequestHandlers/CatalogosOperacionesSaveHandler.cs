using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Operaciones.CatalogosOperacionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Operaciones.CatalogosOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICatalogosOperacionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosOperacionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosOperacionesSaveHandler
{
    public CatalogosOperacionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}