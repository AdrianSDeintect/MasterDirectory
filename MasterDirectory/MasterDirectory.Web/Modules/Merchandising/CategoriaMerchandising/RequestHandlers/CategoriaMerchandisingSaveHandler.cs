using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Merchandising.CategoriaMerchandisingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Merchandising.CategoriaMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICategoriaMerchandisingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMerchandisingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMerchandisingSaveHandler
{
    public CategoriaMerchandisingSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}