using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.TecnologiasInformacion.CatalogosTIRow>;
using MyRow = MasterDirectory.TecnologiasInformacion.CatalogosTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICatalogosTIListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTIListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTIListHandler
{
    public CatalogosTIListHandler(IRequestContext context)
            : base(context)
    {
    }
}