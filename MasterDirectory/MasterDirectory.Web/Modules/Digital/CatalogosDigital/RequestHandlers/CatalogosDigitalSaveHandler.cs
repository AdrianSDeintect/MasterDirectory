using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Digital.CatalogosDigitalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Digital.CatalogosDigitalRow;

namespace MasterDirectory.Digital;

public interface ICatalogosDigitalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosDigitalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosDigitalSaveHandler
{
    public CatalogosDigitalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}