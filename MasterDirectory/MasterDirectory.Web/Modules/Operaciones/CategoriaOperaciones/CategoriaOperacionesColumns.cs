using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Operaciones.Columns;

[ColumnsScript("Operaciones.CategoriaOperaciones")]
[BasedOnRow(typeof(CategoriaOperacionesRow), CheckNames = true)]
public class CategoriaOperacionesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Region { get; set; }
    public string EdoLocal { get; set; }
    public string Zona { get; set; }
    public string Geo { get; set; }
    public string MailGeo { get; set; }
    public string DirectorRegional { get; set; }
    public string HorarioLv { get; set; }
    public string HorarioS { get; set; }
    public string HorarioDyF { get; set; }
    //public DateTime DtRegistro { get; set; }
}