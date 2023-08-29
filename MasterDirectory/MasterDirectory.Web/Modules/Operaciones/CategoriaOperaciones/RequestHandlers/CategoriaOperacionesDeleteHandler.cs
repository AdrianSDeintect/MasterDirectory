using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Operaciones.CategoriaOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICategoriaOperacionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaOperacionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaOperacionesDeleteHandler
{
    public CategoriaOperacionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}