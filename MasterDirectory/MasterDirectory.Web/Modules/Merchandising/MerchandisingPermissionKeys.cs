using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Merchandising
{
    [NestedPermissionKeys]
    [DisplayName("Merchadising")]
    public class MerchandisingPermissionKeys
    {
            public const string Delete = "Merchandising:Delete";
            [Description("Create/Update"), ImplicitPermission(View)]
            public const string Modify = "Merchandising:Modify";
            public const string View = "Merchandising:View";

    }
}
