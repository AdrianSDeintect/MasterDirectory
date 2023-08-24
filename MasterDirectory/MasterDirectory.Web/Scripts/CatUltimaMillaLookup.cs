namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Finanzas;
    using MasterDirectory.UltimaMilla;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatUltimaMillaLookup", Permission = "*")]
    public class CatUltimaMillaLookup : RowLookupScript<CatalogosUltimaMillaRow>
    {
        private static CatalogosUltimaMillaRow.RowFields fld => CatalogosUltimaMillaRow.Fields;

        public CatUltimaMillaLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
