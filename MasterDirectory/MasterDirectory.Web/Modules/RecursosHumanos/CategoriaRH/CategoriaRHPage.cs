using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.RecursosHumanos.Pages;

[PageAuthorize(typeof(CategoriaRHRow))]
public class CategoriaRHPage : Controller
{
    [Route("RecursosHumanos/CategoriaRH")]
    public ActionResult Index()
    {
        return this.GridPage("@/RecursosHumanos/CategoriaRH/CategoriaRHPage",
            CategoriaRHRow.Fields.PageTitle());
    }
}