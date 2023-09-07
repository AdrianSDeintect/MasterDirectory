using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow>;
using MyRow = MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICatalogosMarketIntelligenceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMarketIntelligenceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMarketIntelligenceRetrieveHandler
{
    public CatalogosMarketIntelligenceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}