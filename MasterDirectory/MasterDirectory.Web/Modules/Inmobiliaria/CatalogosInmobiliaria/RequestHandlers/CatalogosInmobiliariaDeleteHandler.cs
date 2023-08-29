using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Inmobiliaria.CatalogosInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICatalogosInmobiliariaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosInmobiliariaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosInmobiliariaDeleteHandler
{
    public CatalogosInmobiliariaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}