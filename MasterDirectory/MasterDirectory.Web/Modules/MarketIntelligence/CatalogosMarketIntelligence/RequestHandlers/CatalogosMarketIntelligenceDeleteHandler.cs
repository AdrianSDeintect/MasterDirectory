using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICatalogosMarketIntelligenceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMarketIntelligenceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMarketIntelligenceDeleteHandler
{
    public CatalogosMarketIntelligenceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}