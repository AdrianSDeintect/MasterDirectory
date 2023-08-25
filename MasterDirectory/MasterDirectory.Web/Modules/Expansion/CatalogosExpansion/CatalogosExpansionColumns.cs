using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.Expansion.Columns;

[ColumnsScript("Expansion.CatalogosExpansion")]
[BasedOnRow(typeof(CatalogosExpansionRow), CheckNames = true)]
public class CatalogosExpansionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCons { get; set; }
    [LookupEditor(typeof(TiposCatExpansionLookup)), QuickFilter, Hidden]
    public int IdtipoCatalogo { get; set; }
    public string NombreTipoCatalogo { get; set; }
    public int IdClave { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}