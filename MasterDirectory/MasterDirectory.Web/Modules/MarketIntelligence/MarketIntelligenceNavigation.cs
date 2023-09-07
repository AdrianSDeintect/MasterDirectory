using Serenity.Navigation;
using MyPages = MasterDirectory.MarketIntelligence.Pages;

//[assembly: NavigationLink(int.MaxValue, "MarketIntelligence/Catalogos Market Intelligence", typeof(MyPages.CatalogosMarketIntelligencePage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "MarketIntelligence/Categoria Market Intelligence", typeof(MyPages.CategoriaMarketIntelligencePage), icon: null)]

[assembly: NavigationMenu(1500, "Market Intelligence", icon: "fa-tachometer")]
[assembly: NavigationLink(1510, "Market Intelligence/Market Intelligence", typeof(MyPages.CategoriaMarketIntelligencePage), icon: "fa-table")]
[assembly: NavigationLink(1520, "Market Intelligence/Catalogos Market Intelligence", typeof(MyPages.CatalogosMarketIntelligencePage), icon: "fa-th")]