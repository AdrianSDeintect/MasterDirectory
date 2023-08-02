using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Merchandising.CategoriaMerchandisingRow>;
using MyRow = MasterDirectory.Merchandising.CategoriaMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICategoriaMerchandisingListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMerchandisingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMerchandisingListHandler
{
    public CategoriaMerchandisingListHandler(IRequestContext context)
            : base(context)
    {
    }
}