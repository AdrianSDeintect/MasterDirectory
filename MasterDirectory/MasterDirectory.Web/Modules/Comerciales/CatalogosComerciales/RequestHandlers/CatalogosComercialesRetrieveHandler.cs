using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Comerciales.CatalogosComercialesRow>;
using MyRow = MasterDirectory.Comerciales.CatalogosComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICatalogosComercialesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosComercialesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosComercialesRetrieveHandler
{
    public CatalogosComercialesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}