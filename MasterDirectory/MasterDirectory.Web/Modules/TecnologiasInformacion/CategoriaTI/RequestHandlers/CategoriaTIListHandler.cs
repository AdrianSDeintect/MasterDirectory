using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.TecnologiasInformacion.CategoriaTIRow>;
using MyRow = MasterDirectory.TecnologiasInformacion.CategoriaTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICategoriaTIListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTIListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTIListHandler
{
    public CategoriaTIListHandler(IRequestContext context)
            : base(context)
    {
    }
}