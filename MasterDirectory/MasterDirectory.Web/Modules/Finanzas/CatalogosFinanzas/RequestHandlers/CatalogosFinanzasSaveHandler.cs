using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Finanzas.CatalogosFinanzasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Finanzas.CatalogosFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICatalogosFinanzasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosFinanzasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosFinanzasSaveHandler
{
    public CatalogosFinanzasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}