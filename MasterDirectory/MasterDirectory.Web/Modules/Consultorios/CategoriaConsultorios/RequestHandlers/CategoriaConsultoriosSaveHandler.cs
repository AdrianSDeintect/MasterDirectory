using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Consultorios.CategoriaConsultoriosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Consultorios.CategoriaConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICategoriaConsultoriosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaConsultoriosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaConsultoriosSaveHandler
{
    public CategoriaConsultoriosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}