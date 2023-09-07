using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceRow;

namespace MasterDirectory.MarketIntelligence;

public interface ICategoriaMarketIntelligenceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMarketIntelligenceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMarketIntelligenceDeleteHandler
{
    public CategoriaMarketIntelligenceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}