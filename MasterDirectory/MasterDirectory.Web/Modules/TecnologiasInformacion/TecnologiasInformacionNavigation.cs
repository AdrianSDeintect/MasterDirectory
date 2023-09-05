using Serenity.Navigation;
using MyPages = MasterDirectory.TecnologiasInformacion.Pages;

//[assembly: NavigationLink(int.MaxValue, "TecnologiasInformacion/Catalogos Ti", typeof(MyPages.CatalogosTIPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "TecnologiasInformacion/Categoria Ti", typeof(MyPages.CategoriaTIPage), icon: null)]


[assembly: NavigationMenu(1300, "Tecnologias de Informacion", icon: "fa-windows")]
[assembly: NavigationLink(1310, "Tecnologias de Informacion/TI", typeof(MyPages.CategoriaTIPage), icon: "fa-table")]
[assembly: NavigationLink(1320, "Tecnologias de Informacion/Catalogos TI", typeof(MyPages.CatalogosTIPage), icon: "fa-th")]