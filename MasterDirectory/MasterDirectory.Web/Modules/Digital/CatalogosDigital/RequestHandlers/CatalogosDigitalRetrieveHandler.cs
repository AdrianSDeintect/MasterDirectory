using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Digital.CatalogosDigitalRow>;
using MyRow = MasterDirectory.Digital.CatalogosDigitalRow;

namespace MasterDirectory.Digital;

public interface ICatalogosDigitalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosDigitalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosDigitalRetrieveHandler
{
    public CatalogosDigitalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}