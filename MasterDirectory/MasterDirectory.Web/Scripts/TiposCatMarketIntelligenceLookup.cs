namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Catalogos;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("TiposCatMarketIntelligenceLookup", Permission = "*")]
    public class TiposCatMarketIntelligenceLookup : RowLookupScript<TipoCatalogosRow>
    {
        private static TipoCatalogosRow.RowFields fld => TipoCatalogosRow.Fields;

        public TiposCatMarketIntelligenceLookup(ISqlConnections sqlConnections) : base(sqlConnections)
        {
            IdField = fld.IdtipoCatalogo.PropertyName;
            TextField = fld.TipoCatalogo.PropertyName;
        }
        protected override void PrepareQuery(SqlQuery query)
        {
            query
             .Select(fld.IdtipoCatalogo)
             .Select(fld.TipoCatalogo)
             .Where(fld.Activo == 1)
             .Where(fld.IdtipoCategoria == 13);
        }

    }
}
