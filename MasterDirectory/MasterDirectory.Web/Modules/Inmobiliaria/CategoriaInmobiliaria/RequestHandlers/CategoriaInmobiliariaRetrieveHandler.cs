using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow>;
using MyRow = MasterDirectory.Inmobiliaria.CategoriaInmobiliariaRow;

namespace MasterDirectory.Inmobiliaria;

public interface ICategoriaInmobiliariaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaInmobiliariaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaInmobiliariaRetrieveHandler
{
    public CategoriaInmobiliariaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}