using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Consultorios.Pages;

[PageAuthorize(typeof(CategoriaConsultoriosRow))]
public class CategoriaConsultoriosPage : Controller
{
    [Route("Consultorios/CategoriaConsultorios")]
    public ActionResult Index()
    {
        return this.GridPage("@/Consultorios/CategoriaConsultorios/CategoriaConsultoriosPage",
            CategoriaConsultoriosRow.Fields.PageTitle());
    }
}