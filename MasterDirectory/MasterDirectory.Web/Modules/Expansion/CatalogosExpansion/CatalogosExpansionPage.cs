using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Expansion.Pages;

[PageAuthorize(typeof(CatalogosExpansionRow))]
public class CatalogosExpansionPage : Controller
{
    [Route("Expansion/CatalogosExpansion")]
    public ActionResult Index()
    {
        return this.GridPage("@/Expansion/CatalogosExpansion/CatalogosExpansionPage",
            CatalogosExpansionRow.Fields.PageTitle());
    }
}