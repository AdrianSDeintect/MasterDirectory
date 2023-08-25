using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Expansion.CatalogosExpansionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Expansion.CatalogosExpansionRow;

namespace MasterDirectory.Expansion;

public interface ICatalogosExpansionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosExpansionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosExpansionSaveHandler
{
    public CatalogosExpansionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}