using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Operaciones.Forms;

[FormScript("Operaciones.CatalogosOperaciones")]
[BasedOnRow(typeof(CatalogosOperacionesRow), CheckNames = true)]
public class CatalogosOperacionesForm
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