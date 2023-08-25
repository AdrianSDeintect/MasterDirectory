using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Expansion
{
    [NestedPermissionKeys]
    [DisplayName("Expansion")]
    public class ExpansionPermissionKeys
    {

        public const string Delete = "Expansion:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Expansion:Modify";
        public const string View = "Expansion:View";

    }
}
