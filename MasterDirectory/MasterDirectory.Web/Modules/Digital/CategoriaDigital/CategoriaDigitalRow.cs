using MasterDirectory.Web.Modules.Digital;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Digital;

[ConnectionKey("Default"), Module("Digital"), TableName("CatDigital")]
[DisplayName("Categoria Digital"), InstanceName("Categoria Digital")]
[ReadPermission(DigitalPermissionKeys.View)]
[ModifyPermission(DigitalPermissionKeys.Modify)]
[DeletePermission(DigitalPermissionKeys.Delete)]
public sealed class CategoriaDigitalRow : Row<CategoriaDigitalRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Dirección Google"), Column("DirGoogle") ,Size(250)]
    public string DirGoogle
    {
        get => fields.DirGoogle[this];
        set => fields.DirGoogle[this] = value;
    }

    [DisplayName("Latitud Bruta"), Column("Latitud"), Size(50)]
    public string Latitud
    {
        get => fields.Latitud[this];
        set => fields.Latitud[this] = value;
    }

    [DisplayName("Longitud Bruta"), Column("Longitud"), Size(50)]
    public string Longitud
    {
        get => fields.Longitud[this];
        set => fields.Longitud[this] = value;
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
        public StringField DirGoogle;
        public StringField Latitud;
        public StringField Longitud;
        //public DateTimeField DtRegistro;

    }
}