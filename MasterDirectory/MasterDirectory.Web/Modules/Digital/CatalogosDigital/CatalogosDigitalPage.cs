using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Digital.Pages;

[PageAuthorize(typeof(CatalogosDigitalRow))]
public class CatalogosDigitalPage : Controller
{
    [Route("Digital/CatalogosDigital")]
    public ActionResult Index()
    {
        return this.GridPage("@/Digital/CatalogosDigital/CatalogosDigitalPage",
            CatalogosDigitalRow.Fields.PageTitle());
    }
}