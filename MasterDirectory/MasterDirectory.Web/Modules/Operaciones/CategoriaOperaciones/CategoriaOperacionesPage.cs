using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Operaciones.Pages;

[PageAuthorize(typeof(CategoriaOperacionesRow))]
public class CategoriaOperacionesPage : Controller
{
    [Route("Operaciones/CategoriaOperaciones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Operaciones/CategoriaOperaciones/CategoriaOperacionesPage",
            CategoriaOperacionesRow.Fields.PageTitle());
    }
}