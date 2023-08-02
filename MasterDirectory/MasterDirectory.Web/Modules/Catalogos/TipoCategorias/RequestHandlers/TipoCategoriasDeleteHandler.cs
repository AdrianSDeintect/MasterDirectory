using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Catalogos.TipoCategoriasRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCategoriasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCategoriasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCategoriasDeleteHandler
{
    public TipoCategoriasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}