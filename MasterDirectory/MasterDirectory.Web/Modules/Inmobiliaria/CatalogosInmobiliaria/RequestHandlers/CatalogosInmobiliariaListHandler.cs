using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow>;
using MyRow = MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICatalogosInmobiliariaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosInmobiliariaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosInmobiliariaListHandler
{
    public CatalogosInmobiliariaListHandler(IRequestContext context)
            : base(context)
    {
    }
}