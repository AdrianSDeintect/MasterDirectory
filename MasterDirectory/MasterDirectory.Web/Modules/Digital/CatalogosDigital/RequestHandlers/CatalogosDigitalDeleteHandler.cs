using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Digital.CatalogosDigitalRow;

namespace MasterDirectory.Digital;

public interface ICatalogosDigitalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosDigitalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosDigitalDeleteHandler
{
    public CatalogosDigitalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}