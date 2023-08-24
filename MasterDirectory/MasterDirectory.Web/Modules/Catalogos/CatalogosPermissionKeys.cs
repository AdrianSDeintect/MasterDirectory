using Serenity.ComponentModel;
using System.ComponentModel;

namespace MasterDirectory.Web.Modules.Catalogos
{
    //public class CatalogosPermissionKeys
    //{
    //}
    [NestedPermissionKeys]
    [DisplayName("Catalogos")]
    public class CatalogosPermissionKeys
    {
        //[Description("Tipos Catalogos")]
        //public const string TiposCatalogos = "Catalogos:TipoCatalogos";

        //[Description("Tipo Categorias")]
        //public const string TipoCategorias = "Catalogos:TipoCategorias";

        [Description("Delete")]
        public const string DeleteTipoCatalogos = "Catalogos:TipoCatalogos:Delete";
        [Description("Create/Update"), ImplicitPermission(ViewTipoCatalogos)]
        public const string ModifyTipoCatalogos = "Catalogos:TipoCatalogos:Modify";
        [Description("View")]
        public const string ViewTipoCatalogos = "Catalogos:TipoCatalogos:View";

        [Description("Delete")]
        public const string DeleteTipoCategorias = "Catalogos:TipoCategorias:Delete";
        [Description("Create/Update"), ImplicitPermission(ViewTipoCategorias)]
        public const string ModifyTipoCategorias = "Catalogos:TipoCategorias:Modify";
        [Description("View")]
        public const string ViewTipoCategorias = "Catalogos:TipoCategorias:View";


    }
}
