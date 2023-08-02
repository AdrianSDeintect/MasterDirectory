using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Merchandising.Pages;

[PageAuthorize(typeof(CatalogosMerchandisingRow))]
public class CatalogosMerchandisingPage : Controller
{
    [Route("Merchandising/CatalogosMerchandising")]
    public ActionResult Index()
    {
        return this.GridPage("@/Merchandising/CatalogosMerchandising/CatalogosMerchandisingPage",
            CatalogosMerchandisingRow.Fields.PageTitle());
    }
}