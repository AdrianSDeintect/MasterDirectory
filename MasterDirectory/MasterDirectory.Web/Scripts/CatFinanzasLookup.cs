namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Finanzas;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatFinanzasLookup", Permission = "*")]
    public class CatFinanzasLookup : RowLookupScript<CatalogosFinanzasRow>
    {
        private static CatalogosFinanzasRow.RowFields fld => CatalogosFinanzasRow.Fields;

        public CatFinanzasLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
