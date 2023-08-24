using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.UltimaMilla.Pages;

[PageAuthorize(typeof(CategoriaUltimaMillaRow))]
public class CategoriaUltimaMillaPage : Controller
{
    [Route("UltimaMilla/CategoriaUltimaMilla")]
    public ActionResult Index()
    {
        return this.GridPage("@/UltimaMilla/CategoriaUltimaMilla/CategoriaUltimaMillaPage",
            CategoriaUltimaMillaRow.Fields.PageTitle());
    }
}