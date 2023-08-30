using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.RecursosHumanos.CategoriaRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICategoriaRHDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaRHDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaRHDeleteHandler
{
    public CategoriaRHDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}