using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Expansion.CatalogosExpansionRow>;
using MyRow = MasterDirectory.Expansion.CatalogosExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICatalogosExpansionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosExpansionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosExpansionRetrieveHandler
{
    public CatalogosExpansionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}