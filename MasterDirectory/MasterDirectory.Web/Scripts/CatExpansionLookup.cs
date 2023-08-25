namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Expansion;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatExpansionLookup", Permission = "*")]
    public class CatExpansionLookup : RowLookupScript<CatalogosExpansionRow>
    {
        private static CatalogosExpansionRow.RowFields fld => CatalogosExpansionRow.Fields;

        public CatExpansionLookup(ISqlConnections sqlConnections) : base(sqlConnections)
        {
            IdField = fld.Descripcion.PropertyName;
            TextField = fld.Descripcion.PropertyName;
        }
        protected override void PrepareQuery(SqlQuery query)
        {
            query
             .Select(fld.IdCons)
             .Select(fld.Descripcion, fld.IdtipoCatalogo)
             .Where(fld.Activo == 1);
        }

    }
}
