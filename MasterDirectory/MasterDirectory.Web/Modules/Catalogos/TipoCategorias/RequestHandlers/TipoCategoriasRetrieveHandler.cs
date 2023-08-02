using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Catalogos.TipoCategoriasRow>;
using MyRow = MasterDirectory.Catalogos.TipoCategoriasRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCategoriasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCategoriasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCategoriasRetrieveHandler
{
    public TipoCategoriasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}