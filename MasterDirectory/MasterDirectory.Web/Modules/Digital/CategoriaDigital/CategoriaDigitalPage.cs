using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Digital.Pages;

[PageAuthorize(typeof(CategoriaDigitalRow))]
public class CategoriaDigitalPage : Controller
{
    [Route("Digital/CategoriaDigital")]
    public ActionResult Index()
    {
        return this.GridPage("@/Digital/CategoriaDigital/CategoriaDigitalPage",
            CategoriaDigitalRow.Fields.PageTitle());
    }
}