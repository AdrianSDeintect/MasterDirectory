using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Expansion.Columns;

[ColumnsScript("Expansion.CategoriaExpansion")]
[BasedOnRow(typeof(CategoriaExpansionRow), CheckNames = true)]
public class CategoriaExpansionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string TipoFarmacia { get; set; }
    public string LocationType { get; set; }
    public string Reapertura { get; set; }
    public string Comsuc { get; set; }
    public string TipoEstaciona { get; set; }
    public string NCajonesEstaciona { get; set; }
    public string Ciudad { get; set; }
    public string Estado { get; set; }
    public string Direccion { get; set; }
    public string NExterior { get; set; }
    public string Colonia { get; set; }
    public string Cp { get; set; }
    public string Latitud { get; set; }
    public string Longuitud { get; set; }
    public string FormatoFarmAlcance { get; set; }
    public string Pantallas { get; set; }
    public string ProvMobiliario { get; set; }
    public string ColorMob { get; set; }
    public string Dermo { get; set; }
    //public DateTime DtRegistro { get; set; }
}