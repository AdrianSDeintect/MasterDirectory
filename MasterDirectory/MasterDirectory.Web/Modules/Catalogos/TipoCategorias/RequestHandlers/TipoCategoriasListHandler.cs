using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Catalogos.TipoCategoriasRow>;
using MyRow = MasterDirectory.Catalogos.TipoCategoriasRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCategoriasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCategoriasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCategoriasListHandler
{
    public TipoCategoriasListHandler(IRequestContext context)
            : base(context)
    {
    }
}