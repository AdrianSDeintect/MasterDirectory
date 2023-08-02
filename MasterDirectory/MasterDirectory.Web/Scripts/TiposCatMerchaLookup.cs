namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Catalogos;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("TiposCatMerchaLookup", Permission = "*")]
    public class TiposCatMerchaLookup : RowLookupScript<TipoCatalogosRow>
    {
        private static TipoCatalogosRow.RowFields fld => TipoCatalogosRow.Fields;

        public TiposCatMerchaLookup(ISqlConnections sqlConnections) : base(sqlConnections)
        {
            IdField = fld.IdtipoCatalogo.PropertyName;
            TextField = fld.TipoCatalogo.PropertyName;
        }
        protected override void PrepareQuery(SqlQuery query)
        {
            query
             .Select(fld.IdtipoCatalogo)
             .Select(fld.TipoCatalogo)
             .Where(fld.Activo == 1);
        }

    }
}
