using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Finanzas.Columns;

[ColumnsScript("Finanzas.CategoriaFinanzas")]
[BasedOnRow(typeof(CategoriaFinanzasRow), CheckNames = true)]
public class CategoriaFinanzasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Mercado { get; set; }
    public DateTime FechaCierre { get; set; }
    public string EstatusFarmacia { get; set; }
    public string Top360 { get; set; }
    public string MarketCluster { get; set; }
    public string TopMkt { get; set; }
    public string MarketDaily { get; set; }
    public string DailyMarketOrder { get; set; }
    public string RegionCluster { get; set; }
    public string Top550 { get; set; }
    public string KeyState { get; set; }
    public string CecoFarmacias { get; set; }
    public string CecoConsultorio { get; set; }
    public string CecoEcommerce { get; set; }
    //public DateTime DtRegistro { get; set; }
}