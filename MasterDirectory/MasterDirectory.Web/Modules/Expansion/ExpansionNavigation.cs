using Serenity.Navigation;
using MyPages = MasterDirectory.Expansion.Pages;

//[assembly: NavigationLink(int.MaxValue, "Expansion/Catalogos Expansion", typeof(MyPages.CatalogosExpansionPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Expansion/Categoria Expansion", typeof(MyPages.CategoriaExpansionPage), icon: null)]


[assembly: NavigationMenu(6000, "Expansion", icon: "fa-map")]
[assembly: NavigationLink(6100, "Expansion/Expansion", typeof(MyPages.CategoriaExpansionPage), icon: "fa-table")]
[assembly: NavigationLink(6200, "Expansion/Catalogos Expansion", typeof(MyPages.CatalogosExpansionPage), icon: "fa-th")]