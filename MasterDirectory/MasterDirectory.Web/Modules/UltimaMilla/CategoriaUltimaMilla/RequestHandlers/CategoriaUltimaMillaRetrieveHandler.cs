using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow>;
using MyRow = MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow;

namespace MasterDirectory.UltimaMilla;

public interface ICategoriaUltimaMillaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaUltimaMillaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaUltimaMillaRetrieveHandler
{
    public CategoriaUltimaMillaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}