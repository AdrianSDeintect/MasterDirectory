namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Comerciales;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatComercialesLookup", Permission = "*")]
    public class CatComercialesLookup : RowLookupScript<CatalogosComercialesRow>
    {
        private static CatalogosComercialesRow.RowFields fld => CatalogosComercialesRow.Fields;

        public CatComercialesLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
