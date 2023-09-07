using Serenity.ComponentModel;
using System;

namespace MasterDirectory.MarketIntelligence.Forms;

[FormScript("MarketIntelligence.CategoriaMarketIntelligence")]
[BasedOnRow(typeof(CategoriaMarketIntelligenceRow), CheckNames = true)]
public class CategoriaMarketIntelligenceForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Nse { get; set; }
    public string Cluster { get; set; }
    public string Brick { get; set; }
    //public DateTime DtRegistro { get; set; }
}