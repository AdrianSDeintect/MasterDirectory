using Serenity.Navigation;
using MyPages = MasterDirectory.Catalogos.Pages;


[assembly: NavigationMenu(1000, "Catalogos", icon: "fa-list")]
[assembly: NavigationLink(1100, "Catalogos/Tipo Catalogos", typeof(MyPages.TipoCatalogosPage), icon: "fa-th")]
[assembly: NavigationLink(1200, "Catalogos/Tipo Categorias", typeof(MyPages.TipoCategoriasPage), icon: "fa-th")]