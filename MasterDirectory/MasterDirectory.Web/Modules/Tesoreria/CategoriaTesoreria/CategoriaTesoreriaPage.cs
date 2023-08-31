using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Tesoreria.Pages;

[PageAuthorize(typeof(CategoriaTesoreriaRow))]
public class CategoriaTesoreriaPage : Controller
{
    [Route("Tesoreria/CategoriaTesoreria")]
    public ActionResult Index()
    {
        return this.GridPage("@/Tesoreria/CategoriaTesoreria/CategoriaTesoreriaPage",
            CategoriaTesoreriaRow.Fields.PageTitle());
    }
}