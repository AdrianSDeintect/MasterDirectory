using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.UltimaMilla.Pages;

[PageAuthorize(typeof(CatalogosUltimaMillaRow))]
public class CatalogosUltimaMillaPage : Controller
{
    [Route("UltimaMilla/CatalogosUltimaMilla")]
    public ActionResult Index()
    {
        return this.GridPage("@/UltimaMilla/CatalogosUltimaMilla/CatalogosUltimaMillaPage",
            CatalogosUltimaMillaRow.Fields.PageTitle());
    }
}