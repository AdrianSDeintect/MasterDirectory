using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Expansion.CategoriaExpansionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Expansion.CategoriaExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICategoriaExpansionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaExpansionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaExpansionSaveHandler
{
    public CategoriaExpansionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}