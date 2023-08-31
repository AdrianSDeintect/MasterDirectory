using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Tesoreria.CategoriaTesoreriaRow>;
using MyRow = MasterDirectory.Tesoreria.CategoriaTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICategoriaTesoreriaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTesoreriaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTesoreriaRetrieveHandler
{
    public CategoriaTesoreriaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}