using MasterDirectory.Web.Modules.Operaciones;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Operaciones;

[ConnectionKey("Default"), Module("Operaciones"), TableName("CatOperaciones")]
[DisplayName("Categoria Operaciones"), InstanceName("Categoria Operaciones")]
[ReadPermission(OperacionesPermissionKeys.View)]
[ModifyPermission(OperacionesPermissionKeys.Modify)]
[DeletePermission(OperacionesPermissionKeys.Delete)]
public sealed class CategoriaOperacionesRow : Row<CategoriaOperacionesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [LookupEditor(typeof(CatOperacionesLookup), FilterField = "IdtipoCatalogo", FilterValue = 50), LookupInclude]
    [Column("Region"), DisplayName("Región"), Size(5)]
    public string Region
    {
        get => fields.Region[this];
        set => fields.Region[this] = value;
    }

    [LookupEditor(typeof(CatOperacionesLookup), FilterField = "IdtipoCatalogo", FilterValue = 51), LookupInclude]
    [Column("EdoLocal"), DisplayName("Estado Local"), Size(50)]
    public string EdoLocal
    {
        get => fields.EdoLocal[this];
        set => fields.EdoLocal[this] = value;
    }

    [LookupEditor(typeof(CatOperacionesLookup), FilterField = "IdtipoCatalogo", FilterValue = 52), LookupInclude]
    [DisplayName("Zona"), Size(100)]
    public string Zona
    {
        get => fields.Zona[this];
        set => fields.Zona[this] = value;
    }

    [LookupEditor(typeof(CatOperacionesLookup), FilterField = "IdtipoCatalogo", FilterValue = 53), LookupInclude]
    [DisplayName("GEO"), Column("Geo"), Size(100)]
    public string Geo
    {
        get => fields.Geo[this];
        set => fields.Geo[this] = value;
    }

    [Column("MailGeo"), DisplayName("email GEO"), Size(100)]
    public string MailGeo
    {
        get => fields.MailGeo[this];
        set => fields.MailGeo[this] = value;
    }

    [LookupEditor(typeof(CatOperacionesLookup), FilterField = "IdtipoCatalogo", FilterValue = 54), LookupInclude]
    [DisplayName("Director Regional"), Size(100)]
    public string DirectorRegional
    {
        get => fields.DirectorRegional[this];
        set => fields.DirectorRegional[this] = value;
    }

    [DisplayName("Horario L-V"), Column("HorarioLV"), Size(50)]
    public string HorarioLv
    {
        get => fields.HorarioLv[this];
        set => fields.HorarioLv[this] = value;
    }

    [DisplayName("Horario Sabado"), Column("HorarioS"), Size(50)]
    public string HorarioS
    {
        get => fields.HorarioS[this];
        set => fields.HorarioS[this] = value;
    }

    [DisplayName("Horario Domingo y Festivos"), Column("HorarioDyF"), Size(50)]
    public string HorarioDyF
    {
        get => fields.HorarioDyF[this];
        set => fields.HorarioDyF[this] = value;
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
        public StringField Region;
        public StringField EdoLocal;
        public StringField Zona;
        public StringField Geo;
        public StringField MailGeo;
        public StringField DirectorRegional;
        public StringField HorarioLv;
        public StringField HorarioS;
        public StringField HorarioDyF;
        //public DateTimeField DtRegistro;

    }
}