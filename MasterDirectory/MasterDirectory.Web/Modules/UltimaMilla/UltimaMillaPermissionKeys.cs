using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.UltimaMilla
{
    //public class MerchandisingPermissionKeys
    //{
    //}
    [NestedPermissionKeys]
    [DisplayName("UltimaMilla")]
    public class UltimaMillaPermissionKeys
    {

        public const string Delete = "UltimaMilla:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "UltimaMilla:Modify";
        public const string View = "UltimaMilla:View";

    }
}
