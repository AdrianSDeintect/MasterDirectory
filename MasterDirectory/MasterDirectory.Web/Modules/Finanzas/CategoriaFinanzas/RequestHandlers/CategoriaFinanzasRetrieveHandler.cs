using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Finanzas.CategoriaFinanzasRow>;
using MyRow = MasterDirectory.Finanzas.CategoriaFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICategoriaFinanzasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaFinanzasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaFinanzasRetrieveHandler
{
    public CategoriaFinanzasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}