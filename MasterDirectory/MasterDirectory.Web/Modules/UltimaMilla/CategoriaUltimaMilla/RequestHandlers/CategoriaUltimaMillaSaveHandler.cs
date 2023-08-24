using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICategoriaUltimaMillaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaUltimaMillaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaUltimaMillaSaveHandler
{
    public CategoriaUltimaMillaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}