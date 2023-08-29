using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICatalogosInmobiliariaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosInmobiliariaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosInmobiliariaSaveHandler
{
    public CatalogosInmobiliariaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}