using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Digital.Forms;

[FormScript("Digital.CategoriaDigital")]
[BasedOnRow(typeof(CategoriaDigitalRow), CheckNames = true)]
public class CategoriaDigitalForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string DirGoogle { get; set; }
    public string Latitud { get; set; }
    public string Longitud { get; set; }
    public string LinkGoogleMaps { get; set; }

    //public DateTime DtRegistro { get; set; }
}