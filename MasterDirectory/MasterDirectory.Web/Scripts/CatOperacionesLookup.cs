namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Operaciones;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatOperacionesLookup", Permission = "*")]
    public class CatOperacionesLookup : RowLookupScript<CatalogosOperacionesRow>
    {
        private static CatalogosOperacionesRow.RowFields fld => CatalogosOperacionesRow.Fields;

        public CatOperacionesLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
