using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.RecursosHumanos.CategoriaRHRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.RecursosHumanos.CategoriaRHRow;

namespace MasterDirectory.RecursosHumanos;

public interface ICategoriaRHSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaRHSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaRHSaveHandler
{
    public CategoriaRHSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}