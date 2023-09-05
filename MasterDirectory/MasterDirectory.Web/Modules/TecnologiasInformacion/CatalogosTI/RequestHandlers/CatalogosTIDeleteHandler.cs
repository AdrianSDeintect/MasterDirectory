using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.TecnologiasInformacion.CatalogosTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICatalogosTIDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTIDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTIDeleteHandler
{
    public CatalogosTIDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}