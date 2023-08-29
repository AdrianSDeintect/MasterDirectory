using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Operaciones.CatalogosOperacionesRow>;
using MyRow = MasterDirectory.Operaciones.CatalogosOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICatalogosOperacionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosOperacionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosOperacionesListHandler
{
    public CatalogosOperacionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}