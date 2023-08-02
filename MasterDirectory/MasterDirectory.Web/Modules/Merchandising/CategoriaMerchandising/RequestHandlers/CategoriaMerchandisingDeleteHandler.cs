using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Merchandising.CategoriaMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICategoriaMerchandisingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaMerchandisingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaMerchandisingDeleteHandler
{
    public CategoriaMerchandisingDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}