using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Catalogos.Columns;

[ColumnsScript("Catalogos.TipoCategorias")]
[BasedOnRow(typeof(TipoCategoriasRow), CheckNames = true)]
public class TipoCategoriasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdtipoCategoria { get; set; }
    [EditLink]
    public string TipoCategoria { get; set; }
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}