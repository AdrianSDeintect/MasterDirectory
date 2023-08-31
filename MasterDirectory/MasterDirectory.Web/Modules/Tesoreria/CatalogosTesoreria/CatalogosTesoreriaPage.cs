using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Tesoreria.Pages;

[PageAuthorize(typeof(CatalogosTesoreriaRow))]
public class CatalogosTesoreriaPage : Controller
{
    [Route("Tesoreria/CatalogosTesoreria")]
    public ActionResult Index()
    {
        return this.GridPage("@/Tesoreria/CatalogosTesoreria/CatalogosTesoreriaPage",
            CatalogosTesoreriaRow.Fields.PageTitle());
    }
}