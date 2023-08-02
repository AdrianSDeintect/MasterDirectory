using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Merchandising.Forms;

[FormScript("Merchandising.CatalogosMerchandising")]
[BasedOnRow(typeof(CatalogosMerchandisingRow), CheckNames = true)]
public class CatalogosMerchandisingForm
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