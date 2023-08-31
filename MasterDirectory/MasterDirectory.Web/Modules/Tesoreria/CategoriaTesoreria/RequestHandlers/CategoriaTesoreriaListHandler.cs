using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Tesoreria.CategoriaTesoreriaRow>;
using MyRow = MasterDirectory.Tesoreria.CategoriaTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICategoriaTesoreriaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTesoreriaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTesoreriaListHandler
{
    public CategoriaTesoreriaListHandler(IRequestContext context)
            : base(context)
    {
    }
}