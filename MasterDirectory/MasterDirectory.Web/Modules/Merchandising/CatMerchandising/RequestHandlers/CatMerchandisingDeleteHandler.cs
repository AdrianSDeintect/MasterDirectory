using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Merchandising.CatMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatMerchandisingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatMerchandisingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatMerchandisingDeleteHandler
{
    public CatMerchandisingDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}