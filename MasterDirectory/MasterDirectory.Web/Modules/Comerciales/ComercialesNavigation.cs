using Serenity.Navigation;
using MyPages = MasterDirectory.Comerciales.Pages;

//[assembly: NavigationLink(int.MaxValue, "Comerciales/Catalogos Comerciales", typeof(MyPages.CatalogosComercialesPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Comerciales/Categoria Comerciales", typeof(MyPages.CategoriaComercialesPage), icon: null)]



[assembly: NavigationMenu(1200, "Comerciales", icon: "fa-linode")]
[assembly: NavigationLink(1210, "Comerciales/Comerciales", typeof(MyPages.CategoriaComercialesPage), icon: "fa-table")]
[assembly: NavigationLink(1220, "Comerciales/Catalogos Comerciales", typeof(MyPages.CatalogosComercialesPage), icon: "fa-th")]