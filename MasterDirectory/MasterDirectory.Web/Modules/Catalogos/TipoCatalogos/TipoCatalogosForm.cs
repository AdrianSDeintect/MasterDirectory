using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Catalogos.Forms;

[FormScript("Catalogos.TipoCatalogos")]
[BasedOnRow(typeof(TipoCatalogosRow), CheckNames = true)]
public class TipoCatalogosForm
{
    public int IdtipoCategoria { get; set; }
    public int IdtipoCatalogo { get; set; }
    public string TipoCatalogo { get; set; }
    [BooleanEditor]
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}