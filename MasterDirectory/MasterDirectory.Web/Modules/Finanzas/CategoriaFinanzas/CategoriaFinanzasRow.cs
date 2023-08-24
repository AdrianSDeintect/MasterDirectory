using MasterDirectory.Web.Modules.Finanzas;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Finanzas;

[ConnectionKey("Default"), Module("Finanzas"), TableName("CatFinanzas")]
[DisplayName("Categoria Finanzas"), InstanceName("Categoria Finanzas")]
//[ReadPermission(FinanzasPermissionKeys.Finanzas)]
//[ModifyPermission(FinanzasPermissionKeys.Finanzas)]

[ReadPermission(FinanzasPermissionKeys.View)]
[ModifyPermission(FinanzasPermissionKeys.Modify)]
[DeletePermission(FinanzasPermissionKeys.Delete)]

public sealed class CategoriaFinanzasRow : Row<CategoriaFinanzasRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Mercado"), Size(250)]
    public string Mercado
    {
        get => fields.Mercado[this];
        set => fields.Mercado[this] = value;
    }

    [DisplayName("Fecha Cierre")]
    public DateTime? FechaCierre
    {
        get => fields.FechaCierre[this];
        set => fields.FechaCierre[this] = value;
    }

    [DisplayName("Estatus Farmacia"), Column("EstatusFarmacia"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 25), LookupInclude]
    public string EstatusFarmacia
    {
        get => fields.EstatusFarmacia[this];
        set => fields.EstatusFarmacia[this] = value;
    }

    [DisplayName("Top 360"), Column("Top360"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 26), LookupInclude]
    public string Top360
    {
        get => fields.Top360[this];
        set => fields.Top360[this] = value;
    }

    [DisplayName("Market Cluster"), Size(250)]
    public string MarketCluster
    {
        get => fields.MarketCluster[this];
        set => fields.MarketCluster[this] = value;
    }

    [DisplayName("Top Mkt"), Column("TopMkt"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 27), LookupInclude]
    public string TopMkt
    {
        get => fields.TopMkt[this];
        set => fields.TopMkt[this] = value;
    }

    [DisplayName("Market Daily"), Column("MarketDaily"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 28), LookupInclude]
    public string MarketDaily
    {
        get => fields.MarketDaily[this];
        set => fields.MarketDaily[this] = value;
    }

    [DisplayName("Daily Market Order"), Size(250)]
    public string DailyMarketOrder
    {
        get => fields.DailyMarketOrder[this];
        set => fields.DailyMarketOrder[this] = value;
    }

    [DisplayName("Region Cluster"), Size(250)]
    public string RegionCluster
    {
        get => fields.RegionCluster[this];
        set => fields.RegionCluster[this] = value;
    }

    [DisplayName("Top 550"), Column("Top550"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 29), LookupInclude]
    public string Top550
    {
        get => fields.Top550[this];
        set => fields.Top550[this] = value;
    }

    [DisplayName("Key State"), Column("KeyState"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatFinanzasLookup), FilterField = "IdtipoCatalogo", FilterValue = 30), LookupInclude]
    public string KeyState
    {
        get => fields.KeyState[this];
        set => fields.KeyState[this] = value;
    }

    [DisplayName("Ceco Farmacias"), Column("CECOFarmacias"), Size(250)]
    public string CecoFarmacias
    {
        get => fields.CecoFarmacias[this];
        set => fields.CecoFarmacias[this] = value;
    }

    [DisplayName("Ceco Consultorio"), Column("CECOConsultorio"), Size(250)]
    public string CecoConsultorio
    {
        get => fields.CecoConsultorio[this];
        set => fields.CecoConsultorio[this] = value;
    }

    [DisplayName("Ceco Ecommerce"), Column("CECOEcommerce"), Size(250)]
    public string CecoEcommerce
    {
        get => fields.CecoEcommerce[this];
        set => fields.CecoEcommerce[this] = value;
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
        public StringField Mercado;
        public DateTimeField FechaCierre;
        public StringField EstatusFarmacia;
        public StringField Top360;
        public StringField MarketCluster;
        public StringField TopMkt;
        public StringField MarketDaily;
        public StringField DailyMarketOrder;
        public StringField RegionCluster;
        public StringField Top550;
        public StringField KeyState;
        public StringField CecoFarmacias;
        public StringField CecoConsultorio;
        public StringField CecoEcommerce;
        //public DateTimeField DtRegistro;

    }
}