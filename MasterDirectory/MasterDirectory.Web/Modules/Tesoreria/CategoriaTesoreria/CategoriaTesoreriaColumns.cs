using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Tesoreria.Columns;

[ColumnsScript("Tesoreria.CategoriaTesoreria")]
[BasedOnRow(typeof(CategoriaTesoreriaRow), CheckNames = true)]
public class CategoriaTesoreriaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Cajero { get; set; }
    //public DateTime DtRegistro { get; set; }
}