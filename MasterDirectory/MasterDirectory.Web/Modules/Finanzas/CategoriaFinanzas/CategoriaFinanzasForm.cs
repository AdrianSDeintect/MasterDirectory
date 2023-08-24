using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Finanzas.Forms;

[FormScript("Finanzas.CategoriaFinanzas")]
[BasedOnRow(typeof(CategoriaFinanzasRow), CheckNames = true)]
public class CategoriaFinanzasForm
{

    [Tab("General")]
    public string LocalSap { get; set; }
    public string Mercado { get; set; }
    public DateTime FechaCierre { get; set; }
    public string EstatusFarmacia { get; set; }
    public string RegionCluster { get; set; }
    public string KeyState { get; set; }

    [Tab("Top")]
    public string Top360 { get; set; }
    public string TopMkt { get; set; }
    public string Top550 { get; set; }

    [Tab("Ceco")]
    public string CecoFarmacias { get; set; }
    public string CecoConsultorio { get; set; }
    public string CecoEcommerce { get; set; }
    
    [Tab("Market")]
    public string MarketCluster { get; set; }
    public string MarketDaily { get; set; }
    public string DailyMarketOrder { get; set; }
}