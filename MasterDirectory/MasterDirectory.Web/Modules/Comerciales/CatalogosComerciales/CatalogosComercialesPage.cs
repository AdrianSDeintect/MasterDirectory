using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Comerciales.Pages;

[PageAuthorize(typeof(CatalogosComercialesRow))]
public class CatalogosComercialesPage : Controller
{
    [Route("Comerciales/CatalogosComerciales")]
    public ActionResult Index()
    {
        return this.GridPage("@/Comerciales/CatalogosComerciales/CatalogosComercialesPage",
            CatalogosComercialesRow.Fields.PageTitle());
    }
}