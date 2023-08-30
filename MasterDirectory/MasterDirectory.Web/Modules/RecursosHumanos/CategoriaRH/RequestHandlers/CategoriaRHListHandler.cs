using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.RecursosHumanos.CategoriaRHRow>;
using MyRow = MasterDirectory.RecursosHumanos.CategoriaRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICategoriaRHListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaRHListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaRHListHandler
{
    public CategoriaRHListHandler(IRequestContext context)
            : base(context)
    {
    }
}