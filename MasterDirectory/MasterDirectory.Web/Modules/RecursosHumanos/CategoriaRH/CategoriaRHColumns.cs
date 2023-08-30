using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.RecursosHumanos.Columns;

[ColumnsScript("RecursosHumanos.CategoriaRH")]
[BasedOnRow(typeof(CategoriaRHRow), CheckNames = true)]
public class CategoriaRHColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Plantilla { get; set; }
    public string Vacantes { get; set; }
    //public DateTime DtRegistro { get; set; }
}