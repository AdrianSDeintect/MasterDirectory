using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Operaciones
{
    [NestedPermissionKeys]
    [DisplayName("Operaciones")]
    public class OperacionesPermissionKeys
    {

        public const string Delete = "Operaciones:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Operaciones:Modify";
        public const string View = "Operaciones:View";

    }
}
