using Serenity.ComponentModel;
using System;

namespace MasterDirectory.RecursosHumanos.Forms;

[FormScript("RecursosHumanos.CategoriaRH")]
[BasedOnRow(typeof(CategoriaRHRow), CheckNames = true)]
public class CategoriaRHForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Plantilla { get; set; }
    public string Vacantes { get; set; }
    //public DateTime DtRegistro { get; set; }
}