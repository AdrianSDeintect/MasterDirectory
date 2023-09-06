using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Digital.CatalogosDigitalRow>;
using MyRow = MasterDirectory.Digital.CatalogosDigitalRow;

namespace MasterDirectory.Digital;

public interface ICatalogosDigitalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosDigitalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosDigitalListHandler
{
    public CatalogosDigitalListHandler(IRequestContext context)
            : base(context)
    {
    }
}