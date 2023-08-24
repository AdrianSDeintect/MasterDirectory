using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Finanzas.CatalogosFinanzasRow>;
using MyRow = MasterDirectory.Finanzas.CatalogosFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICatalogosFinanzasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosFinanzasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosFinanzasRetrieveHandler
{
    public CatalogosFinanzasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}