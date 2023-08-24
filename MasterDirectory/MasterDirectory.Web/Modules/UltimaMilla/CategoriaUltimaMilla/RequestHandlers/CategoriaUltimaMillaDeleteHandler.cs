using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICategoriaUltimaMillaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaUltimaMillaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaUltimaMillaDeleteHandler
{
    public CategoriaUltimaMillaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}