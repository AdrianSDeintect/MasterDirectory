using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Finanzas.CategoriaFinanzasRow>;
using MyRow = MasterDirectory.Finanzas.CategoriaFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICategoriaFinanzasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaFinanzasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaFinanzasListHandler
{
    public CategoriaFinanzasListHandler(IRequestContext context)
            : base(context)
    {
    }
}