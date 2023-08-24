using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Finanzas.CatalogosFinanzasRow>;
using MyRow = MasterDirectory.Finanzas.CatalogosFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICatalogosFinanzasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosFinanzasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosFinanzasListHandler
{
    public CatalogosFinanzasListHandler(IRequestContext context)
            : base(context)
    {
    }
}