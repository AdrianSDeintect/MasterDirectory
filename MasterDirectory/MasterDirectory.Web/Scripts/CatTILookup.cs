namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.TecnologiasInformacion;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatTILookup", Permission = "*")]
    public class CatTILookup : RowLookupScript<CatalogosTIRow>
    {
        private static CatalogosTIRow.RowFields fld => CatalogosTIRow.Fields;

        public CatTILookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
