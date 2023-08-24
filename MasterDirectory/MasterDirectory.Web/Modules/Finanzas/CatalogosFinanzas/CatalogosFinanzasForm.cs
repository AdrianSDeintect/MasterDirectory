using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Finanzas.Forms;

[FormScript("Finanzas.CatalogosFinanzas")]
[BasedOnRow(typeof(CatalogosFinanzasRow), CheckNames = true)]
public class CatalogosFinanzasForm
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