using MasterDirectory.Web.Modules.UltimaMilla;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.UltimaMilla;

[ConnectionKey("Default"), Module("UltimaMilla"), TableName("CatUltimaMilla")]
[DisplayName("Categoria Ultima Milla"), InstanceName("Categoria Ultima Milla")]
[ReadPermission(UltimaMillaPermissionKeys.View)]
[ModifyPermission(UltimaMillaPermissionKeys.Modify)]
[DeletePermission(UltimaMillaPermissionKeys.Delete)]
public sealed class CategoriaUltimaMillaRow : Row<CategoriaUltimaMillaRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }
    [DisplayName("Venta Telefónica"), Column("VentaTelefonica"), QuickSearch, Size(10)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 31), LookupInclude]
    public string VentaTelefonica
    {
        get => fields.VentaTelefonica[this];
        set => fields.VentaTelefonica[this] = value;
    }

    [DisplayName("Garantizado"), QuickSearch, Size(10)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 32), LookupInclude]
    public string Garantizado
    {
        get => fields.Garantizado[this];
        set => fields.Garantizado[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 33), LookupInclude]
    [DisplayName("HUB"), Column("HUB"), QuickSearch, Size(50)]
    public string Hub
    {
        get => fields.Hub[this];
        set => fields.Hub[this] = value;
    }

    [DisplayName("E-Commerce"), Column("ECommerce"), Size(50)]
    public string ECommerce
    {
        get => fields.ECommerce[this];
        set => fields.ECommerce[this] = value;
    }

    [DisplayName("Tipo E-Comm"), Column("TipoEComm"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 34), LookupInclude]
    public string TipoEComm
    {
        get => fields.TipoEComm[this];
        set => fields.TipoEComm[this] = value;
    }

    [DisplayName("Rappi"), Column("RAPPI"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 35), LookupInclude]
    public string Rappi
    {
        get => fields.Rappi[this];
        set => fields.Rappi[this] = value;
    }

    [DisplayName("Tablet"), Column("TABLET"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 36), LookupInclude]
    public string Tablet
    {
        get => fields.Tablet[this];
        set => fields.Tablet[this] = value;
    }

    [DisplayName("N° Serie"),  Column("NSerie"), Size(50)]
    public string NSerie
    {
        get => fields.NSerie[this];
        set => fields.NSerie[this] = value;
    }

    [DisplayName("Estatus Tablet"), Column("EstatusTablet"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 37), LookupInclude]
    public string EstatusTablet
    {
        get => fields.EstatusTablet[this];
        set => fields.EstatusTablet[this] = value;
    }

    [DisplayName("QR"), Column("QR"), Size(50)]
    public string Qr
    {
        get => fields.Qr[this];
        set => fields.Qr[this] = value;
    }

    [DisplayName("Servicio a Domicilio (OPE)"), Column("ServicioDomicilio"), QuickSearch , Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 38), LookupInclude]
    public string ServicioDomicilio
    {
        get => fields.ServicioDomicilio[this];
        set => fields.ServicioDomicilio[this] = value;
    }

    [DisplayName("Prueba UBER"), Column("PruebaUBER"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 39), LookupInclude]
    public string PruebaUber
    {
        get => fields.PruebaUber[this];
        set => fields.PruebaUber[this] = value;
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
        public StringField VentaTelefonica;
        public StringField Garantizado;
        public StringField Hub;
        public StringField ECommerce;
        public StringField TipoEComm;
        public StringField Rappi;
        public StringField Tablet;
        public StringField NSerie;
        public StringField EstatusTablet;
        public StringField Qr;
        public StringField ServicioDomicilio;
        public StringField PruebaUber;
        //public DateTimeField DtRegistro;

    }
}