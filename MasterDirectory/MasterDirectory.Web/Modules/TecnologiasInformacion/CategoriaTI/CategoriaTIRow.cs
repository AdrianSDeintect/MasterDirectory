using MasterDirectory.Web.Modules.TecnologiasInformacion;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.TecnologiasInformacion;

[ConnectionKey("Default"), Module("TecnologiasInformacion"), TableName("CatTI")]
[DisplayName("Categoria TI"), InstanceName("Categoria TI")]
[ReadPermission(TecnologiasInformacionPermissionKeys.View)]
[ModifyPermission(TecnologiasInformacionPermissionKeys.Modify)]
[DeletePermission(TecnologiasInformacionPermissionKeys.Delete)]
public sealed class CategoriaTIRow : Row<CategoriaTIRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Usuario GEO"), Column("UsuarioGEO"), Size(20)]
    public string UsuarioGeo
    {
        get => fields.UsuarioGeo[this];
        set => fields.UsuarioGeo[this] = value;
    }

    [DisplayName("Email Local"), Column("Emaillocal"), Size(50)]
    public string Emaillocal
    {
        get => fields.Emaillocal[this];
        set => fields.Emaillocal[this] = value;
    }

    [DisplayName("Extension"), Size(10)]
    public string Extension
    {
        get => fields.Extension[this];
        set => fields.Extension[this] = value;
    }

    [DisplayName("Teléfono"), Column("Telefono"), Size(12)]
    public string Telefono
    {
        get => fields.Telefono[this];
        set => fields.Telefono[this] = value;
    }

    [LookupEditor(typeof(CatTILookup), FilterField = "IdtipoCatalogo", FilterValue = 63), LookupInclude]
    [DisplayName("NSE"), Column("NSE"), Size(10)]
    public string Nse
    {
        get => fields.Nse[this];
        set => fields.Nse[this] = value;
    }

    [LookupEditor(typeof(CatTILookup), FilterField = "IdtipoCatalogo", FilterValue = 64), LookupInclude]
    [DisplayName("Cluster"), Size(15)]
    public string Cluster
    {
        get => fields.Cluster[this];
        set => fields.Cluster[this] = value;
    }

    [DisplayName("Brick"), Size(15)]
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
        public StringField UsuarioGeo;
        public StringField Emaillocal;
        public StringField Extension;
        public StringField Telefono;
        public StringField Nse;
        public StringField Cluster;
        public StringField Brick;
        //public DateTimeField DtRegistro;

    }
}