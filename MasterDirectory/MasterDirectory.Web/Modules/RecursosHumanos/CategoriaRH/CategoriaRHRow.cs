using MasterDirectory.Web.Modules.RecursosHumanos;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.RecursosHumanos;

[ConnectionKey("Default"), Module("RecursosHumanos"), TableName("CatRH")]
[DisplayName("Categoria RH"), InstanceName("Categoria RH")]
[ReadPermission(RecursosHumanosPermissionKeys.View)]
[ModifyPermission(RecursosHumanosPermissionKeys.Modify)]
[DeletePermission(RecursosHumanosPermissionKeys.Delete)]
public sealed class CategoriaRHRow : Row<CategoriaRHRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Plantilla"), Size(10)]
    public string Plantilla
    {
        get => fields.Plantilla[this];
        set => fields.Plantilla[this] = value;
    }

    [DisplayName("Vacantes"), Size(10)]
    public string Vacantes
    {
        get => fields.Vacantes[this];
        set => fields.Vacantes[this] = value;
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
        public StringField Plantilla;
        public StringField Vacantes;
        //public DateTimeField DtRegistro;

    }
}