using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Merchandising.CatalogosMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CatalogosMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatalogosMerchandisingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMerchandisingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMerchandisingRetrieveHandler
{
    public CatalogosMerchandisingRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}