using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICatalogosMarketIntelligenceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMarketIntelligenceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMarketIntelligenceSaveHandler
{
    public CatalogosMarketIntelligenceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}