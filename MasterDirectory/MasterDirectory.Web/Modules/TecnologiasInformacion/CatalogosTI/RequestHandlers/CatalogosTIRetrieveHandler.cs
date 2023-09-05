using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.TecnologiasInformacion.CatalogosTIRow>;
using MyRow = MasterDirectory.TecnologiasInformacion.CatalogosTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICatalogosTIRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTIRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTIRetrieveHandler
{
    public CatalogosTIRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}