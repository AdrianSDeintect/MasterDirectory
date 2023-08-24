using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Consultorios.CatalogosConsultoriosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Consultorios.CatalogosConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICatalogosConsultoriosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosConsultoriosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosConsultoriosSaveHandler
{
    public CatalogosConsultoriosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}