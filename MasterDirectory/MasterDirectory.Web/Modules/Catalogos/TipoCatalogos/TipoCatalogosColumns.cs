using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Catalogos.Columns;

[ColumnsScript("Catalogos.TipoCatalogos")]
[BasedOnRow(typeof(TipoCatalogosRow), CheckNames = true)]
public class TipoCatalogosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCons { get; set; }
    [LookupEditor(typeof(TipoCategoriasRow)), QuickFilter, Hidden]
    public int IdtipoCategoria { get; set; }
    public string NombreTipoCategoria { get; set; }
   
    public int IdtipoCatalogo { get; set; }
    [EditLink]
    public string TipoCatalogo { get; set; }
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}