using MasterDirectory.Web.Scripts;
using Microsoft.Identity.Client;
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.Security.Policy;

namespace MasterDirectory.Merchandising.Columns;

[ColumnsScript("Merchandising.CatMerchandising")]
[BasedOnRow(typeof(CatMerchandisingRow), CheckNames = true)]
public class CatMerchandisingColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    //public int TipoSenalizacion { get; set; }
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 1), LookupInclude]
    public string NombreTipoSucursal { get; set; }
    public string NombreM2Calc { get; set; }
    public string RutaDli { get; set; }
    public string NombreTipoSenalizacion { get; set; }
    //public int ScreenDisplay { get; set; }
    public string NombreScreenDisplay { get; set; }
    //public int TramosLisos { get; set; }
    public string NombreTramosLisos { get; set; }
    //public int TamanoMiniheders { get; set;  }
    public string NombreTamanoMiniHeader { get; set; }
    //public int TamanoHeader { get; set; }
    public string NombreTamanoHeader { get; set; }
    //public int Checkout { get; set; }
    public string NombreCheckout { get; set; }
    //public int MedidaCabecera { get; set; }
    public string NombreMedidaCabecera { get; set; }
    //public int EndCap { get; set; }
    public string NombreEndCap { get; set; }
    //public int MedidaGrafico { get; set; }
    public string NombreMedidaGrafico { get; set; } 
    //public int BusStop { get; set; }
    public string NombreBusStop { get; set; }
    //public int Aretes { get; set; }
    public string NombreAretes { get; set; }
    //public int ExhibidorRetail { get; set; }
    public string NombreExhibidorRetail { get; set; }
    //public int ExhibidorGloblaBrands { get; set; }
    public string NombreExhibidorGloblaBrands { get; set; }
    //public int ExhibidorWellBeginnings { get; set; }
    public string NombreExhibidorWellBeginnings { get; set; }
    //public int ExhibidorInstitucional { get; set; }
    public string NombreExhibidorInstitucional { get; set; }
    //public int ExhibidorMascarillas { get; set; }
    public string NombreExhibidorMascarillas { get; set; }
    //public int ExhibidorGenerico { get; set; }
    public string NombreCabecerasInstitucionales { get; set; }
    //public int TramosFarma { get; set; }
    public string NombreExhibidorGenerico { get; set; }
    //public int CabecerasInstitucionales { get; set; }
    public string NombreTramosFarma { get; set; }
    //public int PortaposterCanceleria { get; set; }
    public string NombrePortaposterCanceleria { get; set; }
    //public int MedidasPecheras { get; set; }
    public string NombreMedidasPecheras { get; set; }
    public int MedidaCopete { get; set; }
    //public string MedidasCanceleria { get; set; }
    public string NombreMedidasCanceleria { get; set; }
    //public int M2Calc { get; set; }
    
    
    //public int TipoSucursal { get; set; }
    
    //public DateTime DtRegistro { get; set; }
}