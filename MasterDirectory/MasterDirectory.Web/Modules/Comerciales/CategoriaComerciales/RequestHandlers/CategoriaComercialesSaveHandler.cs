using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Comerciales.CategoriaComercialesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Comerciales.CategoriaComercialesRow;

namespace MasterDirectory.Comerciales;

public interface ICategoriaComercialesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaComercialesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaComercialesSaveHandler
{
    public CategoriaComercialesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}