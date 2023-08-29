using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.Inmobiliaria
{
    [NestedPermissionKeys]
    [DisplayName("Inmobiliaria")]
    public class InmobiliariaPermissionKeys
    {

        public const string Delete = "Inmobiliaria:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "Inmobiliaria:Modify";
        public const string View = "Inmobiliaria:View";

    }
}
