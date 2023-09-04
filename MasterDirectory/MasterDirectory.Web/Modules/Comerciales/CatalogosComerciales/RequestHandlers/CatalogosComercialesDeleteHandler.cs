using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Comerciales.CatalogosComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICatalogosComercialesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosComercialesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosComercialesDeleteHandler
{
    public CatalogosComercialesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}