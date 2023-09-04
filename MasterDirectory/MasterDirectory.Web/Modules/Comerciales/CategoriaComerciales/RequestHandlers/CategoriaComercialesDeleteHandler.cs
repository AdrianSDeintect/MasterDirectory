using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Comerciales.CategoriaComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICategoriaComercialesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaComercialesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaComercialesDeleteHandler
{
    public CategoriaComercialesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}