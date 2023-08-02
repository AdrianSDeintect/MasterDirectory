using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Merchandising.CatalogosMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CatalogosMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatalogosMerchandisingListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMerchandisingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMerchandisingListHandler
{
    public CatalogosMerchandisingListHandler(IRequestContext context)
            : base(context)
    {
    }
}