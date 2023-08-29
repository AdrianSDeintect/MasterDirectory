using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow>;
using MyRow = MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICategoriaInmobiliariaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaInmobiliariaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaInmobiliariaListHandler
{
    public CategoriaInmobiliariaListHandler(IRequestContext context)
            : base(context)
    {
    }
}