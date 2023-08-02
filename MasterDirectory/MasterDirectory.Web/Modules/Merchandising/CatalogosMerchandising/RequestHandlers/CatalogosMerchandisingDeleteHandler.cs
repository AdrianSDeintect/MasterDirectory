using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Merchandising.CatalogosMerchandisingRow;

namespace MasterDirectory.Merchandising;

public interface ICatalogosMerchandisingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosMerchandisingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosMerchandisingDeleteHandler
{
    public CatalogosMerchandisingDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}