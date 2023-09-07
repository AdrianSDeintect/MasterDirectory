using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow>;
using MyRow = MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICategoriaMarketIntelligenceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMarketIntelligenceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMarketIntelligenceListHandler
{
    public CategoriaMarketIntelligenceListHandler(IRequestContext context)
            : base(context)
    {
    }
}