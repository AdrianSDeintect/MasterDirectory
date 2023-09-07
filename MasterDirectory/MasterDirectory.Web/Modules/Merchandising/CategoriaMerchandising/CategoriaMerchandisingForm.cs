using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Merchandising.Forms;

[FormScript("Merchandising.CategoriaMerchandising")]
[BasedOnRow(typeof(CategoriaMerchandisingRow), CheckNames = true)]
public class CategoriaMerchandisingForm
{
    [Tab("General")]
    //[LookupEditor("CatMerchandising")]
    public string LocalSap { get; set; }
    public int TipoSucursal { get; set; }
    public string RutaDli { get; set; }
    public int TipoSenalizacion { get; set; }
    public int ScreenDisplay { get; set; }
    public int TramosLisos { get; set; }
    public int Checkout { get; set; }
    public string RampaDiscapa { get; set; }

    [Tab("Medidas")]

    public int M2Calc { get; set; }
    public int MedidaCabecera { get; set; }
    public int EndCap { get; set; }
    public int MedidaGrafico { get; set; }
    public int BusStop { get; set; }
    public int Aretes { get; set; }
    public int CabecerasInstitucionales { get; set; }

    [Tab("Exhibidores")]

    public int ExhibidorRetail { get; set; }
    public int ExhibidorGloblaBrands { get; set; }
    public int ExhibidorWellBeginnings { get; set; }
    public int ExhibidorInstitucional { get; set; }
    public int ExhibidorMascarillas { get; set; }
    public int ExhibidorGenerico { get; set; }

    [Tab("Tamaños")]

    public int TamanoMiniheders { get; set; }
    public int TamanoHeader { get; set; }
    public int MedidasPecheras { get; set; }
    public int MedidaCopete { get; set; }
    public string MedidasCanceleria { get; set; }
    public int TramosFarma { get; set; }
    public int PortaposterCanceleria { get; set; }
}