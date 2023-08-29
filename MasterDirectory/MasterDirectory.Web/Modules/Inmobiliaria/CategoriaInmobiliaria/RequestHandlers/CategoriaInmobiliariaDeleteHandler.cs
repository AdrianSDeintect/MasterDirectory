using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICategoriaInmobiliariaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaInmobiliariaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaInmobiliariaDeleteHandler
{
    public CategoriaInmobiliariaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}