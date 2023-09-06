using Serenity.Navigation;
using MyPages = MasterDirectory.Digital.Pages;

//[assembly: NavigationLink(int.MaxValue, "Digital/Catalogos Digital", typeof(MyPages.CatalogosDigitalPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Digital/Categoria Digital", typeof(MyPages.CategoriaDigitalPage), icon: null)]

[assembly: NavigationMenu(1400, "Digital", icon: "fa-map-marker")]
[assembly: NavigationLink(1410, "Digital/Digital", typeof(MyPages.CategoriaDigitalPage), icon: "fa-table")]
[assembly: NavigationLink(1420, "Digital/Catalogos Digital", typeof(MyPages.CatalogosDigitalPage), icon: "fa-th")]