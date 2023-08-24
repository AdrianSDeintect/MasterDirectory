using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Finanzas
{
    [NestedPermissionKeys]
    [DisplayName("Finanzas")]
    public class FinanzasPermissionKeys
    {
        public const string Delete = "Finanzas:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Finanzas:Modify";
        public const string View = "Finanzas:View";

    }
}
