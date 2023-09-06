namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Digital;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatDigitalLookup", Permission = "*")]
    public class CatDigitalLookup : RowLookupScript<CatalogosDigitalRow>
    {
        private static CatalogosDigitalRow.RowFields fld => CatalogosDigitalRow.Fields;

        public CatDigitalLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
