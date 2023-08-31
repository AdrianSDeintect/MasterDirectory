using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Tesoreria.CatalogosTesoreriaRow>;
using MyRow = MasterDirectory.Tesoreria.CatalogosTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICatalogosTesoreriaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTesoreriaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTesoreriaListHandler
{
    public CatalogosTesoreriaListHandler(IRequestContext context)
            : base(context)
    {
    }
}