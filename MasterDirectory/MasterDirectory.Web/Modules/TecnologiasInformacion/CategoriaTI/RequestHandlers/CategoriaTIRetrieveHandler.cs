using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.TecnologiasInformacion.CategoriaTIRow>;
using MyRow = MasterDirectory.TecnologiasInformacion.CategoriaTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICategoriaTIRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTIRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTIRetrieveHandler
{
    public CategoriaTIRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}