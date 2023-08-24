using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Finanzas.Pages;

[PageAuthorize(typeof(CatalogosFinanzasRow))]
public class CatalogosFinanzasPage : Controller
{
    [Route("Finanzas/CatalogosFinanzas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Finanzas/CatalogosFinanzas/CatalogosFinanzasPage",
            CatalogosFinanzasRow.Fields.PageTitle());
    }
}