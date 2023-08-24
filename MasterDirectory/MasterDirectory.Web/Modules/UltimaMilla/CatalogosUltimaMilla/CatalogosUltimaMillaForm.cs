using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.UltimaMilla.Forms;

[FormScript("UltimaMilla.CatalogosUltimaMilla")]
[BasedOnRow(typeof(CatalogosUltimaMillaRow), CheckNames = true)]
public class CatalogosUltimaMillaForm
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