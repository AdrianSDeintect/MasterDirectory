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

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 65), LookupInclude]
    [DisplayName("Estado"), Size(50)]
    public string Estado
    {
        get => fields.Estado[this];
        set => fields.Estado[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 66), LookupInclude]
    [DisplayName("Proveedor - 99Min"), Column("Prov99Min"), Size(10)]
    public string Prov99Min
    {
        get => fields.Prov99Min[this];
        set => fields.Prov99Min[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 66), LookupInclude]
    [DisplayName("Proveedor - MU"), Column("ProvMU"), Size(10)]
    public string ProvMu
    {
        get => fields.ProvMu[this];
        set => fields.ProvMu[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 66), LookupInclude]
    [DisplayName("Proveedor - CID"), Column("ProvCID"), Size(10)]
    public string ProvCid
    {
        get => fields.ProvCid[this];
        set => fields.ProvCid[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 66), LookupInclude]
    [DisplayName("Proveedor - Rappi Cargo"), Column("ProvRappiCargo"), Size(10)]
    public string ProvRappiCargo
    {
        get => fields.ProvRappiCargo[this];
        set => fields.ProvRappiCargo[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 67), LookupInclude]
    [DisplayName("Venta Telefónica - 99Min"), Column("VentaTelf99Min"), Size(10)]
    public string VentaTelf99Min
    {
        get => fields.VentaTelf99Min[this];
        set => fields.VentaTelf99Min[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 67), LookupInclude]
    [DisplayName("Venta Telefónica - MU"), Column("VentaTelfMU"), Size(10)]
    public string VentaTelfMu
    {
        get => fields.VentaTelfMu[this];
        set => fields.VentaTelfMu[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 67), LookupInclude]
    [DisplayName("Venta Telefónica - CID"), Column("VentaTelfCID"), Size(10)]
    public string VentaTelfCid
    {
        get => fields.VentaTelfCid[this];
        set => fields.VentaTelfCid[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 67), LookupInclude]
    [DisplayName("Venta Telefónica - Rappi Cargo"), Column("VentaTelfRappiCargo"), Size(10)]
    public string VentaTelfRappiCargo
    {
        get => fields.VentaTelfRappiCargo[this];
        set => fields.VentaTelfRappiCargo[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 68), LookupInclude]
    [DisplayName("Garantizado - 99Min"), Column("Garantizado99Min"), Size(10)]
    public string Garantizado99Min
    {
        get => fields.Garantizado99Min[this];
        set => fields.Garantizado99Min[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 68), LookupInclude]
    [DisplayName("Garantizado - MU"), Column("GarantizadoMU"), Size(10)]
    public string GarantizadoMu
    {
        get => fields.GarantizadoMu[this];
        set => fields.GarantizadoMu[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 68), LookupInclude]
    [DisplayName("Garantizado - CID"), Column("GarantizadoCID"), Size(10)]
    public string GarantizadoCid
    {
        get => fields.GarantizadoCid[this];
        set => fields.GarantizadoCid[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 69), LookupInclude]
    [DisplayName("e-Commerce Delivery"), Column("eCommerceDelivery"), Size(10)]
    public string ECommerceDelivery
    {
        get => fields.ECommerceDelivery[this];
        set => fields.ECommerceDelivery[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 69), LookupInclude]
    [DisplayName("e-Commerce Click&Collect"), Column("eCommerceClickCollect"), Size(10)]
    public string ECommerceClickCollect
    {
        get => fields.ECommerceClickCollect[this];
        set => fields.ECommerceClickCollect[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 75), LookupInclude]
    [DisplayName("e-Commerce Tipo"), Column("eCommerceTipo"), Size(50)]
    public string ECommerceTipo
    {
        get => fields.ECommerceTipo[this];
        set => fields.ECommerceTipo[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 70), LookupInclude]
    [DisplayName("Fijo - 99Min"), Column("Fijo99Min"), Size(10)]
    public string Fijo99Min
    {
        get => fields.Fijo99Min[this];
        set => fields.Fijo99Min[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 70), LookupInclude]
    [DisplayName("Fijo - MU"), Column("FijoMU"), Size(10)]
    public string FijoMu
    {
        get => fields.FijoMu[this];
        set => fields.FijoMu[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 70), LookupInclude]
    [DisplayName("Fijo - CID"), Column("FijoCID"), Size(10)]
    public string FijoCid
    {
        get => fields.FijoCid[this];
        set => fields.FijoCid[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 71), LookupInclude]
    [DisplayName("On Demand - MU"), Column("OnDemandMU"), Size(10)]
    public string OnDemandMu
    {
        get => fields.OnDemandMu[this];
        set => fields.OnDemandMu[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 71), LookupInclude]
    [DisplayName("On Demand - Rappi Cargo"), Column("OnDemandRappiCargo"), Size(10)]
    public string OnDemandRappiCargo
    {
        get => fields.OnDemandRappiCargo[this];
        set => fields.OnDemandRappiCargo[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 72), LookupInclude]
    [DisplayName("Canales Digitales - Rappi"), Column("CanalesDigitalesRappi"), Size(10)]
    public string CanalesDigitalesRappi
    {
        get => fields.CanalesDigitalesRappi[this];
        set => fields.CanalesDigitalesRappi[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 72), LookupInclude]
    [DisplayName("Canales Digitales - Uber"), Column("CanalesDigitalesUber"), Size(10)]
    public string CanalesDigitalesUber
    {
        get => fields.CanalesDigitalesUber[this];
        set => fields.CanalesDigitalesUber[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 1"), Column("ServicioEfectivo1"), Size(10)]
    public string ServicioEfectivo1
    {
        get => fields.ServicioEfectivo1[this];
        set => fields.ServicioEfectivo1[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 2"), Column("ServicioEfectivo2"), Size(10)]
    public string ServicioEfectivo2
    {
        get => fields.ServicioEfectivo2[this];
        set => fields.ServicioEfectivo2[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 3"), Column("ServicioEfectivo3"), Size(10)]
    public string ServicioEfectivo3
    {
        get => fields.ServicioEfectivo3[this];
        set => fields.ServicioEfectivo3[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 4"), Column("ServicioEfectivo4"), Size(10)]
    public string ServicioEfectivo4
    {
        get => fields.ServicioEfectivo4[this];
        set => fields.ServicioEfectivo4[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 5"), Column("ServicioEfectivo5"), Size(10)]
    public string ServicioEfectivo5
    {
        get => fields.ServicioEfectivo5[this];
        set => fields.ServicioEfectivo5[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 6"), Column("ServicioEfectivo6"), Size(10)]
    public string ServicioEfectivo6
    {
        get => fields.ServicioEfectivo6[this];
        set => fields.ServicioEfectivo6[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 7"), Column("ServicioEfectivo7"), Size(10)]
    public string ServicioEfectivo7
    {
        get => fields.ServicioEfectivo7[this];
        set => fields.ServicioEfectivo7[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 73), LookupInclude]
    [DisplayName("Servicio Efectivo - 8"), Column("ServicioEfectivo8"), Size(10)]
    public string ServicioEfectivo8
    {
        get => fields.ServicioEfectivo8[this];
        set => fields.ServicioEfectivo8[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 74), LookupInclude]
    [DisplayName("Servicio Tarjeta - 9"), Column("ServicioTarjeta9"), Size(10)]
    public string ServicioTarjeta9
    {
        get => fields.ServicioTarjeta9[this];
        set => fields.ServicioTarjeta9[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 74), LookupInclude]
    [DisplayName("Servicio Tarjeta - 10"), Column("ServicioTarjeta10"), Size(10)]
    public string ServicioTarjeta10
    {
        get => fields.ServicioTarjeta10[this];
        set => fields.ServicioTarjeta10[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 74), LookupInclude]
    [DisplayName("Servicio Tarjeta - 11"), Column("ServicioTarjeta11"), Size(10)]
    public string ServicioTarjeta11
    {
        get => fields.ServicioTarjeta11[this];
        set => fields.ServicioTarjeta11[this] = value;
    }

    [LookupEditor(typeof(CatUltimaMillaLookup), FilterField = "IdtipoCatalogo", FilterValue = 74), LookupInclude]
    [DisplayName("Servicio Tarjeta - 12"), Column("ServicioTarjeta12"), Size(10)]
    public string ServicioTarjeta12
    {
        get => fields.ServicioTarjeta12[this];
        set => fields.ServicioTarjeta12[this] = value;
    }

    [DisplayName("Inicio de Servicio"), Column("InicioServicio")]
    public string InicioServicio
    {
        get => fields.InicioServicio[this];
        set => fields.InicioServicio[this] = value;
    }

    [DisplayName("Cierre de Servicio") , Column("CierreServicio")]
    public string CierreServicio
    {
        get => fields.CierreServicio[this];
        set => fields.CierreServicio[this] = value;
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
        public StringField Estado;
        public StringField Prov99Min;
        public StringField ProvMu;
        public StringField ProvCid;
        public StringField ProvRappiCargo;
        public StringField VentaTelf99Min;
        public StringField VentaTelfMu;
        public StringField VentaTelfCid;
        public StringField VentaTelfRappiCargo;
        public StringField Garantizado99Min;
        public StringField GarantizadoMu;
        public StringField GarantizadoCid;
        public StringField ECommerceDelivery;
        public StringField ECommerceClickCollect;
        public StringField ECommerceTipo;
        public StringField Fijo99Min;
        public StringField FijoMu;
        public StringField FijoCid;
        public StringField OnDemandMu;
        public StringField OnDemandRappiCargo;
        public StringField CanalesDigitalesRappi;
        public StringField CanalesDigitalesUber;
        public StringField ServicioEfectivo1;
        public StringField ServicioEfectivo2;
        public StringField ServicioEfectivo3;
        public StringField ServicioEfectivo4;
        public StringField ServicioEfectivo5;
        public StringField ServicioEfectivo6;
        public StringField ServicioEfectivo7;
        public StringField ServicioEfectivo8;
        public StringField ServicioTarjeta9;
        public StringField ServicioTarjeta10;
        public StringField ServicioTarjeta11;
        public StringField ServicioTarjeta12;
        public StringField InicioServicio;
        public StringField CierreServicio;
        //public DateTimeField DtRegistro;

    }
}