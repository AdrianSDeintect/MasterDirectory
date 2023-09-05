using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.TecnologiasInformacion.Pages;

[PageAuthorize(typeof(CategoriaTIRow))]
public class CategoriaTIPage : Controller
{
    [Route("TecnologiasInformacion/CategoriaTI")]
    public ActionResult Index()
    {
        return this.GridPage("@/TecnologiasInformacion/CategoriaTI/CategoriaTIPage",
            CategoriaTIRow.Fields.PageTitle());
    }
}