namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.RecursosHumanos;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatRHLookup", Permission = "*")]
    public class CatRHLookup : RowLookupScript<CatalogosRHRow>
    {
        private static CatalogosRHRow.RowFields fld => CatalogosRHRow.Fields;

        public CatRHLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
