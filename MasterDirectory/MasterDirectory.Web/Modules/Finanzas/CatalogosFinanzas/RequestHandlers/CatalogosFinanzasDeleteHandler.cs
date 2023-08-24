using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Finanzas.CatalogosFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICatalogosFinanzasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosFinanzasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosFinanzasDeleteHandler
{
    public CatalogosFinanzasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}