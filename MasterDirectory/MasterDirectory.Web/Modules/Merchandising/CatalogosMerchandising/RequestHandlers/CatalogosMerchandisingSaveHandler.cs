using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Merchandising.CatalogosMerchandisingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Merchandising.CatalogosMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatalogosMerchandisingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMerchandisingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMerchandisingSaveHandler
{
    public CatalogosMerchandisingSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}