using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Consultorios.CatalogosConsultoriosRow>;
using MyRow = MasterDirectory.Consultorios.CatalogosConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICatalogosConsultoriosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosConsultoriosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosConsultoriosListHandler
{
    public CatalogosConsultoriosListHandler(IRequestContext context)
            : base(context)
    {
    }
}