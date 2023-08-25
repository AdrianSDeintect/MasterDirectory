using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Expansion.Forms;

[FormScript("Expansion.CatalogosExpansion")]
[BasedOnRow(typeof(CatalogosExpansionRow), CheckNames = true)]
public class CatalogosExpansionForm
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