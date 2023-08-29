using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Inmobiliaria.Forms;

[FormScript("Inmobiliaria.CategoriaInmobiliaria")]
[BasedOnRow(typeof(CategoriaInmobiliariaRow), CheckNames = true)]
public class CategoriaInmobiliariaForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Farmacia { get; set; }
    public DateTime FechaApertura { get; set; }

    [Tab("Referencias")]
    public string Colonia { get; set; }
    public string Accesos { get; set; }
    public string Ubicacion { get; set; }
    //public DateTime DtRegistro { get; set; }
}