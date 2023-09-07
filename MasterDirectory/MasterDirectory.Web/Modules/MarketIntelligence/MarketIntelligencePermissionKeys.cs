using Serenity.ComponentModel;
using System.ComponentModel;


namespace MasterDirectory.Web.Modules.MarketIntelligence
{
    [NestedPermissionKeys]
    [DisplayName("MarketIntelligence")]
    public class MarketIntelligencePermissionKeys
    {

        public const string Delete = "MarketIntelligence:Delete";
        [Description("Create/Update"), ImplicitPermission(View)]
        public const string Modify = "MarketIntelligence:Modify";
        public const string View = "MarketIntelligence:View";

    }
}
