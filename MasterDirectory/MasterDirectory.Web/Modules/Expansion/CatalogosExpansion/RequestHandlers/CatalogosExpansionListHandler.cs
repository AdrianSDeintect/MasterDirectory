using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Expansion.CatalogosExpansionRow>;
using MyRow = MasterDirectory.Expansion.CatalogosExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICatalogosExpansionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosExpansionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosExpansionListHandler
{
    public CatalogosExpansionListHandler(IRequestContext context)
            : base(context)
    {
    }
}