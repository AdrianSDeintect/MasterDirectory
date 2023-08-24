using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Finanzas.CategoriaFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICategoriaFinanzasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaFinanzasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaFinanzasDeleteHandler
{
    public CategoriaFinanzasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}