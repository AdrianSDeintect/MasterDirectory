using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Digital.Columns;

[ColumnsScript("Digital.CategoriaDigital")]
[BasedOnRow(typeof(CategoriaDigitalRow), CheckNames = true)]
public class CategoriaDigitalColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string DirGoogle { get; set; }
    public string Latitud { get; set; }
    public string Longitud { get; set; }
    public string LinkGoogleMaps { get; set; }
    //public DateTime DtRegistro { get; set; }
}