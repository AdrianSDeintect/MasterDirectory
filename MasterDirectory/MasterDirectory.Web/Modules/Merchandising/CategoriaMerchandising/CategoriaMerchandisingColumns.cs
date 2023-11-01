using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Merchandising.Columns;

[ColumnsScript("Merchandising.CategoriaMerchandising")]
[BasedOnRow(typeof(CategoriaMerchandisingRow), CheckNames = true)]
public class CategoriaMerchandisingColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string ClasificacionNacional { get; set; }
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 1), LookupInclude]
    public string TipoSucursal { get; set; }
    public string M2Calc { get; set; }
    public string RutaDli { get; set; }
    public string TipoSenalizacion { get; set; }
    public string RampaDiscapa { get; set; }
    public string ScreenDisplay { get; set; }
    public string TramosLisos { get; set; }
    public string TamanoMiniheders { get; set; }
    public string TamanoHeader { get; set; }
    public string Checkout { get; set; }
    public string MedidaCabecera { get; set; }
    public string EndCap { get; set; }
    public string MedidaGrafico { get; set; }
    public string BusStop { get; set; }
    public string Aretes { get; set; }
    public string ExhibidorRetail { get; set; }
    public string ExhibidorGloblaBrands { get; set; }
    public string ExhibidorWellBeginnings { get; set; }
    public string ExhibidorInstitucional { get; set; }
    public string ExhibidorMascarillas { get; set; }
    public string CabecerasInstitucionales { get; set; }
    public string ExhibidorGenerico { get; set; }
    public string TramosFarma { get; set; }
    public string PortaposterCanceleria { get; set; }
    public string MedidasPecheras { get; set; }
    public string MedidaCopete { get; set; }
    public string MedidasCanceleria { get; set; }
    
    
    //public DateTime DtRegistro { get; set; }
}