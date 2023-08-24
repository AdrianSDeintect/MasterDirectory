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
        }

        public override string GetScript()
        {
                    return base.GetScript();
        }

    }
}
