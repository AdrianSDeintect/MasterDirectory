using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Comerciales.Forms;

[FormScript("Comerciales.CatalogosComerciales")]
[BasedOnRow(typeof(CatalogosComercialesRow), CheckNames = true)]
public class CatalogosComercialesForm
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