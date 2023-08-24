using Serenity.Navigation;
using MyPages = MasterDirectory.Finanzas.Pages;

[assembly: NavigationMenu(3000, "Finanzas", icon: "fa-money")]
[assembly: NavigationLink(3100, "Finanzas/Finanzas", typeof(MyPages.CategoriaFinanzasPage), icon: "fa-table")]
[assembly: NavigationLink(3200, "Finanzas/Catalogos Finanzas", typeof(MyPages.CatalogosFinanzasPage), icon: "fa-th")]