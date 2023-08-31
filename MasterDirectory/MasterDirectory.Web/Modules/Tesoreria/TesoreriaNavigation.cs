using Serenity.Navigation;
using MyPages = MasterDirectory.Tesoreria.Pages;

//[assembly: NavigationLink(int.MaxValue, "Tesoreria/Catalogos Tesoreria", typeof(MyPages.CatalogosTesoreriaPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Tesoreria/Categoria Tesoreria", typeof(MyPages.CategoriaTesoreriaPage), icon: null)]

[assembly: NavigationMenu(1100, "Tesoreria", icon: "fa-university")]
[assembly: NavigationLink(1110, "Tesoreria/Tesoreria", typeof(MyPages.CategoriaTesoreriaPage), icon: "fa-table")]
[assembly: NavigationLink(1120, "Tesoreria/Catalogos Tesoreria", typeof(MyPages.CatalogosTesoreriaPage), icon: "fa-th")]