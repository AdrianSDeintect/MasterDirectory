using MasterDirectory.Web.Modules.Expansion;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Expansion;

[ConnectionKey("Default"), Module("Expansion"), TableName("CatExpansion")]
[DisplayName("Categoria Expansion"), InstanceName("Categoria Expansion")]
[ReadPermission(ExpansionPermissionKeys.View)]
[ModifyPermission(ExpansionPermissionKeys.Modify)]
[DeletePermission(ExpansionPermissionKeys.Delete)]
public sealed class CategoriaExpansionRow : Row<CategoriaExpansionRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Tipo Farmacia"), Size(50)]
    [LookupEditor(typeof(CatExpansionLookup), FilterField = "IdtipoCatalogo", FilterValue = 43), LookupInclude]
    public string TipoFarmacia
    {
        get => fields.TipoFarmacia[this];
        set => fields.TipoFarmacia[this] = value;
    }

    [DisplayName("Location Type"), Size(50)]
    [LookupEditor(typeof(CatExpansionLookup), FilterField = "IdtipoCatalogo", FilterValue = 44), LookupInclude]
    public string LocationType
    {
        get => fields.LocationType[this];
        set => fields.LocationType[this] = value;
    }

    [DisplayName("Reapertura"), Size(25)]
    public string Reapertura
    {
        get => fields.Reapertura[this];
        set => fields.Reapertura[this] = value;
    }

    [DisplayName("Comsuc"), Size(50)]
    public string Comsuc
    {
        get => fields.Comsuc[this];
        set => fields.Comsuc[this] = value;
    }

    [Column("TipoEstaciona"), DisplayName("Tipo de Estacionamiento"), Size(100)]
    [LookupEditor(typeof(CatExpansionLookup), FilterField = "IdtipoCatalogo", FilterValue = 45), LookupInclude]
    public string TipoEstaciona
    {
        get => fields.TipoEstaciona[this];
        set => fields.TipoEstaciona[this] = value;
    }

    [Column("NCajonesEstaciona"), DisplayName("N° Cajones Estacionamiento"), Size(10)]
    public string NCajonesEstaciona
    {
        get => fields.NCajonesEstaciona[this];
        set => fields.NCajonesEstaciona[this] = value;
    }

    [DisplayName("Ciudad"), Size(80)]
    public string Ciudad
    {
        get => fields.Ciudad[this];
        set => fields.Ciudad[this] = value;
    }

    [DisplayName("Estado"), Size(60)]
    public string Estado
    {
        get => fields.Estado[this];
        set => fields.Estado[this] = value;
    }

    [DisplayName("Direccion"), Size(250)]
    public string Direccion
    {
        get => fields.Direccion[this];
        set => fields.Direccion[this] = value;
    }

    [Column("NExterior"), DisplayName("No. Exterior"), Size(25)]
    public string NExterior
    {
        get => fields.NExterior[this];
        set => fields.NExterior[this] = value;
    }

    [DisplayName("Colonia"), Size(250)]
    public string Colonia
    {
        get => fields.Colonia[this];
        set => fields.Colonia[this] = value;
    }

    [DisplayName("C.P."), Column("CP"), Size(10)]
    public string Cp
    {
        get => fields.Cp[this];
        set => fields.Cp[this] = value;
    }

    [DisplayName("Latitud"), Size(50)]
    public string Latitud
    {
        get => fields.Latitud[this];
        set => fields.Latitud[this] = value;
    }

    [DisplayName("Longuitud"), Size(50)]
    public string Longuitud
    {
        get => fields.Longuitud[this];
        set => fields.Longuitud[this] = value;
    }

    [Column("FormatoFarmAlcance"), DisplayName("Formato Farmacia - Alcance"), Size(50)]
    [LookupEditor(typeof(CatExpansionLookup), FilterField = "IdtipoCatalogo", FilterValue = 46), LookupInclude]
    public string FormatoFarmAlcance
    {
        get => fields.FormatoFarmAlcance[this];
        set => fields.FormatoFarmAlcance[this] = value;
    }

    [DisplayName("Pantallas"), Size(10)]
    public string Pantallas
    {
        get => fields.Pantallas[this];
        set => fields.Pantallas[this] = value;
    }

    [Column("ProvMobiliario"), DisplayName("Proveedor de Mobiliario"), Size(50)]
    [LookupEditor(typeof(CatExpansionLookup), FilterField = "IdtipoCatalogo", FilterValue = 47), LookupInclude]
    public string ProvMobiliario
    {
        get => fields.ProvMobiliario[this];
        set => fields.ProvMobiliario[this] = value;
    }

    [DisplayName("Color Mob"), Size(60)]
    public string ColorMob
    {
        get => fields.ColorMob[this];
        set => fields.ColorMob[this] = value;
    }

    [DisplayName("Dermo"), Size(25)]
    public string Dermo
    {
        get => fields.Dermo[this];
        set => fields.Dermo[this] = value;
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
        public StringField TipoFarmacia;
        public StringField LocationType;
        public StringField Reapertura;
        public StringField Comsuc;
        public StringField TipoEstaciona;
        public StringField NCajonesEstaciona;
        public StringField Ciudad;
        public StringField Estado;
        public StringField Direccion;
        public StringField NExterior;
        public StringField Colonia;
        public StringField Cp;
        public StringField Latitud;
        public StringField Longuitud;
        public StringField FormatoFarmAlcance;
        public StringField Pantallas;
        public StringField ProvMobiliario;
        public StringField ColorMob;
        public StringField Dermo;
        //public DateTimeField DtRegistro;

    }
}