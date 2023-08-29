using MasterDirectory.Web.Modules.Inmobiliaria;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Inmobiliaria;

[ConnectionKey("Default"), Module("Inmobiliaria"), TableName("CatInmobiliaria")]
[DisplayName("Categoria Inmobiliaria"), InstanceName("Categoria Inmobiliaria")]
[ReadPermission(InmobiliariaPermissionKeys.View)]
[ModifyPermission(InmobiliariaPermissionKeys.Modify)]
[DeletePermission(InmobiliariaPermissionKeys.Delete)]
public sealed class CategoriaInmobiliariaRow : Row<CategoriaInmobiliariaRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Farmacia"), Size(70)]
    public string Farmacia
    {
        get => fields.Farmacia[this];
        set => fields.Farmacia[this] = value;
    }

    [DisplayName("Colonia"), Size(250)]
    public string Colonia
    {
        get => fields.Colonia[this];
        set => fields.Colonia[this] = value;
    }

    [DisplayName("Fecha Apertura")]
    public DateTime? FechaApertura
    {
        get => fields.FechaApertura[this];
        set => fields.FechaApertura[this] = value;
    }

    [LookupEditor(typeof(CatInmobiliariaLookup), FilterField = "IdtipoCatalogo", FilterValue = 48), LookupInclude]
    [DisplayName("Accesos"), Size(50)]
    public string Accesos
    {
        get => fields.Accesos[this];
        set => fields.Accesos[this] = value;
    }

    [LookupEditor(typeof(CatInmobiliariaLookup), FilterField = "IdtipoCatalogo", FilterValue = 49), LookupInclude]
    [DisplayName("Ubicacion"), Size(50)]
    public string Ubicacion
    {
        get => fields.Ubicacion[this];
        set => fields.Ubicacion[this] = value;
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
        public StringField Farmacia;
        public StringField Colonia;
        public DateTimeField FechaApertura;
        public StringField Accesos;
        public StringField Ubicacion;
        //public DateTimeField DtRegistro;

    }
}