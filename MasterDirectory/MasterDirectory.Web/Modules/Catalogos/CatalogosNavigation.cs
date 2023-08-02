using Serenity.Navigation;
using MyPages = MasterDirectory.Catalogos.Pages;


[assembly: NavigationMenu(3000, "Catalogos", icon: "fa-list")]
[assembly: NavigationLink(3100, "Catalogos/Tipo Catalogos", typeof(MyPages.TipoCatalogosPage), icon: "fa-th")]
[assembly: NavigationLink(3200, "Catalogos/Tipo Categorias", typeof(MyPages.TipoCategoriasPage), icon: "fa-th")]