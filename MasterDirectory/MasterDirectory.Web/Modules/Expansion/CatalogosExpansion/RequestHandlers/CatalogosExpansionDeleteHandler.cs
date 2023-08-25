using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Expansion.CatalogosExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICatalogosExpansionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosExpansionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosExpansionDeleteHandler
{
    public CatalogosExpansionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}