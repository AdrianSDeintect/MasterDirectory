using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Operaciones.CategoriaOperacionesRow>;
using MyRow = MasterDirectory.Operaciones.CategoriaOperacionesRow;

namespace MasterDirectory.Operaciones;

public interface ICategoriaOperacionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaOperacionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaOperacionesRetrieveHandler
{
    public CategoriaOperacionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}