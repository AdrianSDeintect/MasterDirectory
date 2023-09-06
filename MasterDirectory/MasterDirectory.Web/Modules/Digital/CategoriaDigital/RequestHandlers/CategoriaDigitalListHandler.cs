using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Digital.CategoriaDigitalRow>;
using MyRow = MasterDirectory.Digital.CategoriaDigitalRow;

namespace MasterDirectory.Digital;

public interface ICategoriaDigitalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaDigitalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaDigitalListHandler
{
    public CategoriaDigitalListHandler(IRequestContext context)
            : base(context)
    {
    }
}