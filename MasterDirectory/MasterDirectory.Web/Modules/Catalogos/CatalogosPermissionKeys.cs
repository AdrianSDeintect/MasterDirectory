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
        [Description("Tipos Catalogos")]
        public const string TiposCatalogos = "Catalogos:TipoCatalogos";

        [Description("Tipo Categorias")]
        public const string TipoCategorias = "Catalogos:TipoCategorias";
    }
}
