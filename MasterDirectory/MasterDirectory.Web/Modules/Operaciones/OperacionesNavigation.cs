using Serenity.Navigation;
using MyPages = MasterDirectory.Operaciones.Pages;

//[assembly: NavigationLink(int.MaxValue, "Operaciones/Catalogos Operaciones", typeof(MyPages.CatalogosOperacionesPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Operaciones/Categoria Operaciones", typeof(MyPages.CategoriaOperacionesPage), icon: null)]

[assembly: NavigationMenu(8000, "Operaciones", icon: "fa-sitemap")]
[assembly: NavigationLink(8100, "Operaciones/Operaciones", typeof(MyPages.CategoriaOperacionesPage), icon: "fa-table")]
[assembly: NavigationLink(8200, "Operaciones/Catalogos Operaciones", typeof(MyPages.CatalogosOperacionesPage), icon: "fa-th")]