using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Merchandising.CatMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CatMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatMerchandisingListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatMerchandisingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatMerchandisingListHandler
{
    public CatMerchandisingListHandler(IRequestContext context)
            : base(context)
    {
    }
}