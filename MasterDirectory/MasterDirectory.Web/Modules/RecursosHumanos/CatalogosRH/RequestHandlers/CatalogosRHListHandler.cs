using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.RecursosHumanos.CatalogosRHRow>;
using MyRow = MasterDirectory.RecursosHumanos.CatalogosRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICatalogosRHListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosRHListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosRHListHandler
{
    public CatalogosRHListHandler(IRequestContext context)
            : base(context)
    {
    }
}