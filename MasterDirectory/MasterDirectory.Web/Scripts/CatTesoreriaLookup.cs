namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Tesoreria;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatTesoreriaLookup", Permission = "*")]
    public class CatTesoreriaLookup : RowLookupScript<CatalogosTesoreriaRow>
    {
        private static CatalogosTesoreriaRow.RowFields fld => CatalogosTesoreriaRow.Fields;

        public CatTesoreriaLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
