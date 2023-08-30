using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.RecursosHumanos
{
    [NestedPermissionKeys]
    [DisplayName("RecursosHumanos")]
    public class RecursosHumanosPermissionKeys
    {

        public const string Delete = "RecursosHumanos:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "RecursosHumanos:Modify";
        public const string View = "RecursosHumanos:View";

    }
}
