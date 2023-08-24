using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Finanzas.Pages;

[PageAuthorize(typeof(CategoriaFinanzasRow))]
public class CategoriaFinanzasPage : Controller
{
    [Route("Finanzas/CategoriaFinanzas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Finanzas/CategoriaFinanzas/CategoriaFinanzasPage",
            CategoriaFinanzasRow.Fields.PageTitle());
    }
}