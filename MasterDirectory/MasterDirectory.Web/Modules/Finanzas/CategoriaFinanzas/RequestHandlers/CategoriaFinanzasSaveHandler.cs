using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Finanzas.CategoriaFinanzasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Finanzas.CategoriaFinanzasRow;

namespace MasterDirectory.Finanzas;

public interface ICategoriaFinanzasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaFinanzasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaFinanzasSaveHandler
{
    public CategoriaFinanzasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}