using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Catalogos.TipoCatalogosRow>;
using MyRow = MasterDirectory.Catalogos.TipoCatalogosRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCatalogosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCatalogosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCatalogosRetrieveHandler
{
    public TipoCatalogosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}