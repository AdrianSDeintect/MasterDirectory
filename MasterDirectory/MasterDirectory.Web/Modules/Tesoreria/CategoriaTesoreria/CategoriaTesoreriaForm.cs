using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Tesoreria.Forms;

[FormScript("Tesoreria.CategoriaTesoreria")]
[BasedOnRow(typeof(CategoriaTesoreriaRow), CheckNames = true)]
public class CategoriaTesoreriaForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Cajero { get; set; }
    //public DateTime DtRegistro { get; set; }
}