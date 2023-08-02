using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Merchandising.CategoriaMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CategoriaMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICategoriaMerchandisingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMerchandisingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMerchandisingRetrieveHandler
{
    public CategoriaMerchandisingRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}