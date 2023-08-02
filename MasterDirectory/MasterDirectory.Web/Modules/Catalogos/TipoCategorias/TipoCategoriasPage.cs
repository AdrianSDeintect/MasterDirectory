using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.Catalogos.Pages;

[PageAuthorize(typeof(TipoCategoriasRow))]
public class TipoCategoriasPage : Controller
{
    [Route("Catalogos/TipoCategorias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Catalogos/TipoCategorias/TipoCategoriasPage",
            TipoCategoriasRow.Fields.PageTitle());
    }
}