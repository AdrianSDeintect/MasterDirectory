using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Merchandising
{
    //public class MerchandisingPermissionKeys
    //{
    //}
    [NestedPermissionKeys]
    [DisplayName("Merchadising")]
    public class MerchandisingPermissionKeys
    {
        [Description("Merchadising")]
        public const string Merchadising = "Merchadising:CatMerchandising";

        [Description("Catalogos Merchadising")]
        public const string CatalogosMerchadising = "Merchadising:CatalogosMerchandising";
    }
}
