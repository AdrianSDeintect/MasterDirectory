using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.RecursosHumanos.CategoriaRHRow>;
using MyRow = MasterDirectory.RecursosHumanos.CategoriaRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICategoriaRHRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaRHRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaRHRetrieveHandler
{
    public CategoriaRHRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}