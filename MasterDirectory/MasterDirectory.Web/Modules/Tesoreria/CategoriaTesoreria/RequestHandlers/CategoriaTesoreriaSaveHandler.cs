using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Tesoreria.CategoriaTesoreriaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Tesoreria.CategoriaTesoreriaRow;

namespace MasterDirectory.Tesoreria;

public interface ICategoriaTesoreriaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTesoreriaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTesoreriaSaveHandler
{
    public CategoriaTesoreriaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}