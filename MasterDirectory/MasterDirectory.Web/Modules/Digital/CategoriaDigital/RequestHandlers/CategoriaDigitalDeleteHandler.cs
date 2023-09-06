using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Digital.CategoriaDigitalRow;

namespace MasterDirectory.Digital;

public interface ICategoriaDigitalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaDigitalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaDigitalDeleteHandler
{
    public CategoriaDigitalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}