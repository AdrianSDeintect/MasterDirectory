using Serenity.Navigation;
using MyPages = MasterDirectory.RecursosHumanos.Pages;

//[assembly: NavigationLink(int.MaxValue, "RecursosHumanos/Catalogos Rh", typeof(MyPages.CatalogosRHPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "RecursosHumanos/Categoria Rh", typeof(MyPages.CategoriaRHPage), icon: null)]


[assembly: NavigationMenu(9000, "Recursos Humanos", icon: "fa-users")]
[assembly: NavigationLink(9100, "Recursos Humanos/RH", typeof(MyPages.CategoriaRHPage), icon: "fa-table")]
[assembly: NavigationLink(9200, "Recursos Humanos/Catalogos RH", typeof(MyPages.CatalogosRHPage), icon: "fa-th")]