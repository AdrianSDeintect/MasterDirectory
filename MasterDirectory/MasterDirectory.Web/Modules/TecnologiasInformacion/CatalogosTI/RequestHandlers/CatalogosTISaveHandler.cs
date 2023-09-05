using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.TecnologiasInformacion.CatalogosTIRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.TecnologiasInformacion.CatalogosTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICatalogosTISaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosTISaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosTISaveHandler
{
    public CatalogosTISaveHandler(IRequestContext context)
            : base(context)
    {
    }
}