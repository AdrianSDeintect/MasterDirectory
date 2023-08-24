using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MasterDirectory.Consultorios.CategoriaConsultoriosRow>;
using MyRow = MasterDirectory.Consultorios.CategoriaConsultoriosRow;

namespace MasterDirectory.Consultorios;

public interface ICategoriaConsultoriosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoriaConsultoriosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriaConsultoriosRetrieveHandler
{
    public CategoriaConsultoriosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}