using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.TecnologiasInformacion.Columns;

[ColumnsScript("TecnologiasInformacion.CategoriaTI")]
[BasedOnRow(typeof(CategoriaTIRow), CheckNames = true)]
public class CategoriaTIColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string UsuarioGeo { get; set; }
    public string Emaillocal { get; set; }
    public string Extension { get; set; }
    public string Telefono { get; set; }
    //public string Nse { get; set; }
    //public string Cluster { get; set; }
    //public string Brick { get; set; }
    //public DateTime DtRegistro { get; set; }
}