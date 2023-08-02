using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Catalogos.Pages;

[PageAuthorize(typeof(TipoCatalogosRow))]
public class TipoCatalogosPage : Controller
{
    [Route("Catalogos/TipoCatalogos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Catalogos/TipoCatalogos/TipoCatalogosPage",
            TipoCatalogosRow.Fields.PageTitle());
    }
}