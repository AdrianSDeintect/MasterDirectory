using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Catalogos.Forms;

[FormScript("Catalogos.TipoCategorias")]
[BasedOnRow(typeof(TipoCategoriasRow), CheckNames = true)]
public class TipoCategoriasForm
{
    public string TipoCategoria { get; set; }
    [BooleanEditor]
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}