using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.TecnologiasInformacion.Columns;

[ColumnsScript("TecnologiasInformacion.CatalogosTI")]
[BasedOnRow(typeof(CatalogosTIRow), CheckNames = true)]
public class CatalogosTIColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCons { get; set; }
    [LookupEditor(typeof(TiposCatTILookup)), QuickFilter, Hidden]
    public int IdtipoCatalogo { get; set; }
    public string NombreTipoCatalogo { get; set; }
    public int IdClave { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}