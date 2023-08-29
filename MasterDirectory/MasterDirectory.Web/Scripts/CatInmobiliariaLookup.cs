namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Inmobiliaria;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatInmobiliarioLookup", Permission = "*")]
    public class CatInmobiliariaLookup : RowLookupScript<CatalogosInmobiliariaRow>
    {
        private static CatalogosInmobiliariaRow.RowFields fld => CatalogosInmobiliariaRow.Fields;

        public CatInmobiliariaLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
