using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Comerciales.CatalogosComercialesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Comerciales.CatalogosComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICatalogosComercialesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CatalogosComercialesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICatalogosComercialesSaveHandler
{
    public CatalogosComercialesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}