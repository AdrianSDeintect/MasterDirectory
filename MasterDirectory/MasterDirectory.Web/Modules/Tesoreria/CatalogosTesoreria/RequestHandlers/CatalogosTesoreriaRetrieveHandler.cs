using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Tesoreria.CatalogosTesoreriaRow>;
using MyRow = MasterDirectory.Tesoreria.CatalogosTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICatalogosTesoreriaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTesoreriaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTesoreriaRetrieveHandler
{
    public CatalogosTesoreriaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}