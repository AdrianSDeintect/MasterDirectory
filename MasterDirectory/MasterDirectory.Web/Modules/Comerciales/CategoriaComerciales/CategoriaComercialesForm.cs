using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Comerciales.Forms;

[FormScript("Comerciales.CategoriaComerciales")]
[BasedOnRow(typeof(CategoriaComercialesRow), CheckNames = true)]
public class CategoriaComercialesForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string TotEspacioExhibFarm { get; set; }
    public string TirasImpulso { get; set; }
    public string Hp1 { get; set; }
    public string Hp2 { get; set; }
    public string Hp3 { get; set; }


    [Tab("Objetos Farmacia")]
    public string Tabaquera { get; set; }
    public string TabletasFujiFilm { get; set; }
    public string Kioscos { get; set; }
    public string No7 { get; set; }
    public string ExhibMostrador { get; set; }
    public string Islas { get; set; }


    [Tab("Medidas")]
    public string M2Pdv { get; set; }
    public string M2Local { get; set; }
    public string MedidaCabecera { get; set; }


    [Tab("Refigerador")]
    public string RefriMostradorFarma { get; set; }
    public string Refri4puertas { get; set; }



    [Tab("Muebles")]
    public string Cajonera { get; set; }
    public string TramosCajonera { get; set; }
    public string MuebleGenericos { get; set; }
    public string SoapYGlory { get; set; }
    public string TramosDermo { get; set; }
    public string TempoFarma { get; set; }
    //public DateTime DtRegistro { get; set; }
}