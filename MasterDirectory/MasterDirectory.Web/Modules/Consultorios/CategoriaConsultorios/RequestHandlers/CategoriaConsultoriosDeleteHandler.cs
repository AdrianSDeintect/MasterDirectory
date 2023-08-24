using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MasterDirectory.Consultorios.CategoriaConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICategoriaConsultoriosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaConsultoriosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaConsultoriosDeleteHandler
{
    public CategoriaConsultoriosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}