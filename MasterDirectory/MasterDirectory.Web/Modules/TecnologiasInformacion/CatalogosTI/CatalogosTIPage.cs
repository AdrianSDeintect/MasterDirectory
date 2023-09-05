using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.TecnologiasInformacion.Pages;

[PageAuthorize(typeof(CatalogosTIRow))]
public class CatalogosTIPage : Controller
{
    [Route("TecnologiasInformacion/CatalogosTI")]
    public ActionResult Index()
    {
        return this.GridPage("@/TecnologiasInformacion/CatalogosTI/CatalogosTIPage",
            CatalogosTIRow.Fields.PageTitle());
    }
}