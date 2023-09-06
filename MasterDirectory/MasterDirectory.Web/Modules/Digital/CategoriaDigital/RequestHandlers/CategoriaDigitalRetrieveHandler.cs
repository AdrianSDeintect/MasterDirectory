using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Digital.CategoriaDigitalRow>;
using MyRow = MasterDirectory.Digital.CategoriaDigitalRow;

namespace MasterDirectory.Digital;

public interface ICategoriaDigitalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaDigitalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaDigitalRetrieveHandler
{
    public CategoriaDigitalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}