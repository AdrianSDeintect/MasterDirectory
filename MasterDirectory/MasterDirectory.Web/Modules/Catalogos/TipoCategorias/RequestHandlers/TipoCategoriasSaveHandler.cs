using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Catalogos.TipoCategoriasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Catalogos.TipoCategoriasRow;

namespace MasterDirectory.Catalogos;

public interface ITipoCategoriasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TipoCategoriasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITipoCategoriasSaveHandler
{
    public TipoCategoriasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}