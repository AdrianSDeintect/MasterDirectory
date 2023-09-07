using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow>;
using MyRow = MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICategoriaMarketIntelligenceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMarketIntelligenceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMarketIntelligenceRetrieveHandler
{
    public CategoriaMarketIntelligenceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}