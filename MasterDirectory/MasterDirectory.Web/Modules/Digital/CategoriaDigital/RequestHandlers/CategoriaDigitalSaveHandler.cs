using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MasterDirectory.Digital.CategoriaDigitalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MasterDirectory.Digital.CategoriaDigitalRow;

namespace MasterDirectory.Digital;

public interface ICategoriaDigitalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaDigitalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaDigitalSaveHandler
{
    public CategoriaDigitalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}