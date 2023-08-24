using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Consultorios.CatalogosConsultoriosRow>;
using MyRow = MasterDirectory.Consultorios.CatalogosConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICatalogosConsultoriosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosConsultoriosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosConsultoriosRetrieveHandler
{
    public CatalogosConsultoriosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}