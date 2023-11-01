using Serenity.Navigation;
using MyPages = MasterDirectory.UltimaMilla.Pages;


[assembly: NavigationMenu(4000, "Ultima Milla", icon: "fa-car")]
//[assembly: NavigationLink(4100, "Ultima Milla/Ultima Milla", typeof(MyPages.CategoriaUltimaMillaPage), icon: "fa-table")]
[assembly: NavigationLink(4100, "Ultima Milla/Ultima Milla", typeof(MyPages.CategoriaUltimaMillaPage), icon: "fa-table")]
[assembly: NavigationLink(4200, "Ultima Milla/Catalogos Ultima Milla", typeof(MyPages.CatalogosUltimaMillaPage), icon: "fa-th")]


//[assembly: NavigationLink(int.MaxValue, "UltimaMilla/", typeof(MyPages.CatalogosUltimaMillaPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "UltimaMilla/Categoria Ultima Milla", typeof(MyPages.CategoriaUltimaMillaPage), icon: null)]
