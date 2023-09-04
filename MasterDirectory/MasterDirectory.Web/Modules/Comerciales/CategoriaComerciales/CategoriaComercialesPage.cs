using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Comerciales.Pages;

[PageAuthorize(typeof(CategoriaComercialesRow))]
public class CategoriaComercialesPage : Controller
{
    [Route("Comerciales/CategoriaComerciales")]
    public ActionResult Index()
    {
        return this.GridPage("@/Comerciales/CategoriaComerciales/CategoriaComercialesPage",
            CategoriaComercialesRow.Fields.PageTitle());
    }
}