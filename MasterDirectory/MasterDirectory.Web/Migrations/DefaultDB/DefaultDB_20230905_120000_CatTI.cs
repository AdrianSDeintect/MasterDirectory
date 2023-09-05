using FluentMigrator;
using Serenity.Extensions;
using System;
using System.IO;

namespace MasterDirectory.Migrations.DefaultDB
{
    [Migration(20230905120000)]
    public class DefaultDB_20230905_120000_CatTI : AutoReversingMigration
    {
        private string GetScript(string name)
        {
            using var sr = new StreamReader(GetType().Assembly.GetManifestResourceStream(name));
            return sr.ReadToEnd();
        }
        public override void Up()
        {

            IfDatabase("SqlServer", "SqlServer2000", "SqlServerCe")
          .Execute.Sql(GetScript("MasterDirectory.Web.Migrations.scriptCatTI.sql"));



        }
    }
}