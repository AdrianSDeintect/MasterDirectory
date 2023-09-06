using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Digital
{
    [NestedPermissionKeys]
    [DisplayName("Digital")]
    public class DigitalPermissionKeys
    {

        public const string Delete = "Digital:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Digital:Modify";
        public const string View = "Digital:View";

    }
}
