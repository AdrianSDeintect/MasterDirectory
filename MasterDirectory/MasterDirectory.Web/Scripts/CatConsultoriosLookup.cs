namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Consultorios;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("CatConsultoriosLookup", Permission = "*")]
    public class CatConsultoriosLookup : RowLookupScript<CatalogosConsultoriosRow>
    {
        private static CatalogosConsultoriosRow.RowFields fld => CatalogosConsultoriosRow.Fields;

        public CatConsultoriosLookup(ISqlConnections sqlConnections) : base(sqlConnections)
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
