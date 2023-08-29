using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Inmobiliaria.Pages;

[PageAuthorize(typeof(CatalogosInmobiliariaRow))]
public class CatalogosInmobiliariaPage : Controller
{
    [Route("Inmobiliaria/CatalogosInmobiliaria")]
    public ActionResult Index()
    {
        return this.GridPage("@/Inmobiliaria/CatalogosInmobiliaria/CatalogosInmobiliariaPage",
            CatalogosInmobiliariaRow.Fields.PageTitle());
    }
}