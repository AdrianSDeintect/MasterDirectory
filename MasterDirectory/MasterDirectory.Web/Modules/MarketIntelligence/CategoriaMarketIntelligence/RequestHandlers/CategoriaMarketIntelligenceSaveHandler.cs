using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICategoriaMarketIntelligenceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMarketIntelligenceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMarketIntelligenceSaveHandler
{
    public CategoriaMarketIntelligenceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}