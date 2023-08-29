using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Operaciones.CatalogosOperacionesRow>;
using MyRow = MasterDirectory.Operaciones.CatalogosOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICatalogosOperacionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosOperacionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosOperacionesRetrieveHandler
{
    public CatalogosOperacionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}