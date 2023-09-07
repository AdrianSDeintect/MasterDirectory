using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.MarketIntelligence.Forms;

[FormScript("MarketIntelligence.CatalogosMarketIntelligence")]
[BasedOnRow(typeof(CatalogosMarketIntelligenceRow), CheckNames = true)]
public class CatalogosMarketIntelligenceForm
{
    [Editable(false)]
    public int IdtipoCatalogo { get; set; }
    [Editable(false)]
    public int IdClave { get; set; }
    public string Descripcion { get; set; }
    [BooleanEditor]
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}