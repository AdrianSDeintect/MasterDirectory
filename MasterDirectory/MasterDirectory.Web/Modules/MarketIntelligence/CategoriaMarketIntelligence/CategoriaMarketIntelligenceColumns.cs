using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.MarketIntelligence.Columns;

[ColumnsScript("MarketIntelligence.CategoriaMarketIntelligence")]
[BasedOnRow(typeof(CategoriaMarketIntelligenceRow), CheckNames = true)]
public class CategoriaMarketIntelligenceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Nse { get; set; }
    public string Cluster { get; set; }
    public string Brick { get; set; }
    //public DateTime DtRegistro { get; set; }
}