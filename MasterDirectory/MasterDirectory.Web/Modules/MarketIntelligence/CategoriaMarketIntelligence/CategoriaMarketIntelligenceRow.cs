using MasterDirectory.Web.Modules.MarketIntelligence;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.MarketIntelligence;

[ConnectionKey("Default"), Module("MarketIntelligence"), TableName("CatMarketIntelligence")]
[DisplayName("Categoria Market Intelligence"), InstanceName("Categoria Market Intelligence")]
[ReadPermission(MarketIntelligencePermissionKeys.View)]
[ModifyPermission(MarketIntelligencePermissionKeys.Modify)]
[DeletePermission(MarketIntelligencePermissionKeys.Delete)]
public sealed class CategoriaMarketIntelligenceRow : Row<CategoriaMarketIntelligenceRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [LookupEditor(typeof(CatMarketIntelligenceLookup), FilterField = "IdtipoCatalogo", FilterValue = 63), LookupInclude]
    [DisplayName("NSE"), Column("NSE"), Size(10)]
    public string Nse
    {
        get => fields.Nse[this];
        set => fields.Nse[this] = value;
    }

    [LookupEditor(typeof(CatMarketIntelligenceLookup), FilterField = "IdtipoCatalogo", FilterValue = 64), LookupInclude]
    [DisplayName("Cluster"), Size(15)]
    public string Cluster
    {
        get => fields.Cluster[this];
        set => fields.Cluster[this] = value;
    }

    [DisplayName("Brick"), Size(20)]
    public string Brick
    {
        get => fields.Brick[this];
        set => fields.Brick[this] = value;
    }

    //[DisplayName("Dt Registro"), Column("dtRegistro"), NotNull]
    //public DateTime? DtRegistro
    //{
    //    get => fields.DtRegistro[this];
    //    set => fields.DtRegistro[this] = value;
    //}

    public class RowFields : RowFieldsBase
    {
        public StringField LocalSap;
        public StringField Nse;
        public StringField Cluster;
        public StringField Brick;
        //public DateTimeField DtRegistro;

    }
}