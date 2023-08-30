using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.RecursosHumanos.CatalogosRHRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.RecursosHumanos.CatalogosRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICatalogosRHSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosRHSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosRHSaveHandler
{
    public CatalogosRHSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}