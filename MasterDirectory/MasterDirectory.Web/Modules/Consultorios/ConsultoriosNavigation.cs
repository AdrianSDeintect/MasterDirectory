using Serenity.Navigation;
using MyPages = MasterDirectory.Consultorios.Pages;

[assembly: NavigationMenu(5000, "Consultorios", icon: "fa-medkit")]
[assembly: NavigationLink(5100, "Consultorios/Consultorios", typeof(MyPages.CategoriaConsultoriosPage), icon: "fa-table")]
[assembly: NavigationLink(5200, "Consultorios/Catalogos Consultorios", typeof(MyPages.CatalogosConsultoriosPage), icon: "fa-th")]