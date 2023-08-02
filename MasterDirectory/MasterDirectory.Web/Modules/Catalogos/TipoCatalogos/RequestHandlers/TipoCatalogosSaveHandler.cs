using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Catalogos.TipoCatalogosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Catalogos.TipoCatalogosRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCatalogosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCatalogosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCatalogosSaveHandler
{
    public TipoCatalogosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}