using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow>;
using MyRow = MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICatalogosMarketIntelligenceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMarketIntelligenceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMarketIntelligenceListHandler
{
    public CatalogosMarketIntelligenceListHandler(IRequestContext context)
            : base(context)
    {
    }
}