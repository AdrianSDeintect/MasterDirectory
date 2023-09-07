using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MasterDirectory.MarketIntelligence.Pages;

[PageAuthorize(typeof(CatalogosMarketIntelligenceRow))]
public class CatalogosMarketIntelligencePage : Controller
{
    [Route("MarketIntelligence/CatalogosMarketIntelligence")]
    public ActionResult Index()
    {
        return this.GridPage("@/MarketIntelligence/CatalogosMarketIntelligence/CatalogosMarketIntelligencePage",
            CatalogosMarketIntelligenceRow.Fields.PageTitle());
    }
}