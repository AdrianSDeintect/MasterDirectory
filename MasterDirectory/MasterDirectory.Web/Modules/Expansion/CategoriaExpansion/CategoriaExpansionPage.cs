using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Expansion.Pages;

[PageAuthorize(typeof(CategoriaExpansionRow))]
public class CategoriaExpansionPage : Controller
{
    [Route("Expansion/CategoriaExpansion")]
    public ActionResult Index()
    {
        return this.GridPage("@/Expansion/CategoriaExpansion/CategoriaExpansionPage",
            CategoriaExpansionRow.Fields.PageTitle());
    }
}