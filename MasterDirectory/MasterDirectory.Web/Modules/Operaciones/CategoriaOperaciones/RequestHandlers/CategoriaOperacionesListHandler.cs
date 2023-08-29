using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Operaciones.CategoriaOperacionesRow>;
using MyRow = MasterDirectory.Operaciones.CategoriaOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICategoriaOperacionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaOperacionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaOperacionesListHandler
{
    public CategoriaOperacionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}