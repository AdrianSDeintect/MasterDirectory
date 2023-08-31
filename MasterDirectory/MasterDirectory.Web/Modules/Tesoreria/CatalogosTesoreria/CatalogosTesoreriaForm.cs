using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Tesoreria.Forms;

[FormScript("Tesoreria.CatalogosTesoreria")]
[BasedOnRow(typeof(CatalogosTesoreriaRow), CheckNames = true)]
public class CatalogosTesoreriaForm
{
    [Editable(false)]
    public int IdtipoCatalogo { get; set; }
    [Editable(false)]
    public int IdClave { get; set; }
    public string Descripcion { get; set; }
    [BooleanEditor]
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}