using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Consultorios.CatalogosConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICatalogosConsultoriosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosConsultoriosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosConsultoriosDeleteHandler
{
    public CatalogosConsultoriosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}