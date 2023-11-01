using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Expansion.Forms;

[FormScript("Expansion.CategoriaExpansion")]
[BasedOnRow(typeof(CategoriaExpansionRow), CheckNames = true)]
public class CategoriaExpansionForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    //public string TipoFarmacia { get; set; }
    public string LocationType { get; set; }
    public string Farmacia { get; set; }
    public DateTime FechaApertura { get; set; }
    public DateTime? Reapertura { get; set; }
    public string Comsuc { get; set; }
    public string TipoEstaciona { get; set; }
    public string NCajonesEstaciona { get; set; }

    [Tab("Ubicacion")]
    public string Ciudad { get; set; }
    public string Estado { get; set; }
    public string Direccion { get; set; }
    public string NExterior { get; set; }
    public string Colonia { get; set; }
    public string Cp { get; set; }
    public string Latitud { get; set; }
    public string Longuitud { get; set; }

    [Tab("Mobiliario")]

    public string FormatoFarmAlcance { get; set; }
    public string Pantallas { get; set; }
    public string ProvMobiliario { get; set; }
    public string ColorMob { get; set; }
    public string Dermo { get; set; }
    //public DateTime DtRegistro { get; set; }
}