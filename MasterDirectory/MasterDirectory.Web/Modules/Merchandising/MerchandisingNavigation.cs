using Serenity.Navigation;
using MyPages = MasterDirectory.Merchandising.Pages;


[assembly: NavigationMenu(2000, "Merchandising", icon: "fa-shopping-basket")]
[assembly: NavigationLink(2100, "Merchandising/Merchandising", typeof(MyPages.CategoriaMerchandisingPage), icon: "fa-table")]
[assembly: NavigationLink(2200, "Merchandising/Catalogos Merchandising", typeof(MyPages.CatalogosMerchandisingPage), icon: "fa-th")]
//[assembly: NavigationLink(int.MaxValue, "Merchandising/Categoria Merchandising", typeof(MyPages.CategoriaMerchandisingPage), icon: null)]