using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Inmobiliaria.Columns;

[ColumnsScript("Inmobiliaria.CategoriaInmobiliaria")]
[BasedOnRow(typeof(CategoriaInmobiliariaRow), CheckNames = true)]
public class CategoriaInmobiliariaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string Farmacia { get; set; }
    public string Colonia { get; set; }
    public DateTime FechaApertura { get; set; }
    public string Accesos { get; set; }
    public string Ubicacion { get; set; }
    //public DateTime DtRegistro { get; set; }
}