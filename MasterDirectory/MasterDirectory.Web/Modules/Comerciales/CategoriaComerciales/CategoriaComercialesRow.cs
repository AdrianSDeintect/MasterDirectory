using MasterDirectory.Web.Modules.Comerciales;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Comerciales;

[ConnectionKey("Default"), Module("Comerciales"), TableName("CatComerciales")]
[DisplayName("Categoria Comerciales"), InstanceName("Categoria Comerciales")]
[ReadPermission(ComercialesPermissionKeys.View)]
[ModifyPermission(ComercialesPermissionKeys.Modify)]
[DeletePermission(ComercialesPermissionKeys.Delete)]
public sealed class CategoriaComercialesRow : Row<CategoriaComercialesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("M2 PDV"), Column("M2PDV"), Size(20)]
    public string M2Pdv
    {
        get => fields.M2Pdv[this];
        set => fields.M2Pdv[this] = value;
    }

    [DisplayName("M2 Local"), Size(20)]
    public string M2Local
    {
        get => fields.M2Local[this];
        set => fields.M2Local[this] = value;
    }

    [DisplayName("Total Espacio Exhibidores Farmacia"), Column("TotEspacioExhibFarm"), Size(15)]
    public string TotEspacioExhibFarm
    {
        get => fields.TotEspacioExhibFarm[this];
        set => fields.TotEspacioExhibFarm[this] = value;
    }

    [DisplayName("Tiras de Impulso"), Column("TirasImpulso"), Size(15)]
    public string TirasImpulso
    {
        get => fields.TirasImpulso[this];
        set => fields.TirasImpulso[this] = value;
    }

    [DisplayName("Islas"), Size(15)]
    public string Islas
    {
        get => fields.Islas[this];
        set => fields.Islas[this] = value;
    }

    [DisplayName("Exhibidor de Mostrador"), Column("ExhibMostrador"), Size(15)]
    public string ExhibMostrador
    {
        get => fields.ExhibMostrador[this];
        set => fields.ExhibMostrador[this] = value;
    }

    [DisplayName("HP1"), Column("HP1"), Size(15)]
    public string Hp1
    {
        get => fields.Hp1[this];
        set => fields.Hp1[this] = value;
    }

    [DisplayName("HP2"), Column("HP2"), Size(15)]
    public string Hp2
    {
        get => fields.Hp2[this];
        set => fields.Hp2[this] = value;
    }

    [DisplayName("HP3"), Column("HP3"), Size(15)]
    public string Hp3
    {
        get => fields.Hp3[this];
        set => fields.Hp3[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 56), LookupInclude]
    [DisplayName("Medida Cabecera"), Size(50)]
    public string MedidaCabecera
    {
        get => fields.MedidaCabecera[this];
        set => fields.MedidaCabecera[this] = value;
    }

    [DisplayName("Cajonera"), Size(15)]
    public string Cajonera
    {
        get => fields.Cajonera[this];
        set => fields.Cajonera[this] = value;
    }

    [DisplayName("Tramos Cajonera"), Size(15)]
    public string TramosCajonera
    {
        get => fields.TramosCajonera[this];
        set => fields.TramosCajonera[this] = value;
    }

    [DisplayName("Mueble de Genéricos"), Column("MuebleGenericos"), Size(15)]
    public string MuebleGenericos
    {
        get => fields.MuebleGenericos[this];
        set => fields.MuebleGenericos[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 57), LookupInclude]
    [DisplayName("Refri Mostrador Farma"), Size(50)]
    public string RefriMostradorFarma
    {
        get => fields.RefriMostradorFarma[this];
        set => fields.RefriMostradorFarma[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 58), LookupInclude]
    [DisplayName("Refrigerador 4 puertas"), Column("Refri4puertas"), Size(50)]
    public string Refri4puertas
    {
        get => fields.Refri4puertas[this];
        set => fields.Refri4puertas[this] = value;
    }

    [DisplayName("Tabaquera"), Size(15)]
    public string Tabaquera
    {
        get => fields.Tabaquera[this];
        set => fields.Tabaquera[this] = value;
    }

    [DisplayName("Tabletas FujiFilm"), Column("TabletasFujiFilm"), Size(15)]
    public string TabletasFujiFilm
    {
        get => fields.TabletasFujiFilm[this];
        set => fields.TabletasFujiFilm[this] = value;
    }

    [DisplayName("Kioscos"), Size(15)]
    public string Kioscos
    {
        get => fields.Kioscos[this];
        set => fields.Kioscos[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 59), LookupInclude]
    [DisplayName("No.7"), Column("No7"), Size(25)]
    public string No7
    {
        get => fields.No7[this];
        set => fields.No7[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 60), LookupInclude]
    [DisplayName("Soap & Glory"), Column("SoapYGlory"), Size(70)]
    public string SoapYGlory
    {
        get => fields.SoapYGlory[this];
        set => fields.SoapYGlory[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 61), LookupInclude]
    [DisplayName("Tramos Dermo"), Size(50)]
    public string TramosDermo
    {
        get => fields.TramosDermo[this];
        set => fields.TramosDermo[this] = value;
    }

    [LookupEditor(typeof(CatComercialesLookup), FilterField = "IdtipoCatalogo", FilterValue = 62), LookupInclude]
    [DisplayName("Tempo Farma"), Size(100)]
    public string TempoFarma
    {
        get => fields.TempoFarma[this];
        set => fields.TempoFarma[this] = value;
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
        public StringField M2Pdv;
        public StringField M2Local;
        public StringField TotEspacioExhibFarm;
        public StringField TirasImpulso;
        public StringField Islas;
        public StringField ExhibMostrador;
        public StringField Hp1;
        public StringField Hp2;
        public StringField Hp3;
        public StringField MedidaCabecera;
        public StringField Cajonera;
        public StringField TramosCajonera;
        public StringField MuebleGenericos;
        public StringField RefriMostradorFarma;
        public StringField Refri4puertas;
        public StringField Tabaquera;
        public StringField TabletasFujiFilm;
        public StringField Kioscos;
        public StringField No7;
        public StringField SoapYGlory;
        public StringField TramosDermo;
        public StringField TempoFarma;
        //public DateTimeField DtRegistro;

    }
}