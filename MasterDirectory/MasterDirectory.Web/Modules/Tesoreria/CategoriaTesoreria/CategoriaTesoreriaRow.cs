using MasterDirectory.Web.Modules.Tesoreria;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Tesoreria;

[ConnectionKey("Default"), Module("Tesoreria"), TableName("CatTesoreria")]
[DisplayName("Categoria Tesoreria"), InstanceName("Categoria Tesoreria")]
[ReadPermission(TesoreriaPermissionKeys.View)]
[ModifyPermission(TesoreriaPermissionKeys.Modify)]
[DeletePermission(TesoreriaPermissionKeys.Delete)]
public sealed class CategoriaTesoreriaRow : Row<CategoriaTesoreriaRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }
    [LookupEditor(typeof(CatTesoreriaLookup), FilterField = "IdtipoCatalogo", FilterValue = 55), LookupInclude]
    [DisplayName("Cajero"), Size(15)]
    public string Cajero
    {
        get => fields.Cajero[this];
        set => fields.Cajero[this] = value;
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
        public StringField Cajero;
        //public DateTimeField DtRegistro;

    }
}