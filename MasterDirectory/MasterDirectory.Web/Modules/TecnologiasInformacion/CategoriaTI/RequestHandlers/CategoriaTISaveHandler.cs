using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.TecnologiasInformacion.CategoriaTIRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.TecnologiasInformacion.CategoriaTIRow;

namespace MasterDirectory.TecnologiasInformacion;

public interface ICategoriaTISaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaTISaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaTISaveHandler
{
    public CategoriaTISaveHandler(IRequestContext context)
            : base(context)
    {
    }
}