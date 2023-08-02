using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Merchandising.Pages;

[PageAuthorize(typeof(CategoriaMerchandisingRow))]
public class CategoriaMerchandisingPage : Controller
{
    [Route("Merchandising/CategoriaMerchandising")]
    public ActionResult Index()
    {
        return this.GridPage("@/Merchandising/CategoriaMerchandising/CategoriaMerchandisingPage",
            CategoriaMerchandisingRow.Fields.PageTitle());
    }
}