using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.TecnologiasInformacion.CategoriaTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICategoriaTIDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTIDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTIDeleteHandler
{
    public CategoriaTIDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}