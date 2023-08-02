using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Merchandising.Pages;

[PageAuthorize(typeof(CatMerchandisingRow))]
public class CatMerchandisingPage : Controller
{
    [Route("Merchandising/CatMerchandising")]
    public ActionResult Index()
    {
        return this.GridPage("@/Merchandising/CatMerchandising/CatMerchandisingPage",
            CatMerchandisingRow.Fields.PageTitle());
    }
}