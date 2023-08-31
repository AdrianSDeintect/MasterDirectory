using Serenity.Navigation;
using MyPages = MasterDirectory.Inmobiliaria.Pages;


[assembly: NavigationMenu(7000, "Inmobiliaria", icon: "fa-building")]
[assembly: NavigationLink(7100, "Inmobiliaria/Inmobiliaria", typeof(MyPages.CategoriaInmobiliariaPage), icon: "fa-table")]
[assembly: NavigationLink(7200, "Inmobiliaria/Catalogos Inmobiliaria", typeof(MyPages.CatalogosInmobiliariaPage), icon: "fa-th")]