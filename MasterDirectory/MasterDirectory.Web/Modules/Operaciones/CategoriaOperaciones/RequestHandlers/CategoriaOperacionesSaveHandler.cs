using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Operaciones.CategoriaOperacionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Operaciones.CategoriaOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICategoriaOperacionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaOperacionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaOperacionesSaveHandler
{
    public CategoriaOperacionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}