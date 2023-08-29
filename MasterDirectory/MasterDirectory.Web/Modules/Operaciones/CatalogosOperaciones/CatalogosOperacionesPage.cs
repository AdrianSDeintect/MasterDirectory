using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Operaciones.Pages;

[PageAuthorize(typeof(CatalogosOperacionesRow))]
public class CatalogosOperacionesPage : Controller
{
    [Route("Operaciones/CatalogosOperaciones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Operaciones/CatalogosOperaciones/CatalogosOperacionesPage",
            CatalogosOperacionesRow.Fields.PageTitle());
    }
}