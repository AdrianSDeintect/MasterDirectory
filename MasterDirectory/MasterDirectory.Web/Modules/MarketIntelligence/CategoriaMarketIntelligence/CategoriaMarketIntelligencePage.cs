using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.MarketIntelligence.Pages;

[PageAuthorize(typeof(CategoriaMarketIntelligenceRow))]
public class CategoriaMarketIntelligencePage : Controller
{
    [Route("MarketIntelligence/CategoriaMarketIntelligence")]
    public ActionResult Index()
    {
        return this.GridPage("@/MarketIntelligence/CategoriaMarketIntelligence/CategoriaMarketIntelligencePage",
            CategoriaMarketIntelligenceRow.Fields.PageTitle());
    }
}