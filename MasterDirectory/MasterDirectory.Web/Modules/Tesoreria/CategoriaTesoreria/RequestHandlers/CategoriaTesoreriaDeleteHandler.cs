using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Tesoreria.CategoriaTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICategoriaTesoreriaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTesoreriaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTesoreriaDeleteHandler
{
    public CategoriaTesoreriaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}