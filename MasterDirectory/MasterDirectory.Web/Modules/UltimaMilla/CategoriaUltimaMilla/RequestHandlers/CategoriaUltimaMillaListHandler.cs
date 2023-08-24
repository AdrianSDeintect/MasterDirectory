using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow>;
using MyRow = MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICategoriaUltimaMillaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaUltimaMillaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaUltimaMillaListHandler
{
    public CategoriaUltimaMillaListHandler(IRequestContext context)
            : base(context)
    {
    }
}