using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Comerciales.CategoriaComercialesRow>;
using MyRow = MasterDirectory.Comerciales.CategoriaComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICategoriaComercialesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaComercialesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaComercialesRetrieveHandler
{
    public CategoriaComercialesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}