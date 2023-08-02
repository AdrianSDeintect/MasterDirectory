namespace MasterDirectory.Web.Scripts
{
    using MasterDirectory.Merchandising;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using Serenity.Web;
    using System;
    public class CatMerchaLookupScript<TRow> :
            RowLookupScript<TRow>
            where TRow : class, IRow, new()
    {
        public ITwoLevelCache TwoLevelCache { get; }
        public IUserAccessor UserAccessor { get; }


        public CatMerchaLookupScript(ISqlConnections sqlConnections, ITwoLevelCache twoLevelCache, IUserAccessor userAccessor) : base(sqlConnections)
        {
            Expiration = TimeSpan.FromDays(-1);
            TwoLevelCache = twoLevelCache ?? throw new ArgumentNullException(nameof(twoLevelCache));
            UserAccessor = userAccessor ?? throw new ArgumentNullException(nameof(userAccessor));
        }

        public CatMerchaLookupScript(ISqlConnections sqlConnections) : base(sqlConnections)
        {
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            //AddTenantFilter(query);
        }

        //protected void AddTenantFilter(SqlQuery query)
        //{
        //    var r = new TRow();
        //    query.Where(r.TenantIdField == UserAccessor.User.GetTenantId());
        //}

        public override string GetScript()
        {
            //return TwoLevelCache.GetLocalStoreOnly("MultiTenantLookup:" +
            //        this.ScriptName + ":" +
            //        UserAccessor.User.GetTenantId(),
            //        TimeSpan.FromHours(1),
                //new TRow().GetFields().GenerationKey, () =>
                //{
                    return base.GetScript();
                //});
        }

    }
}
