using MasterDirectory.Catalogos;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Merchandising.Columns;

[ColumnsScript("Merchandising.CatalogosMerchandising")]
[BasedOnRow(typeof(CatalogosMerchandisingRow), CheckNames = true)]
public class CatalogosMerchandisingColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCons { get; set; }
    [LookupEditor(typeof(TiposCatMerchaLookup)), QuickFilter, Hidden]
    public int IdtipoCatalogo { get; set; }
      //[LookupEditor(typeof(CatalogosMerchandisingLookup)), QuickFilter]
    public string NombreTipoCatalogo { get; set; }
    public int IdClave { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}