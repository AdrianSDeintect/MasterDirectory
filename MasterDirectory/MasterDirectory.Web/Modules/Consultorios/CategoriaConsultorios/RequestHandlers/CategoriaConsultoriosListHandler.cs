using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MasterDirectory.Consultorios.CategoriaConsultoriosRow>;
using MyRow = MasterDirectory.Consultorios.CategoriaConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICategoriaConsultoriosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaConsultoriosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaConsultoriosListHandler
{
    public CategoriaConsultoriosListHandler(IRequestContext context)
            : base(context)
    {
    }
}