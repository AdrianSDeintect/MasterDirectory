using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Consultorios.Columns;

[ColumnsScript("Consultorios.CategoriaConsultorios")]
[BasedOnRow(typeof(CategoriaConsultoriosRow), CheckNames = true)]
public class CategoriaConsultoriosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string ConsulOperacion { get; set; }
    public string Benamedic { get; set; }
    public string HorarioLv { get; set; }
    public string HorarioS { get; set; }
    public string HorarioD { get; set; }
    public string RampaDiscapa { get; set; }
    //public DateTime DtRegistro { get; set; }
}