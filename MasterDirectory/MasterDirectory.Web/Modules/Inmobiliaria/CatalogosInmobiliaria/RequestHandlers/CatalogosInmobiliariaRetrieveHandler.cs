using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow>;
using MyRow = MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICatalogosInmobiliariaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosInmobiliariaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosInmobiliariaRetrieveHandler
{
    public CatalogosInmobiliariaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}