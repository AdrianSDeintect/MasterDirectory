using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Tesoreria
{
    [NestedPermissionKeys]
    [DisplayName("Tesoreria")]
    public class TesoreriaPermissionKeys
    {

        public const string Delete = "Tesoreria:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Tesoreria:Modify";
        public const string View = "Tesoreria:View";

    }
}
