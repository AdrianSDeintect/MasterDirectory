using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Consultorios
{
    [NestedPermissionKeys]
    [DisplayName("Consultorios")]
    public class ConsultoriosPermissionKeys
    {

        public const string Delete = "Consultorios:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Consultorios:Modify";
        public const string View = "Consultorios:View";

    }
}
