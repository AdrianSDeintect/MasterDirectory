using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Merchandising.CatMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CatMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatMerchandisingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatMerchandisingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatMerchandisingRetrieveHandler
{
    public CatMerchandisingRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}