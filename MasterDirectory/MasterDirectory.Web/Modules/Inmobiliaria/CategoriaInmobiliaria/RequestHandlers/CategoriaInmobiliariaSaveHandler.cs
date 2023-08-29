using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICategoriaInmobiliariaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaInmobiliariaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaInmobiliariaSaveHandler
{
    public CategoriaInmobiliariaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}