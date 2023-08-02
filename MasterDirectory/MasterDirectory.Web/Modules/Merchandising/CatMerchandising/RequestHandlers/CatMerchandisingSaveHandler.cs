using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Merchandising.CatMerchandisingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Merchandising.CatMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatMerchandisingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatMerchandisingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatMerchandisingSaveHandler
{
    public CatMerchandisingSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}