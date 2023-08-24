namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Merchandising;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatMerchaLookup", Permission = "*")]
    public class CatMerchaLookup: RowLookupScript<CatalogosMerchandisingRow>
    {
        private static CatalogosMerchandisingRow.RowFields fld => CatalogosMerchandisingRow.Fields;

        public CatMerchaLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
