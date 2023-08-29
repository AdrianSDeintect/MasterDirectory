using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Inmobiliaria.Forms;

[FormScript("Inmobiliaria.CatalogosInmobiliaria")]
[BasedOnRow(typeof(CatalogosInmobiliariaRow), CheckNames = true)]
public class CatalogosInmobiliariaForm
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