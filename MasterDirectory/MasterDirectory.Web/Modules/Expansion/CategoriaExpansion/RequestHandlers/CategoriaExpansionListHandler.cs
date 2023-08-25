using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Expansion.CategoriaExpansionRow>;
using MyRow = MasterDirectory.Expansion.CategoriaExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICategoriaExpansionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaExpansionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaExpansionListHandler
{
    public CategoriaExpansionListHandler(IRequestContext context)
            : base(context)
    {
    }
}