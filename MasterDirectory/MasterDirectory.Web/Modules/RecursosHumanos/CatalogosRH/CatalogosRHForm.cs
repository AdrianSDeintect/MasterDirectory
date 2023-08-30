using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.RecursosHumanos.Forms;

[FormScript("RecursosHumanos.CatalogosRH")]
[BasedOnRow(typeof(CatalogosRHRow), CheckNames = true)]
public class CatalogosRHForm
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