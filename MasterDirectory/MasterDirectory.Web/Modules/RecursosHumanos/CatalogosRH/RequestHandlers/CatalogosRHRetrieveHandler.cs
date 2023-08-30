using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.RecursosHumanos.CatalogosRHRow>;
using MyRow = MasterDirectory.RecursosHumanos.CatalogosRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICatalogosRHRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosRHRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosRHRetrieveHandler
{
    public CatalogosRHRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}