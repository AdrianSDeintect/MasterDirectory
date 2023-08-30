using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.RecursosHumanos.Pages;

[PageAuthorize(typeof(CatalogosRHRow))]
public class CatalogosRHPage : Controller
{
    [Route("RecursosHumanos/CatalogosRH")]
    public ActionResult Index()
    {
        return this.GridPage("@/RecursosHumanos/CatalogosRH/CatalogosRHPage",
            CatalogosRHRow.Fields.PageTitle());
    }
}