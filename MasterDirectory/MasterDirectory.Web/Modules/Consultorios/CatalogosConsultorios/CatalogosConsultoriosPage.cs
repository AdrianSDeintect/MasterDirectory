using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Consultorios.Pages;

[PageAuthorize(typeof(CatalogosConsultoriosRow))]
public class CatalogosConsultoriosPage : Controller
{
    [Route("Consultorios/CatalogosConsultorios")]
    public ActionResult Index()
    {
        return this.GridPage("@/Consultorios/CatalogosConsultorios/CatalogosConsultoriosPage",
            CatalogosConsultoriosRow.Fields.PageTitle());
    }
}