using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Comerciales
{
    [NestedPermissionKeys]
    [DisplayName("Comerciales")]
    public class ComercialesPermissionKeys
    {

        public const string Delete = "Comerciales:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Comerciales:Modify";
        public const string View = "Comerciales:View";

    }
}
