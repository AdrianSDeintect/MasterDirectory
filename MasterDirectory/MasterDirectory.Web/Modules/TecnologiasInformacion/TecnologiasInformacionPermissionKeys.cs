using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.TecnologiasInformacion
{
    [NestedPermissionKeys]
    [DisplayName("TecnologiasInformacion")]
    public class TecnologiasInformacionPermissionKeys
    {

        public const string Delete = "TecnologiasInformacion:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "TecnologiasInformacion:Modify";
        public const string View = "TecnologiasInformacion:View";

    }
}
