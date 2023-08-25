using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Expansion.CategoriaExpansionRow>;
using MyRow = MasterDirectory.Expansion.CategoriaExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICategoriaExpansionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaExpansionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaExpansionRetrieveHandler
{
    public CategoriaExpansionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}