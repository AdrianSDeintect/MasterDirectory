using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Inmobiliaria.Pages;

[PageAuthorize(typeof(CategoriaInmobiliariaRow))]
public class CategoriaInmobiliariaPage : Controller
{
    [Route("Inmobiliaria/CategoriaInmobiliaria")]
    public ActionResult Index()
    {
        return this.GridPage("@/Inmobiliaria/CategoriaInmobiliaria/CategoriaInmobiliariaPage",
            CategoriaInmobiliariaRow.Fields.PageTitle());
    }
}