using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Expansion.CategoriaExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICategoriaExpansionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaExpansionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaExpansionDeleteHandler
{
    public CategoriaExpansionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}