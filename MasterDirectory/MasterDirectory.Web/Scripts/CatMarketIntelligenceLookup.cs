namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.MarketIntelligence;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatMarketIntelligenceLookup", Permission = "*")]
    public class CatMarketIntelligenceLookup : RowLookupScript<CatalogosMarketIntelligenceRow>
    {
        private static CatalogosMarketIntelligenceRow.RowFields fld => CatalogosMarketIntelligenceRow.Fields;

        public CatMarketIntelligenceLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
            //.Where(fld.);
        }

    }
}
